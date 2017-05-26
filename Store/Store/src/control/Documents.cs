using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
   public class Documents
    {
        public void Invoice()
        {
            var doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(@"D:\Счет на оплату.pdf", FileMode.OpenOrCreate));
            doc.Open();

            string fg = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Fradm.TTF");
            BaseFont baseFont = BaseFont.CreateFont(fg, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

            ArrayList list = new ArrayList();
            list.Add("Поставщик");
            list.Add("Юр. адрес");
            iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.NORMAL);
            PdfPTable table = new PdfPTable(1);
            PdfPCell cell = new PdfPCell();
            for (int k = 0; k < list.Count; k++)
            {
                cell = new PdfPCell(new Phrase(list[k].ToString(), font));
                cell.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                cell.BorderWidth = 1;
                cell.Colspan = 15;
                table.AddCell(cell);
            }
            doc.Add(table);

            iTextSharp.text.Phrase j = new Phrase(" ", font);
            Paragraph a = new Paragraph(j);
            a.SpacingAfter = 20;
            doc.Add(a);

            list.Clear();
            list.Add("ИНН");
            list.Add("КПП");
            list.Add("Счет № ");
            list.Add("Получатель");
            list.Add("Банк получателя");
            list.Add("БИК");
            list.Add("Счет № ");
            PdfPTable table2 = new PdfPTable(3);

            cell = new PdfPCell(new Phrase(list[0].ToString(), font));
            cell.BorderWidth = 1;
            cell.Colspan = 1;
            table2.AddCell(cell);

            cell = new PdfPCell(new Phrase(list[1].ToString(), font));
            cell.BorderWidth = 1;
            cell.Colspan = 1;
            table2.AddCell(cell);

            cell = new PdfPCell(new Phrase(list[2].ToString(), font));
            cell.BorderWidth = 1;
            cell.PaddingBottom = 15;
            cell.Colspan = 2;
            cell.Rowspan = 4;
            table2.AddCell(cell);

            cell = new PdfPCell(new Phrase(list[3].ToString(), font));
            cell.BorderWidth = 1;
            cell.Colspan = 2;
            cell.Rowspan = 3;
            table2.AddCell(cell);

            cell = new PdfPCell(new Phrase(list[4].ToString(), font));
            cell.BorderWidth = 1;
            cell.Colspan = 2;
            cell.Rowspan = 2;
            table2.AddCell(cell);

            cell = new PdfPCell(new Phrase(list[5].ToString(), font));
            cell.BorderWidth = 1;
            cell.PaddingTop = 5;
            cell.Colspan = 2;
            table2.AddCell(cell);

            cell = new PdfPCell(new Phrase(list[6].ToString(), font));
            cell.BorderWidth = 1;
            cell.PaddingBottom = 5;
            cell.Colspan = 2;
            table2.AddCell(cell);
            doc.Add(table2);

            Random rnd = new Random();
            string curDate = DateTime.Now.ToLongDateString();
            iTextSharp.text.Phrase j1 = new Phrase("Счет № " + rnd.Next(1, 300) + " от " + curDate, new iTextSharp.text.Font(baseFont, 24, iTextSharp.text.Font.BOLD, new BaseColor(Color.Black)));
            Paragraph a1 = new Paragraph(j1);
            a1.Alignment = Element.ALIGN_CENTER;
            a1.SpacingAfter = 5;
            doc.Add(a1);

            iTextSharp.text.Phrase j2 = new Phrase("Плательщик      ", new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black)));
            Paragraph a2 = new Paragraph(j2);
            a2.Alignment = Element.ALIGN_LEFT;
            a2.SpacingAfter = 5;
            doc.Add(a2);

            iTextSharp.text.Phrase j3 = new Phrase("Грузополучатель ", new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black)));
            Paragraph a3 = new Paragraph(j3);
            a3.Alignment = Element.ALIGN_LEFT;
            a3.SpacingAfter = 15;
            doc.Add(a3);


            PdfPTable table3 = new PdfPTable(6);
            list.Clear();
            list.Add("№");
            list.Add("Товар");
            list.Add("Единица");
            list.Add("Количество");
            list.Add("Цена");
            list.Add("Сумма");
            for (int k = 0; k < list.Count; k++)
            {
                cell = new PdfPCell(new Phrase(list[k].ToString(), font));
                cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                cell.BorderWidth = 1;
                table3.AddCell(cell);
            }

            for (int i = 0; i < 20; i++)
            {
                for (int k = 0; k < 6; k++)
                {

                    table3.AddCell(" ");
                }
            }

            doc.Add(table3);

            iTextSharp.text.Phrase j4 = new Phrase("Итого ".PadLeft(120) + rnd.Next(1, 300), new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black)));
            Paragraph a4 = new Paragraph(j4);
            a4.Alignment = Element.ALIGN_CENTER;
            a4.SpacingAfter = 20;
            doc.Add(a4);

            iTextSharp.text.Phrase j5 = new Phrase("Всего на оплату " + rnd.Next(1, 300) + ", на сумму " + rnd.Next(1, 300), new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.UNDERLINE, new BaseColor(Color.Black)));
            Paragraph a5 = new Paragraph(j5);
            a5.Alignment = Element.ALIGN_LEFT;
            a5.SpacingAfter = 15;
            doc.Add(a5);

            iTextSharp.text.Phrase j6 = new Phrase("Главный директор  _________________________ (_________________________________) ", new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black)));
            Paragraph a6 = new Paragraph(j6);
            a6.Alignment = Element.ALIGN_LEFT;
            a6.SpacingAfter = 15;
            doc.Add(a6);

            iTextSharp.text.Phrase j7 = new Phrase("Главный бухгалтер _________________________ (_________________________________) ", new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black)));
            Paragraph a7 = new Paragraph(j7);
            a7.Alignment = Element.ALIGN_LEFT;
            a7.SpacingAfter = 15;
            doc.Add(a7);

            doc.Close();
        }
        public void packingList()
        {
            var doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(@"D:\Товарная накладная.pdf", FileMode.OpenOrCreate));
            doc.Open();

            string fg = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Fradm.TTF");
            BaseFont baseFont = BaseFont.CreateFont(fg, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Phrase j1 = new Phrase("Организация: ООО \"Фирма\"", new iTextSharp.text.Font(baseFont, 16, iTextSharp.text.Font.UNDERLINE, new BaseColor(Color.Black)));
            Paragraph a1 = new Paragraph(j1);
            a1.Alignment = Element.ALIGN_CENTER;
            a1.SpacingAfter = 5;
            doc.Add(a1);

            string curDate;
            iTextSharp.text.Phrase j2 = new Phrase(curDate = DateTime.Now.ToLongDateString(), new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.BOLD, new BaseColor(Color.Black)));
            Paragraph a2 = new Paragraph(j2);
            a2.Alignment = Element.ALIGN_RIGHT;
            a2.SpacingAfter = 5;
            doc.Add(a2);

            Random rnd = new Random();
            iTextSharp.text.Phrase j3 = new Phrase("Накладная № " + rnd.Next(1, 300), new iTextSharp.text.Font(baseFont, 24, iTextSharp.text.Font.BOLD, new BaseColor(Color.Black)));
            Paragraph a3 = new Paragraph(j3);
            a3.Alignment = Element.ALIGN_CENTER;
            a3.SpacingAfter = 5;
            doc.Add(a3);

            iTextSharp.text.Phrase j4 = new Phrase("От кого   ", new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black)));
            Paragraph a4 = new Paragraph(j4);
            a4.Alignment = Element.ALIGN_LEFT;
            a4.SpacingAfter = 5;
            doc.Add(a4);

            iTextSharp.text.Phrase j5 = new Phrase("Кому      ", new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black)));
            Paragraph a5 = new Paragraph(j5);
            a5.Alignment = Element.ALIGN_LEFT;
            a5.SpacingAfter = 5;
            doc.Add(a5);

            iTextSharp.text.Phrase j6 = new Phrase("Основание ", new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black)));
            Paragraph a6 = new Paragraph(j6);
            a6.Alignment = Element.ALIGN_LEFT;
            a6.SpacingAfter = 20;
            doc.Add(a6);

            iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.NORMAL);
            PdfPTable table = new PdfPTable(6);
            PdfPCell cell = new PdfPCell();
            ArrayList list = new ArrayList();
            list.Add("№");
            list.Add("Товар");
            list.Add("Единица");
            list.Add("Количество");
            list.Add("Цена");
            list.Add("Сумма");
            for (int k = 0; k < list.Count; k++)
            {
                cell = new PdfPCell(new Phrase(list[k].ToString(), font));
                cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                cell.BorderWidth = 1;
                table.AddCell(cell);
            }

            for (int j = 0; j < 20; j++)
            {
                for (int k = 0; k < 6; k++)
                {

                    table.AddCell(" ");
                }
            }

            doc.Add(table);

            iTextSharp.text.Phrase j0 = new Phrase("Итого ".PadLeft(120) + rnd.Next(1, 300), new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black)));
            Paragraph a = new Paragraph(j0);
            a.Alignment = Element.ALIGN_CENTER;
            doc.Add(a);

            iTextSharp.text.Phrase j7 = new Phrase("Сдал   ___________________", new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black)));
            Paragraph a7 = new Paragraph(j7);
            a7.Alignment = Element.ALIGN_CENTER;
            a7.SpacingAfter = 10;
            doc.Add(a7);

            iTextSharp.text.Phrase j8 = new Phrase("Принял ___________________", new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black)));
            Paragraph a8 = new Paragraph(j8);
            a8.Alignment = Element.ALIGN_CENTER;
            a8.SpacingAfter = 10;
            doc.Add(a8);

            doc.Close();
        }
    }
}
