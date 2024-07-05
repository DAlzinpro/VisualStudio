using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;

namespace KeyAuth
{
    public partial class Main : Form
    {
		/*
        * 
        * WATCH THIS VIDEO TO SETUP APPLICATION: https://www.youtube.com/watch?v=RfDTdiBq4_o
        * 
	     * READ HERE TO LEARN ABOUT KEYAUTH FUNCTIONS https://github.com/KeyAuth/KeyAuth-CSHARP-Example#keyauthapp-instance-definition
		 *
        */
        public Main()
        {
            InitializeComponent();
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        string chatchannel = "test"; // chat channel name

        private void Main_Load(object sender, EventArgs e)
        {
            userDataField.Items.Add($"Username: {Login.KeyAuthApp.user_data.username}");
            userDataField.Items.Add($"Expires: {UnixTimeToDateTime(long.Parse(Login.KeyAuthApp.user_data.subscriptions[0].expiry))}");
            userDataField.Items.Add($"Subscription: {Login.KeyAuthApp.user_data.subscriptions[0].subscription}");
            userDataField.Items.Add($"IP: {Login.KeyAuthApp.user_data.ip}");
            userDataField.Items.Add($"HWID: {Login.KeyAuthApp.user_data.hwid}");
            userDataField.Items.Add($"Creation Date: {UnixTimeToDateTime(long.Parse(Login.KeyAuthApp.user_data.createdate))}");
            userDataField.Items.Add($"Last Login: {UnixTimeToDateTime(long.Parse(Login.KeyAuthApp.user_data.lastlogin))}");
            userDataField.Items.Add($"Time Left: {expirydaysleft()}");

            var onlineUsers = Login.KeyAuthApp.fetchOnline();
            if (onlineUsers != null)
            {
                Console.Write("\n Online users: ");
                foreach (var user in onlineUsers)
                {
                    
                }
                Console.WriteLine("\n");
            }
        }

        public static bool SubExist(string name, int len)
        {
            for (var i = 0; i < len; i++)
            {
                if (Login.KeyAuthApp.user_data.subscriptions[i].subscription == name)
                {
                    return true;
                }
            }
            return false;
        }
        public string expirydaysleft()
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            dtDateTime = dtDateTime.AddSeconds(long.Parse(Login.KeyAuthApp.user_data.subscriptions[0].expiry)).ToLocalTime();
            TimeSpan difference = dtDateTime - DateTime.Now;
            return Convert.ToString(difference.Days + " Days " + difference.Hours + " Hours Left");
        }

        public DateTime UnixTimeToDateTime(long unixtime)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            try
            {
                dtDateTime = dtDateTime.AddSeconds(unixtime).ToLocalTime();
            }
            catch
            {
                dtDateTime = DateTime.MaxValue;
            }
            return dtDateTime;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            timer1.Interval = 15000; // get chat messages every 15 seconds
            if (!String.IsNullOrEmpty(chatchannel))
            {
                var messages = Login.KeyAuthApp.chatget(chatchannel);
                if (messages == null)
                {
                    
                }
                else
                {
                    foreach (var message in messages)
                    {
                        
                    }
                }
            }
            else
            {
                timer1.Stop();
                
            }
        }

        

       

        private void setUserVarBtn_Click(object sender, EventArgs e)
        {
            
            guna2MessageDialog1.Show(Login.KeyAuthApp.response.message);
        }

        private void fetchUserVarBtn_Click(object sender, EventArgs e)
        {
            guna2MessageDialog1.Show(Login.KeyAuthApp.response.message);
        }

        

        private void checkSessionBtn_Click(object sender, EventArgs e)
        {
            Login.KeyAuthApp.check();
            guna2MessageDialog1.Show(Login.KeyAuthApp.response.message);
        }

        private void sendWebhookBtn_Click(object sender, EventArgs e)
        {
            guna2MessageDialog1.Show(Login.KeyAuthApp.response.message);
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            guna2MessageDialog1.Show(Login.KeyAuthApp.response.message);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            siticonePanel2.Visible = false;
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            siticonePanel2.Visible = true;

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            siticonePanel2.Visible = false;

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            siticonePanel2.Visible = true;

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Configura��es do OpenFileDialog
            openFileDialog1.Title = "Selecionar Arquivo";
            openFileDialog1.Filter = "Arquivos de Texto|*.txt|Todos os Arquivos|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            // Exibe o seletor de arquivos para o usu�rio selecionar um arquivo
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // O usu�rio selecionou um arquivo
                string nomeArquivo = openFileDialog1.FileName;

                // Aqui voc� pode trabalhar com o nome do arquivo selecionado, por exemplo:
                // exibir na interface gr�fica, carregar o conte�do do arquivo, etc.
                MessageBox.Show($"Arquivo selecionado: {nomeArquivo}");

                siticoneHtmlLabel1.Text = System.IO.Path.GetFileName(nomeArquivo);
            }
        }
    }
}