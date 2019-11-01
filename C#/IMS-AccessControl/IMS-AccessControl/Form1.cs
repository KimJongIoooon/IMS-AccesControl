using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS_AccessControl
{
    public partial class Form1 : Form
    {
        private SerialMessenger serialMessenger;
        private Timer readMessageTimer;

        public Form1()
        {
            InitializeComponent();

            MessageBuilder messageBuilder = new MessageBuilder('#', '%');
            serialMessenger = new SerialMessenger("COM5", 9600, messageBuilder);

            readMessageTimer = new Timer();
            readMessageTimer.Interval = 10;
            readMessageTimer.Tick += new EventHandler(ReadMessageTimer_Tick);
        }

        private void disconnect()
        {
            try
            {
                readMessageTimer.Enabled = false;
                serialMessenger.Disconnect();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialMessenger.Connect();
                lblConnectionStatus.Text = "Status: Connected";
                readMessageTimer.Enabled = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void ReadMessageTimer_Tick(object sender, EventArgs e)
        {
            string[] messages = serialMessenger.ReadMessages();
            if (messages != null)
            {
                foreach (string message in messages)
                {
                    processReceivedMessage(message);
                }
            }
        }
        private void processReceivedMessage(string message)
        {
            richTextBox1.Text += message + Environment.NewLine;
            

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            disconnect();
        }
    }
}
