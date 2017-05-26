using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Mail;
using System.Net;
using System.Net.Mime;

namespace Store
{
    public partial class Mail : Form
    {
        public Mail()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        
   
        private void SendButton_Click(object sender, EventArgs e)
        {
            SmtpClient Smtp = new SmtpClient("smtp.yandex.ru", 587);
            Smtp.Credentials = new NetworkCredential("natufochka@yandex.ru", "17091997nata");
            Smtp.EnableSsl = true;
            MailMessage Message = new MailMessage();
            Message.From = new MailAddress("natufochka@yandex.ru");//от кого
            Message.To.Add(new MailAddress(MailText.Text));//кому
            Message.Subject = "Проверка связи";//тема
            Message.Body = "Привет от Наташи)";//текст письма
            string file = "D:\\Packing list.pdf";
            Attachment attach = new Attachment(file,
            MediaTypeNames.Application.Octet);
            Message.Attachments.Add(attach);
            Smtp.Send(Message);
        }
    }
}
