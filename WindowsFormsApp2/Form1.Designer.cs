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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            this.textboxXvalue = new System.Windows.Forms.TextBox();
            this.connectDisconnect = new System.Windows.Forms.Button();
            this.comSelectionBox = new System.Windows.Forms.ComboBox();
            this.textboxZvalue = new System.Windows.Forms.TextBox();
            this.textboxYvalue = new System.Windows.Forms.TextBox();
            this.gumStick = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textboxSerialBufferSize = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(121, 129);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(78, 25);
            label1.TabIndex = 1;
            label1.Text = "xValue";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(121, 203);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(78, 25);
            label2.TabIndex = 4;
            label2.Text = "zValue";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(121, 166);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(78, 25);
            label3.TabIndex = 5;
            label3.Text = "yValue";
            // 
            // textboxXvalue
            // 
            this.textboxXvalue.Location = new System.Drawing.Point(205, 129);
            this.textboxXvalue.Name = "textboxXvalue";
            this.textboxXvalue.Size = new System.Drawing.Size(100, 31);
            this.textboxXvalue.TabIndex = 0;
            // 
            // connectDisconnect
            // 
            this.connectDisconnect.Location = new System.Drawing.Point(162, 29);
            this.connectDisconnect.Name = "connectDisconnect";
            this.connectDisconnect.Size = new System.Drawing.Size(129, 40);
            this.connectDisconnect.TabIndex = 2;
            this.connectDisconnect.Text = "Connect";
            this.connectDisconnect.UseVisualStyleBackColor = true;
            this.connectDisconnect.Click += new System.EventHandler(this.connectDisconnect_Click);
            // 
            // comSelectionBox
            // 
            this.comSelectionBox.FormattingEnabled = true;
            this.comSelectionBox.Location = new System.Drawing.Point(35, 34);
            this.comSelectionBox.Name = "comSelectionBox";
            this.comSelectionBox.Size = new System.Drawing.Size(121, 33);
            this.comSelectionBox.TabIndex = 3;
            this.comSelectionBox.DropDown += new System.EventHandler(this.comSelectionBox_DropDown);
            // 
            // textboxZvalue
            // 
            this.textboxZvalue.Location = new System.Drawing.Point(205, 203);
            this.textboxZvalue.Name = "textboxZvalue";
            this.textboxZvalue.Size = new System.Drawing.Size(100, 31);
            this.textboxZvalue.TabIndex = 6;
            // 
            // textboxYvalue
            // 
            this.textboxYvalue.Location = new System.Drawing.Point(205, 166);
            this.textboxYvalue.Name = "textboxYvalue";
            this.textboxYvalue.Size = new System.Drawing.Size(100, 31);
            this.textboxYvalue.TabIndex = 7;
            // 
            // gumStick
            // 
            this.gumStick.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.gumStick_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(30, 92);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(178, 25);
            label4.TabIndex = 9;
            label4.Text = "Serial Buffer Size";
            // 
            // textboxSerialBufferSize
            // 
            this.textboxSerialBufferSize.Location = new System.Drawing.Point(205, 92);
            this.textboxSerialBufferSize.Name = "textboxSerialBufferSize";
            this.textboxSerialBufferSize.Size = new System.Drawing.Size(100, 31);
            this.textboxSerialBufferSize.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 478);
            this.Controls.Add(label4);
            this.Controls.Add(this.textboxSerialBufferSize);
            this.Controls.Add(this.textboxYvalue);
            this.Controls.Add(this.textboxZvalue);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.comSelectionBox);
            this.Controls.Add(this.connectDisconnect);
            this.Controls.Add(label1);
            this.Controls.Add(this.textboxXvalue);
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
    }
}

