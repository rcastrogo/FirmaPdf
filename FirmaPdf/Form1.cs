using System;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace FirmaPdf
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnAbrirPdf_Click(object sender, EventArgs e){
      using (OpenFileDialog dialog = new OpenFileDialog()){
        dialog.CheckFileExists = true;
        dialog.Filter = "archivos pdf (*.pdf)|*.pdf|Todos los ficheros (*.*)|*.*";
        dialog.FilterIndex = 0;
        DialogResult result = dialog.ShowDialog(this);       
        if( result == DialogResult.OK && dialog.FileName != ""){
          txtPdf.Text = dialog.FileName;
          return;
        }
        txtPdf.Text = "";
      };
    }

    private void btnAbrirFirma_Click(object sender, EventArgs e){
      using (OpenFileDialog dialog = new OpenFileDialog()){
        dialog.CheckFileExists = true;
        dialog.Filter = "Imágenes (*.JPG;*.PNG)|*.JPG;*.PNG|Todos los ficheros (*.*)|*.*";
        dialog.FilterIndex = 0;
        DialogResult result = dialog.ShowDialog(this);
        if( result == DialogResult.OK && dialog.FileName != ""){
          txtFirma.Text = dialog.FileName;
          return;
        }
        txtFirma.Text = "";
      };
    }

    private void btnFirmar_Click(object sender, EventArgs e) {
      int page;
      int x;
      int y;
      try {
        page = Int32.Parse(txtPagina.Text);
        x = Int32.Parse(txtX.Text);
        y = Int32.Parse(txtY.Text);
        if (txtPdf.Text.Trim() == "") throw new Exception("Falta el fichero pdf!!!!");
        if (txtFirma.Text.Trim() == "") throw new Exception("Falta el fichero de la firma!!!!");
      }catch (Exception) {
        MessageBox.Show(this, "Valores incorrectos");
        return;
      }

      try {
        String signedFilename = txtPdf.Text
                                      .Replace(".pdf", ".firmado.pdf");
        File.WriteAllBytes(signedFilename, 
                           IncrustarFirma(txtPdf.Text, txtFirma.Text, page, x, y));
        System.Diagnostics.Process.Start(signedFilename);
      }catch (Exception ex) {
        MessageBox.Show(this, ex.Message);
      }
    }

     public byte[] IncrustarFirma(string pdf, string firma, int page, int posX, int posY){

        byte[] __pdfContent = File.ReadAllBytes(pdf);
        byte[] __imageContent = File.ReadAllBytes(firma);

        using (Stream inputPdfStream = new MemoryStream(__pdfContent)){
          using (Stream inputImageStream = new MemoryStream(__imageContent)){
            using (MemoryStream ms = new MemoryStream()) {
              var reader = new PdfReader(inputPdfStream);
              using (PdfStamper stamper = new PdfStamper(reader, ms, '\0', true)) {
                  var pdfContentByte = stamper.GetOverContent(page);
                  Image image = Image.GetInstance(inputImageStream);
                  image.SetAbsolutePosition(posX, posY);
                  image.BorderWidth = 0;
                  image.Alignment = Element.ALIGN_RIGHT;
                  float percentage2 = 0.0f;
                  percentage2 = 150 / image.Width;
                  image.ScalePercent(percentage2 * 100);
                  pdfContentByte.AddImage(image);
              }
              return ms.ToArray();
            }
          }
        }
     }

  }
}
