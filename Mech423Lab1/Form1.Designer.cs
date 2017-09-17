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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.textboxXBufferSize = new System.Windows.Forms.TextBox();
            this.textboxYBufferSize = new System.Windows.Forms.TextBox();
            this.textboxZBufferSize = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textboxAverageZ = new System.Windows.Forms.TextBox();
            this.textboxAverageY = new System.Windows.Forms.TextBox();
            this.textboxAverageX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textboxQueueSetLength = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 173);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Z";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Serial Buffer Size";
            // 
            // textboxXvalue
            // 
            this.textboxXvalue.Location = new System.Drawing.Point(34, 122);
            this.textboxXvalue.Margin = new System.Windows.Forms.Padding(2);
            this.textboxXvalue.Name = "textboxXvalue";
            this.textboxXvalue.Size = new System.Drawing.Size(52, 20);
            this.textboxXvalue.TabIndex = 0;
            // 
            // connectDisconnect
            // 
            this.connectDisconnect.Location = new System.Drawing.Point(134, 18);
            this.connectDisconnect.Margin = new System.Windows.Forms.Padding(2);
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
            this.comSelectionBox.Location = new System.Drawing.Point(15, 18);
            this.comSelectionBox.Margin = new System.Windows.Forms.Padding(2);
            this.comSelectionBox.Name = "comSelectionBox";
            this.comSelectionBox.Size = new System.Drawing.Size(115, 21);
            this.comSelectionBox.TabIndex = 3;
            this.comSelectionBox.DropDown += new System.EventHandler(this.comSelectionBox_DropDown);
            // 
            // textboxZvalue
            // 
            this.textboxZvalue.Location = new System.Drawing.Point(34, 170);
            this.textboxZvalue.Margin = new System.Windows.Forms.Padding(2);
            this.textboxZvalue.Name = "textboxZvalue";
            this.textboxZvalue.Size = new System.Drawing.Size(52, 20);
            this.textboxZvalue.TabIndex = 6;
            // 
            // textboxYvalue
            // 
            this.textboxYvalue.Location = new System.Drawing.Point(34, 146);
            this.textboxYvalue.Margin = new System.Windows.Forms.Padding(2);
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
            this.textboxSerialBufferSize.Location = new System.Drawing.Point(146, 52);
            this.textboxSerialBufferSize.Margin = new System.Windows.Forms.Padding(2);
            this.textboxSerialBufferSize.Name = "textboxSerialBufferSize";
            this.textboxSerialBufferSize.Size = new System.Drawing.Size(52, 20);
            this.textboxSerialBufferSize.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Queue Length";
            // 
            // textboxQueueLength
            // 
            this.textboxQueueLength.Location = new System.Drawing.Point(146, 76);
            this.textboxQueueLength.Margin = new System.Windows.Forms.Padding(2);
            this.textboxQueueLength.Name = "textboxQueueLength";
            this.textboxQueueLength.Size = new System.Drawing.Size(52, 20);
            this.textboxQueueLength.TabIndex = 10;
            // 
            // textboxXBufferSize
            // 
            this.textboxXBufferSize.Location = new System.Drawing.Point(90, 122);
            this.textboxXBufferSize.Margin = new System.Windows.Forms.Padding(2);
            this.textboxXBufferSize.Name = "textboxXBufferSize";
            this.textboxXBufferSize.Size = new System.Drawing.Size(52, 20);
            this.textboxXBufferSize.TabIndex = 12;
            // 
            // textboxYBufferSize
            // 
            this.textboxYBufferSize.Location = new System.Drawing.Point(90, 146);
            this.textboxYBufferSize.Margin = new System.Windows.Forms.Padding(2);
            this.textboxYBufferSize.Name = "textboxYBufferSize";
            this.textboxYBufferSize.Size = new System.Drawing.Size(52, 20);
            this.textboxYBufferSize.TabIndex = 13;
            // 
            // textboxZBufferSize
            // 
            this.textboxZBufferSize.Location = new System.Drawing.Point(90, 170);
            this.textboxZBufferSize.Margin = new System.Windows.Forms.Padding(2);
            this.textboxZBufferSize.Name = "textboxZBufferSize";
            this.textboxZBufferSize.Size = new System.Drawing.Size(52, 20);
            this.textboxZBufferSize.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 107);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Value";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 107);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Buffer Size";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataChart
            // 
            this.dataChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.dataChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.dataChart.Legends.Add(legend2);
            this.dataChart.Location = new System.Drawing.Point(203, 18);
            this.dataChart.Name = "dataChart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "X";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "Y";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "Z";
            this.dataChart.Series.Add(series4);
            this.dataChart.Series.Add(series5);
            this.dataChart.Series.Add(series6);
            this.dataChart.Size = new System.Drawing.Size(270, 198);
            this.dataChart.TabIndex = 18;
            this.dataChart.Text = "chart";
            // 
            // textboxAverageZ
            // 
            this.textboxAverageZ.Location = new System.Drawing.Point(146, 170);
            this.textboxAverageZ.Margin = new System.Windows.Forms.Padding(2);
            this.textboxAverageZ.Name = "textboxAverageZ";
            this.textboxAverageZ.Size = new System.Drawing.Size(52, 20);
            this.textboxAverageZ.TabIndex = 21;
            // 
            // textboxAverageY
            // 
            this.textboxAverageY.Location = new System.Drawing.Point(146, 146);
            this.textboxAverageY.Margin = new System.Windows.Forms.Padding(2);
            this.textboxAverageY.Name = "textboxAverageY";
            this.textboxAverageY.Size = new System.Drawing.Size(52, 20);
            this.textboxAverageY.TabIndex = 20;
            // 
            // textboxAverageX
            // 
            this.textboxAverageX.Location = new System.Drawing.Point(146, 122);
            this.textboxAverageX.Margin = new System.Windows.Forms.Padding(2);
            this.textboxAverageX.Name = "textboxAverageX";
            this.textboxAverageX.Size = new System.Drawing.Size(52, 20);
            this.textboxAverageX.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(149, 107);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Average";
            // 
            // textboxQueueSetLength
            // 
            this.textboxQueueSetLength.Location = new System.Drawing.Point(78, 195);
            this.textboxQueueSetLength.Name = "textboxQueueSetLength";
            this.textboxQueueSetLength.Size = new System.Drawing.Size(42, 20);
            this.textboxQueueSetLength.TabIndex = 23;
            this.textboxQueueSetLength.Text = "100";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 198);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Buffer Size";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 228);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textboxQueueSetLength);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textboxAverageZ);
            this.Controls.Add(this.textboxAverageY);
            this.Controls.Add(this.textboxAverageX);
            this.Controls.Add(this.dataChart);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textboxZBufferSize);
            this.Controls.Add(this.textboxYBufferSize);
            this.Controls.Add(this.textboxXBufferSize);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataChart)).EndInit();
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
        private System.Windows.Forms.TextBox textboxXBufferSize;
        private System.Windows.Forms.TextBox textboxYBufferSize;
        private System.Windows.Forms.TextBox textboxZBufferSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart dataChart;
        private System.Windows.Forms.TextBox textboxAverageZ;
        private System.Windows.Forms.TextBox textboxAverageY;
        private System.Windows.Forms.TextBox textboxAverageX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textboxQueueSetLength;
        private System.Windows.Forms.Label label9;
    }
}

