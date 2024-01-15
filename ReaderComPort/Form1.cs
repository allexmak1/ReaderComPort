using ReaderComPort.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReaderComPort {
    public partial class Form1 : Form {

        MxComPortEx comPort;
        int cntRow;
        List<string> nameComPort = new List<string>();

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            comPort = new MxComPortEx("COM1", 115200);
            comPort.eventError += eventError;
            comPort.eventReceivedListByte += eventReceived;
        }

        private void eventError() {
            listView1.Invoke(new Action(() => {
                setTextListView("E", "Error");// TODO так и не понял что за ошибка
            }));
        }

        private void eventReceived(List<byte> data) {
            listView1.Invoke(new Action(() => {
                string text = "";
                foreach (var d in data) {
                    text += d + " ";
                }
                setTextListView("<<", text);
            }));
        }

        private void buttonCending_Click(object sender, EventArgs e) {
            byte[] data = new byte[] { };
            try {
                string tempData = textBoxInputMessage.Text;//"5A 00 FE 64 30 4B";
                // убираем " " и "-" и "_"
                tempData = Regex.Replace(tempData, "(\\s+)|([-]+)|([_]+)", "");
                data = StringToByteArray(tempData);
                if (comPort.SendData(data, data.Length)) {// отправка сообщения
                    tempData = BitConverter.ToString(data);
                    //заменяем "-" на " "
                    tempData = Regex.Replace(tempData, "([-]+)", " ");
                    setTextListView(">>", tempData);

                } else {
                    setTextListView("E", "Error");
                }
            } catch (Exception) {
                MessageBox.Show("Неверный формат данных");
            }
        }

        private void buttonMacros_Click(object sender, EventArgs e) {
            // HEX 5A 00 FE 64 30 4B
            // dec 90 00 254 100 48 75
            byte[] data = new byte[] { 0x5A, 0x00, 0xFE, 0x64, 0x30, 0x4B };
            string tempData = "";
            if (comPort.SendData(data, data.Length)) {
                //listBox1.Items.Add(">-> " + "90 00 254 100 48 75\n");
                //textBoxReceive.Text += ">-> " + "90 00 254 100 48 75\n";
                //setTextListView(">>", "90 00 254 100 48 75");
                tempData = BitConverter.ToString(data);
                //заменяем "-" на " "
                tempData = Regex.Replace(tempData, "([-]+)", " ");
                setTextListView(">>", tempData);
            } else {
                setTextListView("E", "Error");
            }
        }

        private void comboBoxChangeComPort_Click(object sender, EventArgs e) {
            if (SerialPort.GetPortNames().Length <= 0)
                return;
            nameComPort.Clear();
            nameComPort = SerialPort.GetPortNames().ToList<string>();
            comboBoxChangeComPort.Items.Clear();
            comboBoxChangeComPort.Items.AddRange(nameComPort.ToArray());
        }

        private void comboBoxChangeComPort_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBoxChangeComPort.SelectedIndex >= 0) {
                setTextListView("", "Выбран " + comboBoxChangeComPort.SelectedItem);
                if (comPort != null) comPort.Close();
                comPort.SetPort(comboBoxChangeComPort.Text);
                if (!comPort.Open())
                    MessageBox.Show("Error: not open " + comboBoxChangeComPort.Text);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e) {
            listView1.Items.Clear();
            cntRow = 0;
        }

        private void setTextListView(string stat, string s) {
            cntRow++;
            listView1.Items.Add(new ListViewItem(new string[] { cntRow.ToString(), DateTime.Now.ToString("HH:mm:ss:fff"), stat, s }));
            //прокрутим вниз
            listView1.Items[listView1.Items.Count - 1].EnsureVisible();
        }

        public static byte[] StringToByteArray(string hex) {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }
    }
}
