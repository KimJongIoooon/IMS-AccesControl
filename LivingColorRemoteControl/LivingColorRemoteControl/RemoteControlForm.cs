using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivingColorRemoteControl
{
    public partial class RemoteControlForm : Form
    {
        private SerialMessenger serialMessenger;
        private Timer readMessageTimer;
          
        public RemoteControlForm()
        {
            InitializeComponent();
            updatePcColorPanel();

            MessageBuilder messageBuilder = new MessageBuilder('#', '%');
            serialMessenger = new SerialMessenger("COM5", 115200, messageBuilder);

            readMessageTimer = new Timer();
            readMessageTimer.Interval = 10;
            readMessageTimer.Tick += new EventHandler(ReadMessageTimer_Tick);
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            try
            {
                serialMessenger.Connect();
                whoIsInControlLabel.Text = "Arduino";
                readMessageTimer.Enabled = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void disconnecButton_Click(object sender, EventArgs e)
        {
            disconnect();
            whoIsInControlLabel.Text = "-";
        }

        private void controlFromPCButton_Click(object sender, EventArgs e)
        {
            if (serialMessenger.SendMessage("REMOTE_CONTROL"))
            {
                whoIsInControlLabel.Text = "PC";
            }
        }

        private void redSlider_Scroll(object sender, EventArgs e)
        {
            serialMessenger.SendMessage("SET_RED:" + redSlider.Value);
            redTextBox.Text = redSlider.Value.ToString();
            updatePcColorPanel();
        }

        private void greenSlider_Scroll(object sender, EventArgs e)
        {
            serialMessenger.SendMessage("SET_GREEN:" + greenSlider.Value);
            greenTextBox.Text = greenSlider.Value.ToString();
            updatePcColorPanel();
        }

        private void blueSlider_Scroll(object sender, EventArgs e)
        {
            serialMessenger.SendMessage("SET_BLUE:" + blueSlider.Value);
            blueTextBox.Text = blueSlider.Value.ToString();
            updatePcColorPanel();
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

        /// <summary>
        /// handle received messages
        /// </summary>
        /// <param name="message"></param>
        private void processReceivedMessage(string message)
        {
            if (message.Contains("STATUS"))
            {
                tbxNaamArduino.Text = "";
            }

            if (message == "ARDUINO_CONTROL")
            {
                whoIsInControlLabel.Text = "Arduino";
            }
            else if (message.StartsWith("RED_STATUS:"))
            {
                int value = getParamValue(message);
                arduinoRedTextBox.Text = value.ToString();
                arduinoColorPanel.BackColor = Color.FromArgb(value, arduinoColorPanel.BackColor.G, arduinoColorPanel.BackColor.B);
            }
            else if (message.StartsWith("GREEN_STATUS:"))
            {
                int value = getParamValue(message);
                arduinoGreenTextBox.Text = value.ToString();
                arduinoColorPanel.BackColor = Color.FromArgb(arduinoColorPanel.BackColor.R, value, arduinoColorPanel.BackColor.B);
            }
            else if (message.StartsWith("BLUE_STATUS:"))
            {
                int value = getParamValue(message);
                arduinoBlueTextBox.Text = value.ToString();
                arduinoColorPanel.BackColor = Color.FromArgb(arduinoColorPanel.BackColor.R, arduinoColorPanel.BackColor.G, value);
            }
            else if (message.StartsWith("PRESET_NAME:"))
            {
                string value = getParamValueStr(message);
                tbxNaamArduino.Text = value.ToString();
            }
        }

        private int getParamValue(string message)
        {
            int colonIndex = message.IndexOf(':');
            if (colonIndex != -1)
            {
                string param = message.Substring(colonIndex + 1);
                int value;
                bool done = int.TryParse(param, out value);
                if (done)
                {
                    return value;
                }
            }
            throw new ArgumentException("message contains no value parameter");
        }
        private string getParamValueStr(string message)
        {
            int colonIndex = message.IndexOf(':');
            if (colonIndex != -1)
            {
                string value = message.Substring(colonIndex + 1);
                return value;
            }
            throw new ArgumentException("message contains no value parameter");
        }

        private void RemoteControlForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            disconnect();
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

        private void updatePcColorPanel()
        {
            pcColorPanel.BackColor = Color.FromArgb(redSlider.Value, greenSlider.Value, blueSlider.Value);
        }

        private void updateArduinoColorPanel()
        {
            pcColorPanel.BackColor = Color.FromArgb(redSlider.Value, greenSlider.Value, blueSlider.Value);
        }

        private void btnAddPreset_Click(object sender, EventArgs e)
        {
            //ADD_PRESET:<naam>,R :<redValue>,G:<greenValue>,B:<blueValue>"
            serialMessenger.SendMessage($"ADD_PRESET:{tbxNaamPc.Text},R:{redSlider.Value},G:{greenSlider.Value},B:{blueSlider.Value}");
    
        }


    }
}
