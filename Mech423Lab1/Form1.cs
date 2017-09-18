using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Collections.Concurrent;
using System.Threading;
using System.Diagnostics;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        ConcurrentQueue<int> dataQueue = new ConcurrentQueue<int>();

        ConcurrentQueue<int> currentX = new ConcurrentQueue<int>();
        ConcurrentQueue<int> currentY = new ConcurrentQueue<int>();
        ConcurrentQueue<int> currentZ = new ConcurrentQueue<int>();

        ConcurrentQueue<string> punchResult = new ConcurrentQueue<string>();

        Queue<int> xData = new Queue<int>();
        Queue<int> yData = new Queue<int>();
        Queue<int> zData = new Queue<int>();

        public Form1()
        {
            
            InitializeComponent();
        }

        //Com selection dropdown
        private void comSelectionBox_DropDown(object sender, EventArgs e)
        {
            comSelectionBox.DataSource = SerialPort.GetPortNames();
        }

        //Connect/Disconnect Button
        private void connectDisconnect_Click(object sender, EventArgs e)
        {
            if (comSelectionBox.SelectedIndex > -1)
            {
                if (gumStick.IsOpen)
                {
                    gumStick.Close();
                    connectDisconnect.Text = "Connect";
                }
                else if (!gumStick.IsOpen)
                {
                    gumStick.PortName = comSelectionBox.SelectedItem.ToString();
                    gumStick.Open();
                    connectDisconnect.Text = "Disconnect";
                    backgroundWorker.RunWorkerAsync();
                }
            }
            else
            {
                MessageBox.Show("Please Select a Com Port");
            }
        }

        //timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (gumStick.IsOpen)
            {
                if (textboxQueueSetLength.Text == "")
                {
                    textboxQueueSetLength.Text =  "1";
                }
                
                int queueSetLength = int.Parse(textboxQueueSetLength.Text);
                
                //Buffer and Concurrent Queue Display
                textboxSerialBufferSize.Text = gumStick.BytesToRead.ToString();
                textboxQueueLength.Text = dataQueue.Count().ToString();

                //X Y and Z Queue display
                textboxXBufferSize.Text = xData.Count().ToString();
                textboxYBufferSize.Text = yData.Count().ToString();
                textboxZBufferSize.Text = zData.Count().ToString();

                //Displays the average, max, and min of accelerometer values stored in xData, yData, and zData
                if ((xData.Count > 0) && (yData.Count > 0) && (yData.Count > 0))
                {
                    textboxAverageX.Text = xData.Average().ToString();
                    textboxAverageY.Text = yData.Average().ToString();
                    textboxAverageZ.Text = zData.Average().ToString();

                    textBoxXMax.Text = xData.Max().ToString();
                    textBoxYMax.Text = yData.Max().ToString();
                    textBoxZMax.Text = zData.Max().ToString();

                    textBoxXMin.Text = xData.Min().ToString();
                    textBoxYMin.Text = yData.Min().ToString();
                    textBoxZMin.Text = zData.Min().ToString();

                    textBoxWorkerXQueueLength.Text = currentX.Count().ToString();
                    textBoxWorkerYQueueLength.Text = currentY.Count().ToString();
                    textBoxWorkerZQueueLength.Text = currentZ.Count().ToString();


                    punchResult.TryDequeue(out string currentResult);
                    textBoxPunchResult.Text = currentResult;
                }

                //Sorts dataQueue into xData, yData, and zData. Limits these queues to queueSetLength
                int currentByte;
                int dataByteState = 0;
                while (dataQueue.Count > 0)
                {
                    int xdir = 1;
                    int ydir = 1;
                    int zdir = 1;
                    int positiveXFlag = 0;
                    int positiveYFlag = 0;
                    int positiveZFlag = 0;

                    if (dataQueue.TryDequeue(out currentByte) == true)
                    {
                        if ((currentByte == 255) && (dataByteState == 0))
                        {
                            dataByteState = 1;
                        }

                        else if (dataByteState == 1)
                        {
                            xData.Enqueue(currentByte);
                            currentX.Enqueue(currentByte);
                            textboxXvalue.Text = currentByte.ToString();
                            dataChart.Series["X"].Points.DataBindY(xData);

                            if (currentByte > 200) { positiveXFlag = 1; }

                            xdir = 1;
                            if (currentByte > 140)      {xdir = 2;}
                            else if (currentByte < 110) {xdir = 0;}

                            textBoxXdir.Text = xdir.ToString();

                            if (xData.Count > queueSetLength)   {xData.Dequeue();}

                            dataByteState = 2;
                        }

                        else if (dataByteState == 2)
                        {
                            yData.Enqueue(currentByte);
                            currentY.Enqueue(currentByte);
                            textboxYvalue.Text = currentByte.ToString();
                            dataChart.Series["Y"].Points.DataBindY(yData);

                            if (currentByte > 200) { positiveYFlag = 1; }

                            ydir = 1;

                            if (currentByte > 140)      {ydir = 2;}
                            else if (currentByte < 110) {ydir = 0;}

                            textBoxYdir.Text = ydir.ToString();

                            if (yData.Count > queueSetLength)   {yData.Dequeue();}

                            dataByteState = 3;
                        }

                        else if (dataByteState == 3)
                        {
                            zData.Enqueue(currentByte);
                            currentZ.Enqueue(currentByte);
                            textboxZvalue.Text = currentByte.ToString();
                            dataChart.Series["Z"].Points.DataBindY(zData);

                            if (currentByte > 200) { positiveZFlag = 1; }

                            zdir = 1;

                            if (currentByte > 140)      {zdir = 2;}
                            else if (currentByte < 110) {zdir = 0;}

                            textBoxZdir.Text = zdir.ToString();

                            if (zData.Count > queueSetLength)   {zData.Dequeue();}

                            dataByteState = 0;
                        }

                        if ((positiveXFlag == 1) && (positiveYFlag == 1) && (positiveZFlag == 1)) { }

                        if ((xdir == 1) && (ydir == 1) && (zdir == 2))      {textBoxOrientation.Text = "Flat";}
                        else if ((xdir == 1) && (ydir == 0) && (zdir == 1)) {textBoxOrientation.Text = "Tilted Left";}
                        else if ((xdir == 1) && (ydir == 2) && (zdir == 1)) {textBoxOrientation.Text = "Tilted Right";}
                        else if ((xdir == 0) && (ydir == 1) && (zdir == 1)) {textBoxOrientation.Text = "Tilted Forward";}
                        else if ((xdir == 2) && (ydir == 1) && (zdir == 1)) {textBoxOrientation.Text = "Tilted Back";}
                        else if ((xdir == 1) && (ydir == 1) && (zdir == 0)) {textBoxOrientation.Text = "Upside Down";}
                    }
                }
            }
        }

        //Insert buffer into concurrent queue
        private void gumStick_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int bufferSize = gumStick.BytesToRead;

            while (bufferSize > 4)
            {
                dataQueue.Enqueue(gumStick.ReadByte());
                bufferSize--;
            }
        }

        //Reset Button
        private void button1_Click(object sender, EventArgs e)
        {
            xData.Clear();
            yData.Clear();
            zData.Clear();

            if (gumStick.IsOpen)    {gumStick.DiscardInBuffer();}
            else{textboxSerialBufferSize.Text = 0.ToString();}

            ConcurrentQueue<int> dataQueue = new ConcurrentQueue<int>();

            textboxQueueLength.Text = dataQueue.Count().ToString();
            textboxXBufferSize.Text = xData.Count().ToString();
            textboxYBufferSize.Text = yData.Count().ToString();
            textboxZBufferSize.Text = zData.Count().ToString();
            textboxAverageX.Text = "0";
            textboxAverageY.Text = "0";
            textboxAverageZ.Text = "0";
        }

        //Form Exit Cleanup
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (gumStick.IsOpen){gumStick.Close();}
        }

        private void backgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
        {
            Stopwatch time = new Stopwatch();
            int X = 1;
            int Y = 1;
            int Z = 1;
            while (gumStick.IsOpen)
            {

                currentX.TryDequeue(out X);
                currentY.TryDequeue(out Y);
                currentZ.TryDequeue(out Z);

                if (X > 190)
                {

                    time.Start();
                    while(time.Elapsed < TimeSpan.FromSeconds(1))
                    {
                        if (Y > 200)
                        {
                            while(time.Elapsed < TimeSpan.FromSeconds(2))
                            {
                                if (Z > 200)
                                {
                                    while (time.Elapsed < TimeSpan.FromSeconds(3))
                                    {
                                        punchResult.Enqueue("Right Hook!!!");
                                    }
                                }
                            }
                        }
                    }
                    while(time.Elapsed < TimeSpan.FromSeconds(2))
                    {
                        punchResult.Enqueue("Lame Punch...");
                    }
                    time.Reset();
                }
                if (punchResult.Count > 0)
                {
                    punchResult.TryDequeue(out string dump);
                }
            }
        }
    }
}