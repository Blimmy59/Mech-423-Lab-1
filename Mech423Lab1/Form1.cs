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
        ConcurrentQueue<int> xData = new ConcurrentQueue<int>();
        ConcurrentQueue<int> yData = new ConcurrentQueue<int>();
        ConcurrentQueue<int> zData = new ConcurrentQueue<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void comSelectionBox_DropDown(object sender, EventArgs e)
        {
            string[] comPorts = SerialPort.GetPortNames();
            comSelectionBox.DataSource = comPorts;
        }

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (gumStick.IsOpen)
            {
                int bufferSize = gumStick.BytesToRead;
                textboxSerialBufferSize.Text = bufferSize.ToString();

                int queueLength = dataQueue.Count();
                textboxQueueLength.Text = queueLength.ToString();

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
                            dataByteState = 2;
                        }

                        else if (dataByteState == 2)
                        {
                            yData.Enqueue(currentByte);
                            textboxYvalue.Text = currentByte.ToString();
                            dataByteState = 3;
                        }

                        else if (dataByteState == 3)
                        {
                            zData.Enqueue(currentByte);
                            textboxZvalue.Text = currentByte.ToString();
                            dataByteState = 0;
                        }
                    }
                }
            }
        }

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
    }
}
