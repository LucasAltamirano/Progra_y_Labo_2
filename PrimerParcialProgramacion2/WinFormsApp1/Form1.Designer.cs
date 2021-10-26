
namespace WinFormsApp1
{
    partial class forxvdsf
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Computadoras = new System.Windows.Forms.ListView();
            this.chId = new System.Windows.Forms.ColumnHeader();
            this.chCliente = new System.Windows.Forms.ColumnHeader();
            this.chRequerimiento = new System.Windows.Forms.ColumnHeader();
            this.chInicio = new System.Windows.Forms.ColumnHeader();
            this.chDuracion = new System.Windows.Forms.ColumnHeader();
            this.chPreciosinIva = new System.Windows.Forms.ColumnHeader();
            this.chPrecioConIva = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(499, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Computadoras
            // 
            this.Computadoras.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.chCliente,
            this.chRequerimiento,
            this.chInicio,
            this.chDuracion,
            this.chPreciosinIva,
            this.chPrecioConIva});
            this.Computadoras.HideSelection = false;
            this.Computadoras.Location = new System.Drawing.Point(55, 97);
            this.Computadoras.Name = "Computadoras";
            this.Computadoras.Size = new System.Drawing.Size(643, 155);
            this.Computadoras.TabIndex = 1;
            this.Computadoras.UseCompatibleStateImageBehavior = false;
            this.Computadoras.View = System.Windows.Forms.View.Details;
            this.Computadoras.SelectedIndexChanged += new System.EventHandler(this.Computadoras_SelectedIndexChanged);
             // 
            // chId
            // 
            this.chId.Text = "id pc";
            this.chId.Width = 50;
            // 
            // chCliente
            // 
            this.chCliente.Text = "Cliente";
            this.chCliente.Width = 90;
            // 
            // chRequerimiento
            // 
            this.chRequerimiento.DisplayIndex = 4;
            this.chRequerimiento.Text = "Requeriento";
            this.chRequerimiento.Width = 90;
            // 
            // chInicio
            // 
            this.chInicio.DisplayIndex = 2;
            this.chInicio.Text = "Inicio";
            // 
            // chDuracion
            // 
            this.chDuracion.DisplayIndex = 3;
            this.chDuracion.Text = "Duracion";
            // 
            // chPreciosinIva
            // 
            this.chPreciosinIva.Text = "Precio sin/IVA";
            this.chPreciosinIva.Width = 90;
            // 
            // chPrecioConIva
            // 
            this.chPrecioConIva.Text = "Precio c/IVA";
            this.chPrecioConIva.Width = 90;
            // 
            // forxvdsf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Computadoras);
            this.Controls.Add(this.textBox1);
            this.Name = "forxvdsf";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView Computadoras;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chCliente;
        private System.Windows.Forms.ColumnHeader chRequerimiento;
        private System.Windows.Forms.ColumnHeader chInicio;
        private System.Windows.Forms.ColumnHeader chDuracion;
        private System.Windows.Forms.ColumnHeader chPreciosinIva;
        private System.Windows.Forms.ColumnHeader chPrecioConIva;
    }
}

