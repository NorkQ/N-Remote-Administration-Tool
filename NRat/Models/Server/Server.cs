using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using NRat;
using System.Windows.Forms;

namespace NRat.Models.Server
{
    public class Server
    {
        private static readonly Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private static readonly List<Socket> clientSockets = new List<Socket>();
        private const int BUFFER_SIZE = 2048;
        private const int PORT = 100;
        private static readonly byte[] buffer = new byte[BUFFER_SIZE];
        static MainWindow mainWindow;

        public Server() { }

        public Server(MainWindow main)
        {
            mainWindow = main;
            SetupServer();
        }

        public void SetupServer()
        {
            mainWindow.WriteConsole("Server başlatılıyor...");
            serverSocket.Bind(new IPEndPoint(IPAddress.Any, PORT));
            serverSocket.Listen(0);
            Thread beginAcceptThread = new Thread(() => serverSocket.BeginAccept(AcceptCallback, null));
            beginAcceptThread.Start();
            //serverSocket.BeginAccept(AcceptCallback, null);
            mainWindow.WriteConsole("Server başlatıldı.");
        }

        /// <summary>
        /// Close all connected client (we do not need to shutdown the server socket as its connections
        /// are already closed with the clients).
        /// </summary>
        private static void CloseAllSockets()
        {
            foreach (Socket socket in clientSockets)
            {
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }

            serverSocket.Close();
        }

        private static void AcceptCallback(IAsyncResult AR)
        {
            Socket socket;

            try
            {
                socket = serverSocket.EndAccept(AR);
            }
            catch (ObjectDisposedException) // I cannot seem to avoid this (on exit when properly closing sockets)
            {
                return;
            }

            clientSockets.Add(socket);
            Thread beginReceiveThread = new Thread(() => socket.BeginReceive(buffer, 0, BUFFER_SIZE, SocketFlags.None, ReceiveCallback, socket));
            beginReceiveThread.Start();
            //socket.BeginReceive(buffer, 0, BUFFER_SIZE, SocketFlags.None, ReceiveCallback, socket);
            mainWindow.WriteConsole("İstemci bağlandı, istekler için bekleniyor...");
            serverSocket.BeginAccept(AcceptCallback, null);
        }

        private static void ReceiveCallback(IAsyncResult AR)
        {
            Socket current = (Socket)AR.AsyncState;
            int received;

            try
            {
                received = current.EndReceive(AR);
            }
            catch (SocketException)
            {
                mainWindow.WriteConsole("Client forcefully disconnected");
                // Don't shutdown because the socket may be disposed and its disconnected anyway.
                current.Close();
                clientSockets.Remove(current);
                return;
            }

            byte[] recBuf = new byte[received];
            Array.Copy(buffer, recBuf, received);
            string text = Encoding.ASCII.GetString(recBuf);
            mainWindow.WriteConsole("Received Text: " + text);

            if (text.ToLower() == "get time") // Client requested time
            {
                mainWindow.WriteConsole("Text is a get time request");
                byte[] data = Encoding.ASCII.GetBytes(DateTime.Now.ToLongTimeString());
                current.Send(data);
                mainWindow.WriteConsole("Time sent to client");
            }
            else if (text.ToLower() == "exit") // Client wants to exit gracefully
            {
                // Always Shutdown before closing
                current.Shutdown(SocketShutdown.Both);
                current.Close();
                clientSockets.Remove(current);
                mainWindow.WriteConsole("Client disconnected");
                return;
            }
            else
            {
                mainWindow.WriteConsole("Text is an invalid request");
                byte[] data = Encoding.ASCII.GetBytes("Invalid request");
                current.Send(data);
                mainWindow.WriteConsole("Warning Sent");
            }

            current.BeginReceive(buffer, 0, BUFFER_SIZE, SocketFlags.None, ReceiveCallback, current);
        }
    }
}
