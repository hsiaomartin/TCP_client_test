using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Windows.Forms;
namespace TCP_Client_WindowsFormsApp
{

    //使用者類別
    class User
    {
        //使用者Socket
        public Socket Sock;
        //資料緩衝區
        public Byte[] Data = new Byte[1024];
        //建構子
        public User(Socket s)
        {
            Sock = s;
        }
    }
    //聊天室Client
    class ChatClient
    {
        //與伺服器連線的Socket
        private Socket Sock;
        //資料緩衝區
        private Byte[] Data = new Byte[1024];
        //開始連線
        //做為顯示訊息的視窗
        public static Form1 Frm;
        private string serverIP = "";
        private int serverPort = 0;
        private Boolean isOK = false;

        public void setForm(Form1 F)
        {
            Frm = F;
        }
        public void set_Sock(string IP, int Port)
        {
            serverIP = IP;
            serverPort = Port;
            isOK = true;
        }
        public Boolean get_isOK()
        {
            return isOK;
        }
        public void Start()
        {            
            
            Sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Sock.Connect(serverIP, serverPort);
            //開始接收
            Sock.BeginReceive(Data, 0, 1024, SocketFlags.None, EndRead, null);
        }
        //結束接收
        public void EndRead(IAsyncResult I)
        {
            try
            {
                int len = Sock.EndReceive(I);
                Frm.ShowText("" + Encoding.UTF8.GetString(Data, 0, len));
                Sock.BeginReceive(Data, 0, 1024, SocketFlags.None, EndRead, null);
            }
            catch
            {
                Frm.ShowText("網路訊息>>server disconnected." );
                
            }

        }
        //開始傳送
        public void Send(String msg)
        {
            Byte[] Buffer = Encoding.UTF8.GetBytes(msg);
            try
            {
                Sock.BeginSend(Buffer, 0, Buffer.Length, SocketFlags.None, EndSend, Sock);
            }
            catch {
                Frm.ShowText("網路訊息>>server disconnected.");
            }
        }
        //結束傳送
        private void EndSend(IAsyncResult Result)
        {
            Sock.EndSend(Result);
        }
    }
}