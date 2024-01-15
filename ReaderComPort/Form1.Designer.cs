namespace ReaderComPort {
    partial class Form1 {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonMacros = new System.Windows.Forms.Button();
            this.buttonCending = new System.Windows.Forms.Button();
            this.comboBoxChangeComPort = new System.Windows.Forms.ComboBox();
            this.textBoxInputMessage = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.listView1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(402, 259);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel2.Controls.Add(this.buttonMacros, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonCending, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxChangeComPort, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxInputMessage, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonClear, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 229);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(396, 27);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonMacros
            // 
            this.buttonMacros.Location = new System.Drawing.Point(311, 3);
            this.buttonMacros.Name = "buttonMacros";
            this.buttonMacros.Size = new System.Drawing.Size(16, 21);
            this.buttonMacros.TabIndex = 2;
            this.buttonMacros.Text = "M";
            this.buttonMacros.UseVisualStyleBackColor = true;
            this.buttonMacros.Click += new System.EventHandler(this.buttonMacros_Click);
            // 
            // buttonCending
            // 
            this.buttonCending.Location = new System.Drawing.Point(238, 3);
            this.buttonCending.Name = "buttonCending";
            this.buttonCending.Size = new System.Drawing.Size(67, 21);
            this.buttonCending.TabIndex = 1;
            this.buttonCending.Text = "Отправить";
            this.buttonCending.UseVisualStyleBackColor = true;
            this.buttonCending.Click += new System.EventHandler(this.buttonCending_Click);
            // 
            // comboBoxChangeComPort
            // 
            this.comboBoxChangeComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChangeComPort.FormattingEnabled = true;
            this.comboBoxChangeComPort.Items.AddRange(new object[] {
            "COM1"});
            this.comboBoxChangeComPort.Location = new System.Drawing.Point(3, 3);
            this.comboBoxChangeComPort.Name = "comboBoxChangeComPort";
            this.comboBoxChangeComPort.Size = new System.Drawing.Size(72, 21);
            this.comboBoxChangeComPort.TabIndex = 0;
            this.comboBoxChangeComPort.SelectedIndexChanged += new System.EventHandler(this.comboBoxChangeComPort_SelectedIndexChanged);
            this.comboBoxChangeComPort.Click += new System.EventHandler(this.comboBoxChangeComPort_Click);
            // 
            // textBoxInputMessage
            // 
            this.textBoxInputMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInputMessage.Location = new System.Drawing.Point(83, 3);
            this.textBoxInputMessage.Name = "textBoxInputMessage";
            this.textBoxInputMessage.Size = new System.Drawing.Size(149, 20);
            this.textBoxInputMessage.TabIndex = 3;
            this.textBoxInputMessage.Text = "5A 00 FE 64 30 4B";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(333, 3);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(60, 21);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Очисить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNum,
            this.columnTime,
            this.columnHeaderState,
            this.columnData});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(396, 220);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnNum
            // 
            this.columnNum.Text = "№";
            this.columnNum.Width = 30;
            // 
            // columnTime
            // 
            this.columnTime.Text = "Время";
            this.columnTime.Width = 90;
            // 
            // columnHeaderState
            // 
            this.columnHeaderState.Text = "";
            this.columnHeaderState.Width = 25;
            // 
            // columnData
            // 
            this.columnData.Text = "Данные";
            this.columnData.Width = 229;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 259);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox comboBoxChangeComPort;
        private System.Windows.Forms.Button buttonCending;
        private System.Windows.Forms.Button buttonMacros;
        private System.Windows.Forms.TextBox textBoxInputMessage;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnTime;
        private System.Windows.Forms.ColumnHeader columnData;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ColumnHeader columnNum;
        private System.Windows.Forms.ColumnHeader columnHeaderState;
    }
}

