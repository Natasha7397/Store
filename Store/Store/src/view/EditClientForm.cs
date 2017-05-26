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
    public partial class EditClientForm : Form
    {

        public Models.Businessentity bsToShow;

        public EditClientForm()
        {
            InitializeComponent();
            this.CenterToScreen();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (trySendRequest())
            {
                Close();
            }
        }

        private void EditClientForm_Load(object sender, EventArgs e)
        {
            if(bsToShow != null)
            {
                INNText.Text = bsToShow.inn.ToString();
                PhoneText.Text = bsToShow.phone;
                NameText.Text = bsToShow.name;
                EmailText.Text = bsToShow.email;
                ScoreText.Text = bsToShow.giro.ToString();
                AddressText.Text = bsToShow.address;
            }
        }

        private bool trySendRequest()
        {
            try
            {
                if (!fieldsAreValid())
                {
                    MessageBox.Show("Ключевые поля не были заполнены (ИНН, Расчетный счет, адрес)", "Ошибка!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    return false;
                }
                Models.Businessentity newBs = new Models.Businessentity();
                newBs.inn = Convert.ToInt32(INNText.Text);
                newBs.phone = PhoneText.Text;
                newBs.name = NameText.Text;
                newBs.email = EmailText.Text;
                newBs.giro = Convert.ToInt32(ScoreText.Text);
                newBs.address = AddressText.Text;
                Reciever reciever = Reciever.Instance;
                return reciever.sendData<Models.Businessentity>(newBs, "businessEntity");
            } catch (FormatException e)
            {
                MessageBox.Show("Неверный формат введенных данных", "Ошибка!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            } catch (Exception e)
            {
                MessageBox.Show("Неизвестная ошибка: " + e.Message, "Ошибка!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            return false;
        }

        private void EditClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            NameText.Clear();
            PhoneText.Clear();
            EmailText.Clear();
            INNText.Clear();
            ScoreText.Clear();
            AddressText.Clear();
            bsToShow = null;
        }

        private bool fieldsAreValid()
        {
            return INNText.Text.Length != 0 &&
                ScoreText.Text.Length != 0 &&
                NameText.Text.Length != 0;
        }
    }
}
