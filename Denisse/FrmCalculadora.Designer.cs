
namespace CalculadoraDePrestamos
{
    partial class FrmCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblMonto = new System.Windows.Forms.Label();
            this.LblTipoDePrestamo = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.CbxTipoDePrestamo = new System.Windows.Forms.ComboBox();
            this.LblTasaDeIntereses = new System.Windows.Forms.Label();
            this.lblMesesApagar = new System.Windows.Forms.Label();
            this.cbxMesesApagar = new System.Windows.Forms.ComboBox();
            this.lblCuotaMensual = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtTasaDeInteres = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Rockwell Condensed", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTitulo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LblTitulo.Location = new System.Drawing.Point(246, 53);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(301, 40);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Calculadora de prestamos";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblMonto
            // 
            this.LblMonto.AutoSize = true;
            this.LblMonto.Font = new System.Drawing.Font("Rockwell Condensed", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblMonto.Location = new System.Drawing.Point(12, 151);
            this.LblMonto.Name = "LblMonto";
            this.LblMonto.Size = new System.Drawing.Size(175, 24);
            this.LblMonto.TabIndex = 1;
            this.LblMonto.Text = "Monto del prestamo";
            // 
            // LblTipoDePrestamo
            // 
            this.LblTipoDePrestamo.AutoSize = true;
            this.LblTipoDePrestamo.Font = new System.Drawing.Font("Rockwell Condensed", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTipoDePrestamo.Location = new System.Drawing.Point(12, 199);
            this.LblTipoDePrestamo.Name = "LblTipoDePrestamo";
            this.LblTipoDePrestamo.Size = new System.Drawing.Size(242, 24);
            this.LblTipoDePrestamo.TabIndex = 2;
            this.LblTipoDePrestamo.Text = "Tipo de prestamo que desea";
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMonto.Location = new System.Drawing.Point(203, 152);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(147, 26);
            this.txtMonto.TabIndex = 3;
            // 
            // CbxTipoDePrestamo
            // 
            this.CbxTipoDePrestamo.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbxTipoDePrestamo.FormattingEnabled = true;
            this.CbxTipoDePrestamo.Location = new System.Drawing.Point(260, 199);
            this.CbxTipoDePrestamo.Name = "CbxTipoDePrestamo";
            this.CbxTipoDePrestamo.Size = new System.Drawing.Size(417, 27);
            this.CbxTipoDePrestamo.TabIndex = 4;
            this.CbxTipoDePrestamo.SelectedIndexChanged += new System.EventHandler(this.CbxTipoDePrestamo_SelectedIndexChanged);
            // 
            // LblTasaDeIntereses
            // 
            this.LblTasaDeIntereses.AutoSize = true;
            this.LblTasaDeIntereses.Font = new System.Drawing.Font("Rockwell Condensed", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTasaDeIntereses.Location = new System.Drawing.Point(12, 246);
            this.LblTasaDeIntereses.Name = "LblTasaDeIntereses";
            this.LblTasaDeIntereses.Size = new System.Drawing.Size(137, 24);
            this.LblTasaDeIntereses.TabIndex = 5;
            this.LblTasaDeIntereses.Text = "Tasa de Interes";
            // 
            // lblMesesApagar
            // 
            this.lblMesesApagar.AutoSize = true;
            this.lblMesesApagar.Font = new System.Drawing.Font("Rockwell Condensed", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMesesApagar.Location = new System.Drawing.Point(12, 293);
            this.lblMesesApagar.Name = "lblMesesApagar";
            this.lblMesesApagar.Size = new System.Drawing.Size(129, 24);
            this.lblMesesApagar.TabIndex = 6;
            this.lblMesesApagar.Text = "Meses A pagar";
            // 
            // cbxMesesApagar
            // 
            this.cbxMesesApagar.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxMesesApagar.FormattingEnabled = true;
            this.cbxMesesApagar.Location = new System.Drawing.Point(167, 293);
            this.cbxMesesApagar.Name = "cbxMesesApagar";
            this.cbxMesesApagar.Size = new System.Drawing.Size(411, 27);
            this.cbxMesesApagar.TabIndex = 7;
            this.cbxMesesApagar.SelectedIndexChanged += new System.EventHandler(this.cbxMesesApagar_SelectedIndexChanged);
            // 
            // lblCuotaMensual
            // 
            this.lblCuotaMensual.AutoSize = true;
            this.lblCuotaMensual.Font = new System.Drawing.Font("Rockwell Condensed", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCuotaMensual.Location = new System.Drawing.Point(281, 392);
            this.lblCuotaMensual.Name = "lblCuotaMensual";
            this.lblCuotaMensual.Size = new System.Drawing.Size(202, 24);
            this.lblCuotaMensual.TabIndex = 8;
            this.lblCuotaMensual.Text = "Cuota a pagar mensual";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCalcular.Font = new System.Drawing.Font("Rockwell Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.Location = new System.Drawing.Point(75, 362);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(112, 54);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Rockwell Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResultado.Location = new System.Drawing.Point(489, 393);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(125, 26);
            this.txtResultado.TabIndex = 10;
            // 
            // txtTasaDeInteres
            // 
            this.txtTasaDeInteres.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTasaDeInteres.Location = new System.Drawing.Point(167, 243);
            this.txtTasaDeInteres.Name = "txtTasaDeInteres";
            this.txtTasaDeInteres.ReadOnly = true;
            this.txtTasaDeInteres.Size = new System.Drawing.Size(217, 26);
            this.txtTasaDeInteres.TabIndex = 11;
            // 
            // FrmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 444);
            this.Controls.Add(this.txtTasaDeInteres);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblCuotaMensual);
            this.Controls.Add(this.cbxMesesApagar);
            this.Controls.Add(this.lblMesesApagar);
            this.Controls.Add(this.LblTasaDeIntereses);
            this.Controls.Add(this.CbxTipoDePrestamo);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.LblTipoDePrestamo);
            this.Controls.Add(this.LblMonto);
            this.Controls.Add(this.LblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCalculadora";
            this.Text = "Calculadora de prestamos";
            this.Load += new System.EventHandler(this.FrmCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblMonto;
        private System.Windows.Forms.Label LblTipoDePrestamo;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.ComboBox CbxTipoDePrestamo;
        private System.Windows.Forms.Label LblTasaDeIntereses;
        private System.Windows.Forms.Label lblMesesApagar;
        private System.Windows.Forms.ComboBox cbxMesesApagar;
        private System.Windows.Forms.Label lblCuotaMensual;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtTasaDeInteres;
    }
}

