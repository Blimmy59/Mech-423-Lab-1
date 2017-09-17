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
                string selected = comSelectionBox.SelectedItem.ToString();

                if (gumStick.IsOpen)
                {
                    gumStick.Close();
                    connectDisconnect.Text = "Connect";
                }
                else if (!gumStick.IsOpen)
                {
                    gumStick.PortName = selected;
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
                    textboxQueueSetLength.Text =  "100";
                }
                
                    int queueSetLength = int.Parse(textboxQueueSetLength.Text);
                

                int bufferSize = gumStick.BytesToRead;
                textboxSerialBufferSize.Text = bufferSize.ToString();

                int queueLength = dataQueue.Count();
                textboxQueueLength.Text = queueLength.ToString();

                int xQueLength = xData.Count();
                textboxXBufferSize.Text = xQueLength.ToString();

                int yQueLength = yData.Count();
                textboxYBufferSize.Text = yQueLength.ToString();

                int zQueLength = zData.Count();
                textboxZBufferSize.Text = zQueLength.ToString();

                //Displays the average of accelerometer values stored in xData, yData, and zData
                if ((xData.Count > 0) && (yData.Count > 0) && (yData.Count > 0))
                {
                    textboxAverageX.Text = xData.Average().ToString();
                    textboxAverageY.Text = yData.Average().ToString();
                    textboxAverageZ.Text = zData.Average().ToString();
                }
                //Sorts dataQueue into xData, yData, and zData. Limits these queues to queueSetLength
                int currentByte;
                int dataByteState = 0;
                while (dataQueue.Count > 0)
                {
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

                            if (zData.Count > queueSetLength)
                            {
                                int dump = zData.Dequeue();
                            }

                            dataByteState = 0;
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
                int temp = gumStick.ReadByte();
                dataQueue.Enqueue(temp);
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
        }
    }
}
