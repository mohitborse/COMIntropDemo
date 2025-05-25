using DesktopComServer.COM_Interface;
using System;
using System.Windows.Forms;

namespace DesktopComServer
{
    public partial class Form1 : Form
    {
        private Communication com;

        public Form1()
        {
            InitializeComponent();
            com = new Communication();
        }

        private void SendMessage_Click(object sender, EventArgs e)
        {

            MessageBox.Show(com.SendMessage("Message from Windows application"));
        }



        private void RecievedMessage_Click(object sender, EventArgs e)
        {
            message.Text = com.FetchDesktopUpdates();
        }
    }
}
