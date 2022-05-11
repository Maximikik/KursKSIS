using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursKSIS_CLIENT
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            button_Start.Location = new Point(this.Width / 2 - button_leave.Width / 2, this.Height / 2 - 2 * button_leave.Height - 50);
            button_Info.Location = new Point(this.Width / 2 - button_leave.Width / 2, this.Height / 2 - 50);
            button_leave.Location = new Point(this.Width / 2 - button_leave.Width / 2, this.Height / 2 + 2 * button_leave.Height - 50);
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void recieve()
        {
            
            
            //var message = "Client: " + textbox_data.Text;
            //var data = Encoding.UTF8.GetBytes(message);

            //tcpSocket.Send(data);

            //var buffer = new byte[256];
            //var size = 0;
            //var answer = new StringBuilder();

            //do
            //{
            //    size = tcpSocket.Receive(buffer);
            //    answer.Append(Encoding.UTF8.GetString(buffer, 0, size));

            //} while (tcpSocket.Available > 0);


            //listbox_data.Items.Add(answer.ToString());
            //listbox_data.ScrollIntoView(listbox_data.Items[listbox_data.Items.Count - 1]);

        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            Form_MainApp form_MainApp = new Form_MainApp();
            form_MainApp.Show();
            this.Hide();
        }

        private void button_Info_Click(object sender, EventArgs e)
        {
            Form_Info form_Info = new Form_Info();
            form_Info.Show();
            this.Hide();
        }

        private void button_leave_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
