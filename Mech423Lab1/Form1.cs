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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        ConcurrentQueue<int> dataQueue = new ConcurrentQueue<int>();
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
            string[] comPorts = SerialPort.GetPortNames();
            comSelectionBox.DataSource = comPorts;
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
                }
            }
            else
            {
                MessageBox.Show("Please Select a Com Port");
            }
        }

        //Worker timer
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
                    textBoxZMax.Text = yData.Max().ToString();

                    textBoxXMin.Text = xData.Min().ToString();
                    textBoxYMin.Text = yData.Min().ToString();
                    textBoxZMin.Text = yData.Min().ToString();
                }

                //Sorts dataQueue into xData, yData, and zData. Limits these queues to queueSetLength
                int currentByte;
                int dataByteState = 0;
                while (dataQueue.Count > 0)
                {
                    int xdir = 1;
                    int ydir = 1;
                    int zdir = 1;

                    if (dataQueue.TryDequeue(out currentByte) == true)
                    {
                        if ((currentByte == 255) && (dataByteState == 0))
                        {
                            dataByteState = 1;
                        }

                        else if (dataByteState == 1)
                        {
                            xData.Enqueue(currentByte);
                            textboxXvalue.Text = currentByte.ToString();
                            dataChart.Series["X"].Points.DataBindY(xData);

                            xdir = 1;

                            if (currentByte > 140)
                            {
                                xdir = 2;
                            }
                            else if (currentByte < 110)
                            {
                                xdir = 0;
                            }

                            textBoxXdir.Text = xdir.ToString();

                            if (xData.Count > queueSetLength)
                            {
                                int dump = xData.Dequeue();
                            }

                            dataByteState = 2;
                        }

                        else if (dataByteState == 2)
                        {
                            yData.Enqueue(currentByte);
                            textboxYvalue.Text = currentByte.ToString();
                            dataChart.Series["Y"].Points.DataBindY(yData);

                            ydir = 1;

                            if (currentByte > 140)
                            {
                                ydir = 2;
                            }
                            else if (currentByte < 110)
                            {
                                ydir = 0;
                            }

                            textBoxYdir.Text = ydir.ToString();

                            if (yData.Count > queueSetLength)
                            {
                                int dump = yData.Dequeue();
                            }

                            dataByteState = 3;
                        }

                        else if (dataByteState == 3)
                        {
                            zData.Enqueue(currentByte);
                            textboxZvalue.Text = currentByte.ToString();
                            dataChart.Series["Z"].Points.DataBindY(zData);

                            zdir = 1;

                            if (currentByte > 140)
                            {
                                zdir = 2;
                            }
                            else if (currentByte < 110)
                            {
                                zdir = 0;
                            }

                            textBoxZdir.Text = zdir.ToString();

                            if (zData.Count > queueSetLength)
                            {
                                int dump = zData.Dequeue();
                            }

                            dataByteState = 0;
                        }

                        if ((xdir == 1) && (ydir == 1) && (zdir == 2))
                        {
                            textBoxOrientation.Text = "Flat";
                        }
                        else if ((xdir == 1) && (ydir == 0) && (zdir == 1))
                        {
                            textBoxOrientation.Text = "Tilted Left";
                        }
                        else if ((xdir == 1) && (ydir == 2) && (zdir == 1))
                        {
                            textBoxOrientation.Text = "Tilted Right";
                        }
                        else if ((xdir == 0) && (ydir == 1) && (zdir == 1))
                        {
                            textBoxOrientation.Text = "Tilted Forward";
                        }
                        else if ((xdir == 2) && (ydir == 1) && (zdir == 1))
                        {
                            textBoxOrientation.Text = "Tilted Back";
                        }
                        else if ((xdir == 1) && (ydir == 1) && (zdir == 0))
                        {
                            textBoxOrientation.Text = "Upside Down";
                        }
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

            if (gumStick.IsOpen)
            {
                gumStick.DiscardInBuffer();
            }
            else
            {
                textboxSerialBufferSize.Text = 0.ToString();
            }

            ConcurrentQueue<int> dataQueue = new ConcurrentQueue<int>();

            int queueLength = dataQueue.Count();
            textboxQueueLength.Text = queueLength.ToString();

            int xQueLength = xData.Count();
            textboxXBufferSize.Text = xQueLength.ToString();

            int yQueLength = yData.Count();
            textboxYBufferSize.Text = yQueLength.ToString();

            int zQueLength = zData.Count();
            textboxZBufferSize.Text = zQueLength.ToString();

            textboxAverageX.Text = "0";
            textboxAverageY.Text = "0";
            textboxAverageZ.Text = "0";
        }

        //Form Exit Cleanup
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (gumStick.IsOpen)
            {
                gumStick.Close();
            }
        }
    }
}
