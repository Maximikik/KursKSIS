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
    public partial class Form_MainApp : Form
    {
        const string ip = "127.0.0.1";
        const int port = 8080;

        string choose;

        IPEndPoint tcpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);

        Socket tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public Form_MainApp()
        {
            InitializeComponent();
            button_Learn.Width = button_Test.Width = this.Width / 2;
            button_Test.Height = button_Learn.Height = 60;
            button_Learn.Location = new Point(0, 0); 
            button_Test.Location = new Point(this.Width /2 , 0);
            button_leave.Location = new Point(this.Width / 2 - button_leave.Width / 2, this.Height - button_leave.Height - 50);

        }

        private void recieve(string choose)
        {

            var message = choose;
            var data = Encoding.UTF8.GetBytes(message);

            tcpSocket.Send(data);

            var buffer = new byte[512];
            var size = 0;
            var answer = new StringBuilder();

            do
            {
                size = tcpSocket.Receive(buffer);
                answer.Append(Encoding.UTF8.GetString(buffer, 0, size));

            } while (tcpSocket.Available > 0);

            //listBox_Lesons.Items.Add(answer.ToString());
            
            StringBuilder sb = new StringBuilder();

            int count = 0;
            for (int i = 0; i < answer.ToString().Length - 1; i++)
            {
                sb.Append(answer[i]);
                if (i == answer.Length - 2)
                {
                    sb.Append(answer[answer.ToString().Length - 1]);
                }
                count++;
                if (sb.Length == 105 || ((answer[i + 1].ToString() == "1" || answer[i + 1].ToString() == "2" || answer[i + 1].ToString() == "3" || answer[i + 1].ToString() == "4" || answer[i + 1].ToString() == "5") ))
                {
                    //sb.Append(answer[i + 1]);
                    listBox_Lesons.Items.Add(sb.ToString());
                    sb.Clear();
                    count = 0;
                    //i++;
                }
                
            }
           

        }

        private void Form_MainApp_Load(object sender, EventArgs e)
        {
            try
            {
                tcpSocket.Connect(tcpEndPoint);
                //listbox_data.Items.Add("Host data: " + ip + ":" + port.ToString() + "\n" + DateTime.Now + "\nYou just connected");
            }
            catch (Exception ex)
            {
                //listbox_data.Items.Add(ex.Message);
            }
            var message = "Client connected ";
            var data = Encoding.UTF8.GetBytes(message);


            //try
            //{
            //    tcpSocket.Send(data);
            //}
            //catch (Exception ex)
            //{

            //    listbox_data.Items.Add(ex.Message);

            //}
        }

        private void button_Test_Click(object sender, EventArgs e)
        {
            
        }

        private void button_Learn_Click(object sender, EventArgs e)
        {

        }

        private void button_leave_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Lec1_Click(object sender, EventArgs e)
        {
            choose = "1";
            recieve(choose);
        }

        private void button_Lec3_Click(object sender, EventArgs e)
        {
            choose = "2";
            recieve(choose);
        }

        private void button_Lec2_Click(object sender, EventArgs e)
        {
            choose = "3";
            recieve(choose);
        }

        private void listBox_Lesons_DrawItem(object sender, DrawItemEventArgs e)
        {
            //if (listBox_Lesons.Items.Count > 0)
            //{
            //    e.DrawBackground();
            //    e.DrawFocusRectangle();
            //    e.Graphics.DrawString(listBox_Lesons.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
            //}
        }
    }
}
