namespace ConnexionSQL
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
            this.butConnect = new System.Windows.Forms.Button();
            this.butDisconnect = new System.Windows.Forms.Button();
            this.connectionState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butConnect
            // 
            this.butConnect.Location = new System.Drawing.Point(12, 211);
            this.butConnect.Name = "butConnect";
            this.butConnect.Size = new System.Drawing.Size(117, 57);
            this.butConnect.TabIndex = 0;
            this.butConnect.Text = "Connectar";
            this.butConnect.UseVisualStyleBackColor = true;
            this.butConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // butDisconnect
            // 
            this.butDisconnect.Location = new System.Drawing.Point(508, 214);
            this.butDisconnect.Name = "butDisconnect";
            this.butDisconnect.Size = new System.Drawing.Size(128, 54);
            this.butDisconnect.TabIndex = 1;
            this.butDisconnect.Text = "Desconectar";
            this.butDisconnect.UseVisualStyleBackColor = true;
            this.butDisconnect.Click += new System.EventHandler(this.butDisconnect_Click);
            // 
            // connectionState
            // 
            this.connectionState.AutoSize = true;
            this.connectionState.Location = new System.Drawing.Point(323, 57);
            this.connectionState.Name = "connectionState";
            this.connectionState.Size = new System.Drawing.Size(35, 13);
            this.connectionState.TabIndex = 2;
            this.connectionState.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 289);
            this.Controls.Add(this.connectionState);
            this.Controls.Add(this.butDisconnect);
            this.Controls.Add(this.butConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butConnect;
        private System.Windows.Forms.Button butDisconnect;
        private System.Windows.Forms.Label connectionState;
    }
}

