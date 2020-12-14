using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace Testing_Project
{
    class Facturacion
    {

        public void crearPDFFactura(String usuario, List<String> local, List<String> producto, List<String> costoProducto, String total, String correoUsuario) {
            Document doc = new Document(PageSize.LETTER);
            // Indicamos donde vamos a guardar el documento
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@"C:/Temp/Factura.pdf", FileMode.Create));

            doc.AddTitle("Factura DeliveryCR");

            doc.Open();

            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            // Escribimos el encabezamiento en el documento
            doc.Add(new Paragraph("Factura DeliveryCR, para usuario: "+usuario));
            doc.Add(new Paragraph(SQLTransact.MetPago_Completo));
            doc.Add(new Paragraph(SQLTransact.Dir_Completa));
            doc.Add(Chunk.NEWLINE);

            PdfPTable tblGeneral = new PdfPTable(4);
            tblGeneral.WidthPercentage = 100;

            // Configuramos el título de las columnas de la tabla
            PdfPCell localTitulo = new PdfPCell(new Phrase("Local", _standardFont));
            localTitulo.BorderWidth = 0;
            localTitulo.BorderWidthBottom = 0.75f;

            PdfPCell productoTitulo = new PdfPCell(new Phrase("Producto", _standardFont));
            productoTitulo.BorderWidth = 0;
            productoTitulo.BorderWidthBottom = 0.75f;

            PdfPCell costoTitulo = new PdfPCell(new Phrase("Costo Producto", _standardFont));
            costoTitulo.BorderWidth = 0;
            costoTitulo.BorderWidthBottom = 0.75f;

            PdfPCell totalTitulo = new PdfPCell(new Phrase("Total", _standardFont));
            totalTitulo.BorderWidth = 0;
            totalTitulo.BorderWidthBottom = 0.75f;

            // Añadimos las celdas a la tabla
            tblGeneral.AddCell(localTitulo);
            tblGeneral.AddCell(productoTitulo);
            tblGeneral.AddCell(costoTitulo);
            tblGeneral.AddCell(totalTitulo);

            // Llenamos la tabla con información
            for(int i = 0; i < producto.Count(); i++) {
                localTitulo = new PdfPCell(new Phrase(local.ElementAt(i), _standardFont));
                localTitulo.BorderWidth = 0;
                tblGeneral.AddCell(localTitulo);
            

           
                productoTitulo = new PdfPCell(new Phrase(producto.ElementAt(i), _standardFont));
                productoTitulo.BorderWidth = 0;
                tblGeneral.AddCell(productoTitulo);
            

      
                costoTitulo = new PdfPCell(new Phrase(costoProducto.ElementAt(i), _standardFont));
                costoTitulo.BorderWidth = 0;
                tblGeneral.AddCell(costoTitulo);

                totalTitulo = new PdfPCell(new Phrase(total, _standardFont));
                totalTitulo.BorderWidth = 0;
                tblGeneral.AddCell(totalTitulo);

            }

            doc.Add(tblGeneral);

            doc.Close();
            writer.Close();

            enviarCorreoFactura(correoUsuario);
        }

        public void enviarCorreoFactura(String para) {
            MailMessage Correo = new MailMessage();

            Correo.From = new MailAddress("disenoappsulacit@gmail.com");
            Correo.To.Add(para);
            Correo.Subject = "Factura por compra en DeliveryCR";
            Correo.Body = "Adjuntamos tu factura, gracias por tu compra";
            Correo.IsBodyHtml = false; // Le indicamos que el cuerpo del mensaje no es HTLM
            Correo.Priority = MailPriority.Normal;
           
            Attachment attachment = new Attachment("C:/Temp/Factura.pdf");
            Correo.Attachments.Add(attachment);

            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new NetworkCredential("disenoappsulacit@gmail.com", "ulacit123");

            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;

            try
            {
                smtp.Send(Correo);
                MessageBox.Show("Correo enviado");
            }
            catch
            {
                MessageBox.Show("No se pudo enviar el correo");
            }
            Correo.Dispose();
        }

    }
}
