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

        BindingList<Employee> Employees = new BindingList<Employee>();
        public Form1()
        {
            InitializeComponent();

            MessageBuilder messageBuilder = new MessageBuilder('#', '%');
            serialMessenger = new SerialMessenger("COM3", 9600, messageBuilder);

            readMessageTimer = new Timer();
            readMessageTimer.Interval = 10;
            readMessageTimer.Tick += new EventHandler(ReadMessageTimer_Tick);

            Employees.Add(new Employee("iain", "12341234", 1000, 1700));
            Employees.Add(new Employee("Stijn", "AA123412", 1000, 1700));
            listBox1.DataSource = Employees;
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

            if (message.StartsWith("Userlogin"))
            {
                int indexStart = message.IndexOf(':') +1;
                string pasNr = message.Substring(indexStart);
                MessageBox.Show(pasNr);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            disconnect();
        }

        private void BtnAddCard_Click(object sender, EventArgs e)
        {
            Employees.Add(new Employee(tbxName.Text, tbxCardID.Text, Convert.ToInt32(nudStartTime.Value), Convert.ToInt32(nudEndTime.Value)));
            
        }

        private void BtnSync_Click(object sender, EventArgs e)
        {
            lblConnectionStatus.Text = "Status: Syncing";
            foreach(Employee employee in Employees)
            {
                string deleteMessage = $"#DELETE_CARD:{employee.pasId},{employee.StartHour}{employee.EndHour}%";
                serialMessenger.SendMessage(deleteMessage);
                System.Threading.Thread.Sleep(800);
                string addMessage = $"#ADD_CARD:{employee.pasId},{employee.StartHour}{employee.EndHour}%";
                serialMessenger.SendMessage(addMessage);
                System.Threading.Thread.Sleep(800);

            }

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee selectedItem = (Employee)listBox1.SelectedItem;
            tbxName.Text = selectedItem.name;
            tbxCardID.Text = selectedItem.pasId;
            nudEndTime.Value = Convert.ToInt32(selectedItem.EndHour);
            nudStartTime.Value = Convert.ToInt32(selectedItem.StartHour);
        }
    }
}
