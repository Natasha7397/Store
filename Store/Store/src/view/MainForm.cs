using Store.src.control;
using Store.src.model;
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
            this.CenterToScreen();
            productForm = new ProductForm();
            purveyorForm = new PurveyorForm();
            clientForm = new ClientForm();
             chartForm = new ChartForm();
             AForm = new AuthorizationForm();
            userForm = new UserForm();
            document = new Documents();
        }
        ProductForm productForm;
        PurveyorForm purveyorForm;
        ClientForm clientForm;
        ChartForm chartForm;
        AuthorizationForm AForm;
        UserForm userForm;
        Documents document;
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
            Application.Exit();
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            updateData();
        }

        private void отправитьНаПочтуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mail mail = new Mail();
            mail.ShowDialog();
        }

        private void отправитьНаПочтуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Mail mail = new Mail();
            mail.ShowDialog();
        }

        private void сформироватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            document.Invoice();
        }

        private void сформироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            document.packingList();
        }

        private void AuthorizationLabel_Click(object sender, EventArgs e)
        {

        }

        public void updateData()
        {
            Reciever reciever = Reciever.Instance;
            availableProductsDataGrid.DataSource = null;
            availableProductsDataGrid.DataSource = reciever.recieveData<Models.Product>("product", "getAll");
        }
    }
}
