namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textboxXvalue = new System.Windows.Forms.TextBox();
            this.connectDisconnect = new System.Windows.Forms.Button();
            this.comSelectionBox = new System.Windows.Forms.ComboBox();
            this.textboxZvalue = new System.Windows.Forms.TextBox();
            this.textboxYvalue = new System.Windows.Forms.TextBox();
            this.gumStick = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textboxSerialBufferSize = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textboxQueueLength = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "xValue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "zValue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "yValue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Serial Buffer Size";
            // 
            // textboxXvalue
            // 
            this.textboxXvalue.Location = new System.Drawing.Point(102, 102);
            this.textboxXvalue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textboxXvalue.Name = "textboxXvalue";
            this.textboxXvalue.Size = new System.Drawing.Size(52, 20);
            this.textboxXvalue.TabIndex = 0;
            // 
            // connectDisconnect
            // 
            this.connectDisconnect.Location = new System.Drawing.Point(81, 15);
            this.connectDisconnect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.connectDisconnect.Name = "connectDisconnect";
            this.connectDisconnect.Size = new System.Drawing.Size(64, 21);
            this.connectDisconnect.TabIndex = 2;
            this.connectDisconnect.Text = "Connect";
            this.connectDisconnect.UseVisualStyleBackColor = true;
            this.connectDisconnect.Click += new System.EventHandler(this.connectDisconnect_Click);
            // 
            // comSelectionBox
            // 
            this.comSelectionBox.FormattingEnabled = true;
            this.comSelectionBox.Location = new System.Drawing.Point(18, 18);
            this.comSelectionBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comSelectionBox.Name = "comSelectionBox";
            this.comSelectionBox.Size = new System.Drawing.Size(62, 21);
            this.comSelectionBox.TabIndex = 3;
            this.comSelectionBox.DropDown += new System.EventHandler(this.comSelectionBox_DropDown);
            // 
            // textboxZvalue
            // 
            this.textboxZvalue.Location = new System.Drawing.Point(102, 141);
            this.textboxZvalue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textboxZvalue.Name = "textboxZvalue";
            this.textboxZvalue.Size = new System.Drawing.Size(52, 20);
            this.textboxZvalue.TabIndex = 6;
            // 
            // textboxYvalue
            // 
            this.textboxYvalue.Location = new System.Drawing.Point(102, 121);
            this.textboxYvalue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textboxYvalue.Name = "textboxYvalue";
            this.textboxYvalue.Size = new System.Drawing.Size(52, 20);
            this.textboxYvalue.TabIndex = 7;
            // 
            // gumStick
            // 
            this.gumStick.BaudRate = 128000;
            this.gumStick.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.gumStick_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textboxSerialBufferSize
            // 
            this.textboxSerialBufferSize.Location = new System.Drawing.Point(102, 48);
            this.textboxSerialBufferSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textboxSerialBufferSize.Name = "textboxSerialBufferSize";
            this.textboxSerialBufferSize.Size = new System.Drawing.Size(52, 20);
            this.textboxSerialBufferSize.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Queue Length";
            // 
            // textboxQueueLength
            // 
            this.textboxQueueLength.Location = new System.Drawing.Point(102, 72);
            this.textboxQueueLength.Margin = new System.Windows.Forms.Padding(2);
            this.textboxQueueLength.Name = "textboxQueueLength";
            this.textboxQueueLength.Size = new System.Drawing.Size(52, 20);
            this.textboxQueueLength.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 249);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textboxQueueLength);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textboxSerialBufferSize);
            this.Controls.Add(this.textboxYvalue);
            this.Controls.Add(this.textboxZvalue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comSelectionBox);
            this.Controls.Add(this.connectDisconnect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxXvalue);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxXvalue;
        private System.Windows.Forms.Button connectDisconnect;
        private System.Windows.Forms.ComboBox comSelectionBox;
        private System.Windows.Forms.TextBox textboxZvalue;
        private System.Windows.Forms.TextBox textboxYvalue;
        private System.IO.Ports.SerialPort gumStick;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textboxSerialBufferSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textboxQueueLength;
    }
}

