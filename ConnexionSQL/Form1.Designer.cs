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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttExecute = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.butInsertEmployee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // butConnect
            // 
            this.butConnect.Location = new System.Drawing.Point(508, 127);
            this.butConnect.Name = "butConnect";
            this.butConnect.Size = new System.Drawing.Size(128, 42);
            this.butConnect.TabIndex = 0;
            this.butConnect.Text = "Connectar";
            this.butConnect.UseVisualStyleBackColor = true;
            this.butConnect.Click += new System.EventHandler(this.butConnect_Click);
            // 
            // butDisconnect
            // 
            this.butDisconnect.Location = new System.Drawing.Point(508, 175);
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
            this.connectionState.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionState.Location = new System.Drawing.Point(262, 31);
            this.connectionState.Name = "connectionState";
            this.connectionState.Size = new System.Drawing.Size(83, 24);
            this.connectionState.TabIndex = 2;
            this.connectionState.Text = "Stand by";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(475, 20);
            this.textBox1.TabIndex = 3;
            // 
            // buttExecute
            // 
            this.buttExecute.Location = new System.Drawing.Point(508, 95);
            this.buttExecute.Name = "buttExecute";
            this.buttExecute.Size = new System.Drawing.Size(128, 23);
            this.buttExecute.TabIndex = 4;
            this.buttExecute.Text = "Ejecutar";
            this.buttExecute.UseVisualStyleBackColor = true;
            this.buttExecute.Click += new System.EventHandler(this.buttExecute_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(475, 210);
            this.dataGridView1.TabIndex = 5;
            // 
            // butInsertEmployee
            // 
            this.butInsertEmployee.Location = new System.Drawing.Point(508, 262);
            this.butInsertEmployee.Name = "butInsertEmployee";
            this.butInsertEmployee.Size = new System.Drawing.Size(128, 23);
            this.butInsertEmployee.TabIndex = 6;
            this.butInsertEmployee.Text = "Insert employee";
            this.butInsertEmployee.UseVisualStyleBackColor = true;
            this.butInsertEmployee.Click += new System.EventHandler(this.butInsertEmployee_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 349);
            this.Controls.Add(this.butInsertEmployee);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttExecute);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.connectionState);
            this.Controls.Add(this.butDisconnect);
            this.Controls.Add(this.butConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butConnect;
        private System.Windows.Forms.Button butDisconnect;
        private System.Windows.Forms.Label connectionState;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttExecute;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butInsertEmployee;
    }
}

