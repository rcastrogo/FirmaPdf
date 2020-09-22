namespace FirmaPdf
{
  partial class Form1
  {
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
      this.btnFirmar = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.txtPdf = new System.Windows.Forms.TextBox();
      this.txtPagina = new System.Windows.Forms.TextBox();
      this.txtX = new System.Windows.Forms.TextBox();
      this.txtY = new System.Windows.Forms.TextBox();
      this.txtFirma = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.btnAbrirPdf = new System.Windows.Forms.Button();
      this.btnAbrirFirma = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnFirmar
      // 
      this.btnFirmar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
      this.btnFirmar.Location = new System.Drawing.Point(8, 80);
      this.btnFirmar.Name = "btnFirmar";
      this.btnFirmar.Size = new System.Drawing.Size(352, 32);
      this.btnFirmar.TabIndex = 0;
      this.btnFirmar.Text = "Firmar";
      this.btnFirmar.UseVisualStyleBackColor = true;
      this.btnFirmar.Click += new System.EventHandler(this.btnFirmar_Click);
      // 
      // label1
      // 
      this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label1.Location = new System.Drawing.Point(8, 8);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(72, 20);
      this.label1.TabIndex = 1;
      this.label1.Text = "Pdf:";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label2
      // 
      this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label2.Location = new System.Drawing.Point(8, 56);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(72, 20);
      this.label2.TabIndex = 2;
      this.label2.Text = "Página:";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label3
      // 
      this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label3.Location = new System.Drawing.Point(128, 56);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(72, 20);
      this.label3.TabIndex = 3;
      this.label3.Text = "Posición X:";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label4
      // 
      this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label4.Location = new System.Drawing.Point(248, 56);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(72, 20);
      this.label4.TabIndex = 4;
      this.label4.Text = "Posición Y:";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // txtPdf
      // 
      this.txtPdf.Enabled = false;
      this.txtPdf.Location = new System.Drawing.Point(88, 8);
      this.txtPdf.Name = "txtPdf";
      this.txtPdf.Size = new System.Drawing.Size(232, 20);
      this.txtPdf.TabIndex = 5;
      // 
      // txtPagina
      // 
      this.txtPagina.Location = new System.Drawing.Point(88, 56);
      this.txtPagina.Name = "txtPagina";
      this.txtPagina.Size = new System.Drawing.Size(32, 20);
      this.txtPagina.TabIndex = 6;
      this.txtPagina.Text = "1";
      this.txtPagina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // txtX
      // 
      this.txtX.Location = new System.Drawing.Point(208, 56);
      this.txtX.Name = "txtX";
      this.txtX.Size = new System.Drawing.Size(32, 20);
      this.txtX.TabIndex = 7;
      this.txtX.Text = "200";
      this.txtX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // txtY
      // 
      this.txtY.Location = new System.Drawing.Point(328, 56);
      this.txtY.Name = "txtY";
      this.txtY.Size = new System.Drawing.Size(32, 20);
      this.txtY.TabIndex = 8;
      this.txtY.Text = "0";
      this.txtY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // txtFirma
      // 
      this.txtFirma.Enabled = false;
      this.txtFirma.Location = new System.Drawing.Point(88, 32);
      this.txtFirma.Name = "txtFirma";
      this.txtFirma.Size = new System.Drawing.Size(232, 20);
      this.txtFirma.TabIndex = 10;
      // 
      // label5
      // 
      this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label5.Location = new System.Drawing.Point(8, 32);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(72, 20);
      this.label5.TabIndex = 9;
      this.label5.Text = "Firma:";
      this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // btnAbrirPdf
      // 
      this.btnAbrirPdf.Location = new System.Drawing.Point(328, 8);
      this.btnAbrirPdf.Name = "btnAbrirPdf";
      this.btnAbrirPdf.Size = new System.Drawing.Size(32, 23);
      this.btnAbrirPdf.TabIndex = 11;
      this.btnAbrirPdf.Text = "...";
      this.btnAbrirPdf.UseVisualStyleBackColor = true;
      this.btnAbrirPdf.Click += new System.EventHandler(this.btnAbrirPdf_Click);
      // 
      // btnAbrirFirma
      // 
      this.btnAbrirFirma.Location = new System.Drawing.Point(328, 32);
      this.btnAbrirFirma.Name = "btnAbrirFirma";
      this.btnAbrirFirma.Size = new System.Drawing.Size(32, 23);
      this.btnAbrirFirma.TabIndex = 12;
      this.btnAbrirFirma.Text = "...";
      this.btnAbrirFirma.UseVisualStyleBackColor = true;
      this.btnAbrirFirma.Click += new System.EventHandler(this.btnAbrirFirma_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(368, 121);
      this.Controls.Add(this.btnAbrirFirma);
      this.Controls.Add(this.btnAbrirPdf);
      this.Controls.Add(this.txtFirma);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.txtY);
      this.Controls.Add(this.txtX);
      this.Controls.Add(this.txtPagina);
      this.Controls.Add(this.txtPdf);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnFirmar);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Form1";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "FirmaPdf";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnFirmar;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtPdf;
    private System.Windows.Forms.TextBox txtPagina;
    private System.Windows.Forms.TextBox txtX;
    private System.Windows.Forms.TextBox txtY;
    private System.Windows.Forms.TextBox txtFirma;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button btnAbrirPdf;
    private System.Windows.Forms.Button btnAbrirFirma;
  }
}

