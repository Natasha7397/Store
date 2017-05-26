using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
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
            Hide();
            MainForm mainForm = new MainForm();
            mainForm.StartPosition = FormStartPosition.CenterScreen;
            mainForm.ShowDialog();
           
            PasswordText.Clear();
            LoginText.Clear();
            
            
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
