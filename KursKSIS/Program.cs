using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace KursKSIS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string ip = "127.0.0.1";
            const int port = 8080;

            var tcpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);

            var tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            string lection1 = "Следует различать гласные а и о в корнях зар- и зор-, рас(т)- и рос(т)-, равн- и ровн-, гар- и гор-, плав- и плов-: " +
                "1) зар - пишется в словах заря, зарница, озарять(под ударением — за́рево, лучеза́рный) и во всех образованных от них словах(озарение и др.);" +
                "зор - пишется под ударением в отдельных словах и формах: зо́рька, зо́ренька, зо́рюшка, зо́ри, зорь, зо́рю(бить, играть зорю)." +
                "2) рас(т) - пишется в глаголах расти, растить, вырастать, наращать и т.п.и во всех образованных от них словах, например: растение, произрастание, " +
                "ращение, сращение, возраст и т.п., а также в слове отрасль;" +
                "рос(т) - пишется в прошедшем времени и в причастии прошедшего времени от расти, например: рос, росла, росло, росший, вырос, выросший и т.п.," +
                " а также в словах заросль, поросль, водоросль, недоросль, росток и в образованных от них словах." +
                "3) равн - пишется преимущественно в словах, которые связываются по значению с равный(«одинаковый»), например: равномерный, равнозначный, сравнить, " +
                "равнение, равнять(ся), поравняться, всё равно;" +
                "ровн - пишется преимущественно в словах, связанных по значению с ровный(«гладкий», «прямой»), например: ровнять, сровнять и т.п., уровень;" +
                "в слове равнина пишется а.4) гар - пишется под ударением, например: зага́р, нага́р, а также в словах и́згарь, вы́гарки; " +
                "гор - пишется в остальных случаях, например: загорелый, нагореть.5) плав - пишется во всех случаях, кроме слов пловец, пловчиха, плывуны." +
                "Чередование а и о находим также в глаголах";

            string[] lection2 = new string[2];

            lection2[0] = "Следует различать гласные а и о в корнях зар- и зор-, рас(т)- и рос(т)-, равн- и ровн-,";
            lection2[1] = "гар - и гор -, плав - и плов -:";
            //lection2[2] = 
            //lection2[3] = 
            //lection2[4] = 
            //lection2[5] = 
            //lection2[6] = 
            //lection2[7] = 
            //lection2[8] =
            //lection2[9] = 

            try
            {
                tcpSocket.Bind(tcpEndPoint);

                tcpSocket.Listen(5);

                Console.WriteLine("Сервер запущен. Ожидание подключений...");
                Console.WriteLine("IP адрес - 127.0.0.1, порт - " + port.ToString());
                var listener = tcpSocket.Accept();

                while (true)
                {

                    var buffer = new byte[512];
                    var size = 0;
                    var data = new StringBuilder();

                    do
                    {
                        size = listener.Receive(buffer);
                        data.Append(Encoding.UTF8.GetString(buffer, 0, size));

                    } while (listener.Available > 0);



                    Console.WriteLine(data);

                    if (data.ToString() == "1")
                    {
                        listener.Send(Encoding.UTF8.GetBytes(lection1));

                    }



                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
            }


        }
    }
}
