namespace DescGym.uContoller
{
    partial class uscWebCam
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
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.btnTomar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // picUsuario
            // 
            this.picUsuario.Image = global::DescGym.Properties.Resources.b8b66ad9ebabc73737bbadada91403d8;
            this.picUsuario.Location = new System.Drawing.Point(4, 4);
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.Size = new System.Drawing.Size(100, 151);
            this.picUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUsuario.TabIndex = 0;
            this.picUsuario.TabStop = false;
            // 
            // btnTomar
            // 
            this.btnTomar.Enabled = false;
            this.btnTomar.Location = new System.Drawing.Point(4, 161);
            this.btnTomar.Name = "btnTomar";
            this.btnTomar.Size = new System.Drawing.Size(100, 23);
            this.btnTomar.TabIndex = 1;
            this.btnTomar.Text = "Activar";
            this.btnTomar.UseVisualStyleBackColor = true;
            this.btnTomar.Click += new System.EventHandler(this.btnTomar_Click);
            // 
            // uscWebCam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTomar);
            this.Controls.Add(this.picUsuario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "uscWebCam";
            this.Size = new System.Drawing.Size(109, 191);
            this.Load += new System.EventHandler(this.uscWebCam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picUsuario;
        private System.Windows.Forms.Button btnTomar;
    }
}
