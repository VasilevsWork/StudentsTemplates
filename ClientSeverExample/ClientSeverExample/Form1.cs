using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;

namespace ClientSeverExample
{
    public partial class Form1 : Form
    {
        public delegate void WriteSomthingDelegate(string message);

        static int port = 8005; // порт для приема входящих запросов
        static string address = "127.0.0.1"; // адрес сервера
        MyServer serv;
        MyClient client;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            serv = new MyServer(address, port);
            serv.RecivedCallback += WriteServerMessage;
            Thread thread1 = new Thread(serv.Start);
            thread1.Start();
        }

        private void btn_startClient_Click(object sender, EventArgs e)
        {
            client = new MyClient(address, port);
            Thread thread1 = new Thread(client.Start);
            thread1.Start();
        }



        private void WriteServerMessage(string message)
        {
            if (InvokeRequired)
            {
                WriteSomthingDelegate e = new WriteSomthingDelegate(WriteServerMessage);
                BeginInvoke(e, new object[] { message });
            }
            else
            {
                listBox1.Items.Add(message);
            }
        }

        private void WriteClientMessage(string message)
        {
            if (InvokeRequired)
            {
                WriteSomthingDelegate e = new WriteSomthingDelegate(WriteClientMessage);
                BeginInvoke(e, new object[] { message });
            }
            else
            {
                listBox2.Items.Add(message);
            }
        }

        private void btn_sendToServer_Click(object sender, EventArgs e)
        {
            client.SendMessage(textBox1.Text);
        }
    }
}
