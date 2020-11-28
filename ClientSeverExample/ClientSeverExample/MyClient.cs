using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace ClientSeverExample
{
    class MyClient
    {
        private int port = 8005; // порт для приема входящих запросов
        private string address = "127.0.0.1"; // адрес сервера
        Socket socket;
        public int Port { get => port; set => port = value; }
        public string Address { get => address; set => address = value; }

        public MyClient()
        {

        }

        public MyClient(string address, int port)
        {
            Port = port;
            Address = address;
        }

        public void Start()
        {
            try
            {
                IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse(address), port);

                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                // подключаемся к удаленному хосту
                socket.Connect(ipPoint);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void SendMessage(string message)
        {
            byte[] data = Encoding.Unicode.GetBytes(message);
            socket.Send(data);
        }

        public void ReadMessage()
        {
            // получаем ответ
            byte[] data = new byte[256]; // буфер для ответа
            StringBuilder builder = new StringBuilder();
            int bytes = 0; // количество полученных байт

            do
            {
                bytes = socket.Receive(data, data.Length, 0);
                builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
            }
            while (socket.Available > 0);

            Console.WriteLine("Сообщение сервера: " + builder.ToString());
        }

        public void Stop()
        {
            // закрываем сокет
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }
    }
}
