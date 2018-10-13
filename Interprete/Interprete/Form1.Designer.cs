namespace Interprete
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
            this.InText = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BTNLinea = new System.Windows.Forms.Button();
            this.PanelVisual = new System.Windows.Forms.Panel();
            this.TBLinea = new System.Windows.Forms.TextBox();
            this.BTNPalabra = new System.Windows.Forms.Button();
            this.Figura = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InText
            // 
            this.InText.Location = new System.Drawing.Point(39, 89);
            this.InText.Name = "InText";
            this.InText.Size = new System.Drawing.Size(306, 236);
            this.InText.TabIndex = 0;
            this.InText.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Interpreta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTNLinea
            // 
            this.BTNLinea.Location = new System.Drawing.Point(136, 331);
            this.BTNLinea.Name = "BTNLinea";
            this.BTNLinea.Size = new System.Drawing.Size(75, 43);
            this.BTNLinea.TabIndex = 2;
            this.BTNLinea.Text = "Siguiente linea";
            this.BTNLinea.UseVisualStyleBackColor = true;
            // 
            // PanelVisual
            // 
            this.PanelVisual.BackColor = System.Drawing.Color.Silver;
            this.PanelVisual.Location = new System.Drawing.Point(420, 89);
            this.PanelVisual.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelVisual.Name = "PanelVisual";
            this.PanelVisual.Size = new System.Drawing.Size(334, 236);
            this.PanelVisual.TabIndex = 3;
            this.PanelVisual.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelVisual_Paint);
            // 
            // TBLinea
            // 
            this.TBLinea.Location = new System.Drawing.Point(420, 37);
            this.TBLinea.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBLinea.Name = "TBLinea";
            this.TBLinea.ReadOnly = true;
            this.TBLinea.Size = new System.Drawing.Size(335, 20);
            this.TBLinea.TabIndex = 4;
            // 
            // BTNPalabra
            // 
            this.BTNPalabra.Location = new System.Drawing.Point(597, 350);
            this.BTNPalabra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNPalabra.Name = "BTNPalabra";
            this.BTNPalabra.Size = new System.Drawing.Size(74, 19);
            this.BTNPalabra.TabIndex = 5;
            this.BTNPalabra.Text = "Siguiente";
            this.BTNPalabra.UseVisualStyleBackColor = true;
            // 
            // Figura
            // 
            this.Figura.FormattingEnabled = true;
            this.Figura.Items.AddRange(new object[] {
            "Circulo",
            "Cuadrado",
            "Triangulo"});
            this.Figura.Location = new System.Drawing.Point(420, 350);
            this.Figura.Name = "Figura";
            this.Figura.Size = new System.Drawing.Size(121, 21);
            this.Figura.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(466, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 43);
            this.button2.TabIndex = 7;
            this.button2.Text = "Muestra";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Figura);
            this.Controls.Add(this.BTNPalabra);
            this.Controls.Add(this.TBLinea);
            this.Controls.Add(this.PanelVisual);
            this.Controls.Add(this.BTNLinea);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.InText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox InText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTNLinea;
        private System.Windows.Forms.Panel PanelVisual;
        private System.Windows.Forms.TextBox TBLinea;
        private System.Windows.Forms.Button BTNPalabra;
        private System.Windows.Forms.ComboBox Figura;
        private System.Windows.Forms.Button button2;
    }
}

