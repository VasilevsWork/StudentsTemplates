using System;
using System.Text;
using System.Net;
using System.Net.Sockets;


namespace ClientSeverExample
{
    class MyServer
    {
        public delegate void ReciveCallback(string message);

        public event ReciveCallback RecivedCallback;


        private int port = 8005; // порт для приема входящих запросов
        private string address = "127.0.0.1"; // адрес сервера
        Socket listenSocket;

        public int Port { get => port; set => port = value; }
        public string Address { get => address; set => address = value; }

        public MyServer()
        {

        }

        public MyServer(string address, int port)
        {
            Port = port;
            Address = address;
        }


        public void Start()
        {
            // получаем адреса для запуска сокета
            IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);

            // создаем сокет
            listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                // связываем сокет с локальной точкой, по которой будем принимать данные
                listenSocket.Bind(ipPoint);

                // начинаем прослушивание
                listenSocket.Listen(2);

                Console.WriteLine("Сервер запущен. Ожидание подключений...");

                while (true)
                {
                    Socket handler = listenSocket.Accept();
                    // получаем сообщение
                    StringBuilder builder = new StringBuilder();
                    int bytes = 0; // количество полученных байтов
                    byte[] data = new byte[256]; // буфер для получаемых данных

                    do
                    {
                        bytes = handler.Receive(data);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    }
                    while (handler.Available > 0);

                    RecivedCallback?.Invoke(DateTime.Now.ToShortTimeString() + ": " + builder.ToString());

                    //// отправляем ответ
                    //string message = "ваше сообщение доставлено";
                    //data = Encoding.Unicode.GetBytes(message);
                    //handler.Send(data);
                    //// закрываем сокет
                    //handler.Shutdown(SocketShutdown.Both);
                    //handler.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Stop()
        {
            listenSocket.Close();
        }


    }
}
