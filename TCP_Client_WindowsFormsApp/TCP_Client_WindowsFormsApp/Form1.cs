using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TCP_Client_WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private delegate void ShowTD(String Str);
        private ShowTD ShowTextDele;
       // private ChatServer CS = new ChatServer();
        private ChatClient CC = new ChatClient();
        public Form1()
        {
            //CS.Start(this);
            CC.setForm(this);
            InitializeComponent();
            ShowTextDele = new ShowTD(ShowText);



        }




        public void ShowText(String str)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(ShowTextDele, str);
                return;
            }
            content.AppendText(str );

            content.SelectionStart = content.Text.Length;
            content.ScrollToCaret();
        }

        private void connect_button_Click(object sender, EventArgs e)
        {
            if(IP_textBox.Text !="" && Port_textBox.Text != "")
            {
                try
                {
                    CC.set_Sock(IP_textBox.Text, int.Parse(Port_textBox.Text));
                }
                catch
                {
                    MessageBox.Show("輸入格式不正確!");
                }
                

                if (CC.get_isOK())
                {
                    try
                    {
                        CC.Start();
                        MessageBox.Show("連線!");
                        connect_button.Enabled = false;
                        IP_textBox.Enabled = false;
                        Port_textBox.Enabled = false;
                    }
                    catch
                    {
                        MessageBox.Show("連線錯誤!");
                        
                    }
                }

            }
        }




    }
}