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
            }
        }

        private void gumStick_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            
            
            //int bufferSize = gumStick.BytesToRead;

            //for (int i = 0; i < bufferSize; i++)
            //{
            //    int temp = gumStick.ReadByte();
            //    dataQueue.Enqueue(temp);
            //}
        }
    }
}
