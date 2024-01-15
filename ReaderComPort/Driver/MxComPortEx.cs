using System;
using System.Collections.Generic;
using System.IO.Ports;

namespace ReaderComPort.Driver {
    class MxComPortEx {
        public SerialPort port;
        public static List<byte> bufferRead = new List<byte>(6);

        public delegate void HandlerErr();
        public event HandlerErr eventError;
        //public delegate void HandlerReceived(string data);
        //public event HandlerReceived eventReceived;
        public delegate void HandlerReceivedListByte(List<byte> data);
        public event HandlerReceivedListByte eventReceivedListByte;
        //public delegate void HandlerReceivedByte(byte[] data);
        //public event HandlerReceivedByte eventReceivedByte;

        public MxComPortEx(string sPortName, int baudrate) {
            // create a SerialPort instance with basic settings port = new
            //SerialPort(sPortName, baudrate, Parity.None, 8, StopBits.One);
            port = new SerialPort(sPortName, baudrate, Parity.None, 8, StopBits.One);
            port.RtsEnable = true; // raise RTS for flow control
            port.ReadTimeout = 3000; // 3 second timeout
            // Attach a method to be called when there is data waiting in the port’sbuffer
            port.DataReceived += new SerialDataReceivedEventHandler(DataReceived);
            port.ErrorReceived += new SerialErrorReceivedEventHandler(ErrorEvent);

        }

        public void SetBaudrate(int baudrate) {
            port.BaudRate = baudrate;
        }

        public void SetPort(string sPortName) {
            port.PortName = sPortName;
        }

        public bool Open() {
            try {
                if (!port.IsOpen) {
                    port.Open();
                }
            } catch (Exception) {
                //MessageBox.Show("Error: " + e.Message);
                port.Close();
                return false;
            }
            return true;
        }
        public void Close() {
            if (port.IsOpen) port.Close();
        }
        public bool SendData(String str) {
            try {
                port.WriteLine(str); // отправляет точку
            } catch (Exception) {
                return false;
            }
            return true;
        }
        public bool SendData(byte[] buffer, int count) {
            try {
                port.Write(buffer, 0, count);
            } catch (Exception) {
                return false;
            }
            return true;
        }
        public bool SendData(List<byte> buffer) {
            try {
                port.Write(buffer.ToArray(), 0, buffer.Count);
            } catch (Exception) {
                return false;
            }
            return true;
        }
        public void ErrorEvent(object sender, SerialErrorReceivedEventArgs e) {
            if (eventError != null) eventError();
        }
        public void DataReceived(object sender, SerialDataReceivedEventArgs e) {
            // to string
            //string message = "";
            //while (port.BytesToRead > 0) {
            //    message += port.ReadByte();
            //}
            //if (eventReceived != null) eventReceived(message);


            // to mass byte[]   присылает с разрывом
            //byte[] data = new byte[10];
            //int cnt = 0;
            //while (port.BytesToRead > 0) {
            //    data[cnt] = (byte)port.ReadByte();
            //    cnt++;
            //    if (cnt >= 10)
            //        break;
            //}
            //if (eventReceivedByte != null) eventReceivedByte(data);


            // to List<byte> присылает с разрывом
            //List<byte> data = new List<byte>(10);
            //while (port.BytesToRead > 0) {
            //    data.Add((byte)port.ReadByte());
            //}
            //if (eventReceivedListByte != null) eventReceivedListByte(data);


            // для текущего протокола с 6 байтами
            List<byte> data = new List<byte>(6);
            while (port.BytesToRead < 6) {
            }
            while (port.BytesToRead > 0) {
                data.Add((byte)port.ReadByte());
            }

            if (eventReceivedListByte != null) eventReceivedListByte(data);
        }

        public bool IsOpen() {
            return port.IsOpen;
        }
    }
}
