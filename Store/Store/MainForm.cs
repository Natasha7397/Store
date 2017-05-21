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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            productForm = new ProductForm();
            purveyorForm = new PurveyorForm();
            clientForm = new ClientForm();
             chartForm = new ChartForm();
             AForm = new AuthorizationForm();
            userForm = new UserForm();
           
        }
        ProductForm productForm;
        PurveyorForm purveyorForm;
        ClientForm clientForm;
        ChartForm chartForm;
        AuthorizationForm AForm;
        UserForm userForm;
       
        private void документыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void главнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productForm.ShowDialog();
        }

        private void PurveyorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            purveyorForm.ShowDialog();
        }

        private void ClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientForm.ShowDialog();
        }

        private void графикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chartForm.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void добавитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userForm.ShowDialog();
        }

        private void сменитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AForm.ShowDialog();
        }
    }
}
