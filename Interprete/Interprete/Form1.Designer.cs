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
            this.components = new System.ComponentModel.Container();
            this.InText = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BTNLinea = new System.Windows.Forms.Button();
            this.PanelVisual = new System.Windows.Forms.Panel();
            this.TBLinea = new System.Windows.Forms.TextBox();
            this.BTNPalabra = new System.Windows.Forms.Button();
            this.Figura = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Prueba = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InText
            // 
            this.InText.Location = new System.Drawing.Point(52, 110);
            this.InText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InText.Name = "InText";
            this.InText.Size = new System.Drawing.Size(407, 290);
            this.InText.TabIndex = 0;
            this.InText.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 407);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "Interpreta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTNLinea
            // 
            this.BTNLinea.Enabled = false;
            this.BTNLinea.Location = new System.Drawing.Point(181, 407);
            this.BTNLinea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTNLinea.Name = "BTNLinea";
            this.BTNLinea.Size = new System.Drawing.Size(100, 53);
            this.BTNLinea.TabIndex = 2;
            this.BTNLinea.Text = "Siguiente linea";
            this.BTNLinea.UseVisualStyleBackColor = true;
            this.BTNLinea.Click += new System.EventHandler(this.BTNLinea_Click);
            // 
            // PanelVisual
            // 
            this.PanelVisual.BackColor = System.Drawing.Color.Silver;
            this.PanelVisual.Location = new System.Drawing.Point(560, 110);
            this.PanelVisual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelVisual.Name = "PanelVisual";
            this.PanelVisual.Size = new System.Drawing.Size(445, 290);
            this.PanelVisual.TabIndex = 3;
            this.PanelVisual.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelVisual_Paint);
            // 
            // TBLinea
            // 
            this.TBLinea.Location = new System.Drawing.Point(560, 46);
            this.TBLinea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBLinea.Name = "TBLinea";
            this.TBLinea.ReadOnly = true;
            this.TBLinea.Size = new System.Drawing.Size(445, 22);
            this.TBLinea.TabIndex = 4;
            // 
            // BTNPalabra
            // 
            this.BTNPalabra.Location = new System.Drawing.Point(796, 431);
            this.BTNPalabra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNPalabra.Name = "BTNPalabra";
            this.BTNPalabra.Size = new System.Drawing.Size(99, 23);
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
            this.Figura.Location = new System.Drawing.Point(560, 431);
            this.Figura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Figura.Name = "Figura";
            this.Figura.Size = new System.Drawing.Size(160, 24);
            this.Figura.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(621, 464);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 53);
            this.button2.TabIndex = 7;
            this.button2.Text = "Muestra";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Prueba
            // 
            this.Prueba.AutoSize = true;
            this.Prueba.Location = new System.Drawing.Point(391, 497);
            this.Prueba.Name = "Prueba";
            this.Prueba.Size = new System.Drawing.Size(46, 17);
            this.Prueba.TabIndex = 9;
            this.Prueba.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Prueba);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Figura);
            this.Controls.Add(this.BTNPalabra);
            this.Controls.Add(this.TBLinea);
            this.Controls.Add(this.PanelVisual);
            this.Controls.Add(this.BTNLinea);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.InText);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label Prueba;
    }
}

