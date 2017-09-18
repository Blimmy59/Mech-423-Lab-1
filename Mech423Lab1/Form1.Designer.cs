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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxZdir = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxYdir = new System.Windows.Forms.TextBox();
            this.textBoxXdir = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxOrientation = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxZMin = new System.Windows.Forms.TextBox();
            this.textBoxYMin = new System.Windows.Forms.TextBox();
            this.textBoxXMin = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxZMax = new System.Windows.Forms.TextBox();
            this.textBoxYMax = new System.Windows.Forms.TextBox();
            this.textBoxXMax = new System.Windows.Forms.TextBox();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.textBoxWorkerYQueueLength = new System.Windows.Forms.TextBox();
            this.textBoxWorkerZQueueLength = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxWorkerXQueueLength = new System.Windows.Forms.TextBox();
            this.textBoxPunchResult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Z";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 308);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Serial Buffer Size";
            // 
            // textboxXvalue
            // 
            this.textboxXvalue.Location = new System.Drawing.Point(34, 60);
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
            this.textboxZvalue.Location = new System.Drawing.Point(34, 108);
            this.textboxZvalue.Margin = new System.Windows.Forms.Padding(2);
            this.textboxZvalue.Name = "textboxZvalue";
            this.textboxZvalue.Size = new System.Drawing.Size(52, 20);
            this.textboxZvalue.TabIndex = 6;
            // 
            // textboxYvalue
            // 
            this.textboxYvalue.Location = new System.Drawing.Point(34, 84);
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
            this.textboxSerialBufferSize.Location = new System.Drawing.Point(102, 305);
            this.textboxSerialBufferSize.Margin = new System.Windows.Forms.Padding(2);
            this.textboxSerialBufferSize.Name = "textboxSerialBufferSize";
            this.textboxSerialBufferSize.Size = new System.Drawing.Size(52, 20);
            this.textboxSerialBufferSize.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 332);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Queue Length";
            // 
            // textboxQueueLength
            // 
            this.textboxQueueLength.Location = new System.Drawing.Point(102, 329);
            this.textboxQueueLength.Margin = new System.Windows.Forms.Padding(2);
            this.textboxQueueLength.Name = "textboxQueueLength";
            this.textboxQueueLength.Size = new System.Drawing.Size(52, 20);
            this.textboxQueueLength.TabIndex = 10;
            // 
            // textboxXBufferSize
            // 
            this.textboxXBufferSize.Location = new System.Drawing.Point(90, 60);
            this.textboxXBufferSize.Margin = new System.Windows.Forms.Padding(2);
            this.textboxXBufferSize.Name = "textboxXBufferSize";
            this.textboxXBufferSize.Size = new System.Drawing.Size(52, 20);
            this.textboxXBufferSize.TabIndex = 12;
            // 
            // textboxYBufferSize
            // 
            this.textboxYBufferSize.Location = new System.Drawing.Point(90, 84);
            this.textboxYBufferSize.Margin = new System.Windows.Forms.Padding(2);
            this.textboxYBufferSize.Name = "textboxYBufferSize";
            this.textboxYBufferSize.Size = new System.Drawing.Size(52, 20);
            this.textboxYBufferSize.TabIndex = 13;
            // 
            // textboxZBufferSize
            // 
            this.textboxZBufferSize.Location = new System.Drawing.Point(90, 108);
            this.textboxZBufferSize.Margin = new System.Windows.Forms.Padding(2);
            this.textboxZBufferSize.Name = "textboxZBufferSize";
            this.textboxZBufferSize.Size = new System.Drawing.Size(52, 20);
            this.textboxZBufferSize.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 45);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Value";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 45);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Buffer Size";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 133);
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
            chartArea1.Name = "ChartArea1";
            this.dataChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.dataChart.Legends.Add(legend1);
            this.dataChart.Location = new System.Drawing.Point(350, 18);
            this.dataChart.Name = "dataChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "X";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Y";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Z";
            this.dataChart.Series.Add(series1);
            this.dataChart.Series.Add(series2);
            this.dataChart.Series.Add(series3);
            this.dataChart.Size = new System.Drawing.Size(623, 321);
            this.dataChart.TabIndex = 18;
            this.dataChart.Text = "chart";
            // 
            // textboxAverageZ
            // 
            this.textboxAverageZ.Location = new System.Drawing.Point(146, 108);
            this.textboxAverageZ.Margin = new System.Windows.Forms.Padding(2);
            this.textboxAverageZ.Name = "textboxAverageZ";
            this.textboxAverageZ.Size = new System.Drawing.Size(52, 20);
            this.textboxAverageZ.TabIndex = 21;
            // 
            // textboxAverageY
            // 
            this.textboxAverageY.Location = new System.Drawing.Point(146, 84);
            this.textboxAverageY.Margin = new System.Windows.Forms.Padding(2);
            this.textboxAverageY.Name = "textboxAverageY";
            this.textboxAverageY.Size = new System.Drawing.Size(52, 20);
            this.textboxAverageY.TabIndex = 20;
            // 
            // textboxAverageX
            // 
            this.textboxAverageX.Location = new System.Drawing.Point(146, 60);
            this.textboxAverageX.Margin = new System.Windows.Forms.Padding(2);
            this.textboxAverageX.Name = "textboxAverageX";
            this.textboxAverageX.Size = new System.Drawing.Size(52, 20);
            this.textboxAverageX.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(149, 45);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Average";
            // 
            // textboxQueueSetLength
            // 
            this.textboxQueueSetLength.Location = new System.Drawing.Point(146, 133);
            this.textboxQueueSetLength.Name = "textboxQueueSetLength";
            this.textboxQueueSetLength.Size = new System.Drawing.Size(52, 20);
            this.textboxQueueSetLength.TabIndex = 23;
            this.textboxQueueSetLength.Text = "100";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 136);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Buffer Size";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(160, 167);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Zdir";
            // 
            // textBoxZdir
            // 
            this.textBoxZdir.Location = new System.Drawing.Point(146, 182);
            this.textBoxZdir.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxZdir.Name = "textBoxZdir";
            this.textBoxZdir.Size = new System.Drawing.Size(52, 20);
            this.textBoxZdir.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(105, 167);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Ydir";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(48, 167);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Xdir";
            // 
            // textBoxYdir
            // 
            this.textBoxYdir.Location = new System.Drawing.Point(90, 182);
            this.textBoxYdir.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxYdir.Name = "textBoxYdir";
            this.textBoxYdir.Size = new System.Drawing.Size(52, 20);
            this.textBoxYdir.TabIndex = 26;
            // 
            // textBoxXdir
            // 
            this.textBoxXdir.Location = new System.Drawing.Point(34, 182);
            this.textBoxXdir.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxXdir.Name = "textBoxXdir";
            this.textBoxXdir.Size = new System.Drawing.Size(52, 20);
            this.textBoxXdir.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(211, 167);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Orientation";
            // 
            // textBoxOrientation
            // 
            this.textBoxOrientation.Location = new System.Drawing.Point(202, 182);
            this.textBoxOrientation.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxOrientation.Name = "textBoxOrientation";
            this.textBoxOrientation.Size = new System.Drawing.Size(77, 20);
            this.textBoxOrientation.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(216, 45);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "Min";
            // 
            // textBoxZMin
            // 
            this.textBoxZMin.Location = new System.Drawing.Point(202, 108);
            this.textBoxZMin.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxZMin.Name = "textBoxZMin";
            this.textBoxZMin.Size = new System.Drawing.Size(52, 20);
            this.textBoxZMin.TabIndex = 35;
            // 
            // textBoxYMin
            // 
            this.textBoxYMin.Location = new System.Drawing.Point(202, 84);
            this.textBoxYMin.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxYMin.Name = "textBoxYMin";
            this.textBoxYMin.Size = new System.Drawing.Size(52, 20);
            this.textBoxYMin.TabIndex = 34;
            // 
            // textBoxXMin
            // 
            this.textBoxXMin.Location = new System.Drawing.Point(202, 60);
            this.textBoxXMin.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxXMin.Name = "textBoxXMin";
            this.textBoxXMin.Size = new System.Drawing.Size(52, 20);
            this.textBoxXMin.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(272, 45);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 13);
            this.label15.TabIndex = 40;
            this.label15.Text = "Max";
            // 
            // textBoxZMax
            // 
            this.textBoxZMax.Location = new System.Drawing.Point(258, 108);
            this.textBoxZMax.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxZMax.Name = "textBoxZMax";
            this.textBoxZMax.Size = new System.Drawing.Size(52, 20);
            this.textBoxZMax.TabIndex = 39;
            // 
            // textBoxYMax
            // 
            this.textBoxYMax.Location = new System.Drawing.Point(258, 84);
            this.textBoxYMax.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxYMax.Name = "textBoxYMax";
            this.textBoxYMax.Size = new System.Drawing.Size(52, 20);
            this.textBoxYMax.TabIndex = 38;
            // 
            // textBoxXMax
            // 
            this.textBoxXMax.Location = new System.Drawing.Point(258, 60);
            this.textBoxXMax.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxXMax.Name = "textBoxXMax";
            this.textBoxXMax.Size = new System.Drawing.Size(52, 20);
            this.textBoxXMax.TabIndex = 37;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork_1);
            // 
            // textBoxWorkerYQueueLength
            // 
            this.textBoxWorkerYQueueLength.Location = new System.Drawing.Point(184, 242);
            this.textBoxWorkerYQueueLength.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxWorkerYQueueLength.Name = "textBoxWorkerYQueueLength";
            this.textBoxWorkerYQueueLength.Size = new System.Drawing.Size(52, 20);
            this.textBoxWorkerYQueueLength.TabIndex = 46;
            // 
            // textBoxWorkerZQueueLength
            // 
            this.textBoxWorkerZQueueLength.Location = new System.Drawing.Point(184, 266);
            this.textBoxWorkerZQueueLength.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxWorkerZQueueLength.Name = "textBoxWorkerZQueueLength";
            this.textBoxWorkerZQueueLength.Size = new System.Drawing.Size(52, 20);
            this.textBoxWorkerZQueueLength.TabIndex = 45;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(57, 245);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(123, 13);
            this.label17.TabIndex = 44;
            this.label17.Text = "Worker Y Queue Length";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(57, 269);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(123, 13);
            this.label18.TabIndex = 43;
            this.label18.Text = "Worker Z Queue Length";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(57, 221);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(123, 13);
            this.label19.TabIndex = 42;
            this.label19.Text = "Worker X Queue Length";
            // 
            // textBoxWorkerXQueueLength
            // 
            this.textBoxWorkerXQueueLength.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxWorkerXQueueLength.Location = new System.Drawing.Point(184, 218);
            this.textBoxWorkerXQueueLength.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxWorkerXQueueLength.Name = "textBoxWorkerXQueueLength";
            this.textBoxWorkerXQueueLength.Size = new System.Drawing.Size(52, 20);
            this.textBoxWorkerXQueueLength.TabIndex = 41;
            // 
            // textBoxPunchResult
            // 
            this.textBoxPunchResult.Location = new System.Drawing.Point(214, 319);
            this.textBoxPunchResult.Name = "textBoxPunchResult";
            this.textBoxPunchResult.Size = new System.Drawing.Size(100, 20);
            this.textBoxPunchResult.TabIndex = 47;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 351);
            this.Controls.Add(this.textBoxPunchResult);
            this.Controls.Add(this.textBoxWorkerYQueueLength);
            this.Controls.Add(this.textBoxWorkerZQueueLength);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textBoxWorkerXQueueLength);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBoxZMax);
            this.Controls.Add(this.textBoxYMax);
            this.Controls.Add(this.textBoxXMax);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBoxZMin);
            this.Controls.Add(this.textBoxYMin);
            this.Controls.Add(this.textBoxXMin);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxOrientation);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxZdir);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxYdir);
            this.Controls.Add(this.textBoxXdir);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxZdir;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxYdir;
        private System.Windows.Forms.TextBox textBoxXdir;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxOrientation;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxZMin;
        private System.Windows.Forms.TextBox textBoxYMin;
        private System.Windows.Forms.TextBox textBoxXMin;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxZMax;
        private System.Windows.Forms.TextBox textBoxYMax;
        private System.Windows.Forms.TextBox textBoxXMax;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.TextBox textBoxWorkerYQueueLength;
        private System.Windows.Forms.TextBox textBoxWorkerZQueueLength;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxWorkerXQueueLength;
        private System.Windows.Forms.TextBox textBoxPunchResult;
    }
}

