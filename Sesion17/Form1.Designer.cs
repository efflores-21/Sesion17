namespace Sesion17
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
            this.btnGoToProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGoToProduct
            // 
            this.btnGoToProduct.Location = new System.Drawing.Point(105, 87);
            this.btnGoToProduct.Name = "btnGoToProduct";
            this.btnGoToProduct.Size = new System.Drawing.Size(109, 23);
            this.btnGoToProduct.TabIndex = 0;
            this.btnGoToProduct.Text = "Ir a Productos";
            this.btnGoToProduct.UseVisualStyleBackColor = true;
            this.btnGoToProduct.Click += new System.EventHandler(this.btnGoToProduct_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 196);
            this.Controls.Add(this.btnGoToProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGoToProduct;
    }
}

