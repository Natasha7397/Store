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
    public partial class ProductForm : Form
    {
        private EditProductForm editProduct;

        public ProductForm()
        {
            InitializeComponent();
            editProduct = new EditProductForm();
           this.CenterToScreen();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            editProduct.ShowDialog();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            editProduct.ShowDialog();
        }
    }
}
