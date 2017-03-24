namespace DescGym.uContoller
{
    partial class uscWebCamIFE
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCapturar = new System.Windows.Forms.Button();
            this.picIFE = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIFE)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(4, 156);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(193, 23);
            this.btnCapturar.TabIndex = 1;
            this.btnCapturar.Text = "Activar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            // 
            // picIFE
            // 
            this.picIFE.Image = global::DescGym.Properties.Resources.IFEDemo;
            this.picIFE.Location = new System.Drawing.Point(4, 3);
            this.picIFE.Name = "picIFE";
            this.picIFE.Size = new System.Drawing.Size(193, 146);
            this.picIFE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIFE.TabIndex = 0;
            this.picIFE.TabStop = false;
            // 
            // uscWebCamIFE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.picIFE);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "uscWebCamIFE";
            this.Size = new System.Drawing.Size(202, 187);
            this.Load += new System.EventHandler(this.uscWebCamIFE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIFE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picIFE;
        private System.Windows.Forms.Button btnCapturar;
    }
}
