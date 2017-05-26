using Store.src.control;
using Store.src.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            ConnectionParams.IpAddress = "127.0.0.1";
            ConnectionParams.Port = "8080";
            InitializeComponent();
            this.CenterToScreen();

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            string password = PasswordText.Text;
            string username = LoginText.Text;
            try
            {
                Reciever requester = Reciever.Instance;
                if(requester.authenticate(username, password))
                {
                    Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.StartPosition = FormStartPosition.CenterScreen;
                    mainForm.ShowDialog();

                    PasswordText.Clear();
                    LoginText.Clear();
                } else
                {
                    var result = MessageBox.Show("Вы ввели неверный логин или пароль",
                                 "Ошибка!",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                }
            } catch (WebException ex)
            {
                var result = MessageBox.Show("Ошибка подключения:" + ex.Message,
                                 "Ошибка!",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            } catch (Exception ex)
            {
                var result = MessageBox.Show("Возникла ошибка:" + ex.Message,
                                 "Ошибка!",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            } 
            
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {

        }

        private void параметрыПодключенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectionSettings connetcion = new ConnectionSettings();
            connetcion.StartPosition = FormStartPosition.CenterScreen;
            connetcion.ShowDialog();
        }
    }
}
