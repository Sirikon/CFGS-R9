namespace R9E20
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.filasLabel = new System.Windows.Forms.Label();
            this.filasInput = new System.Windows.Forms.NumericUpDown();
            this.columnasInput = new System.Windows.Forms.NumericUpDown();
            this.columnasLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.filasInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnasInput)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Crear matriz de botones de:";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // filasLabel
            // 
            this.filasLabel.AutoSize = true;
            this.filasLabel.Location = new System.Drawing.Point(183, 17);
            this.filasLabel.Name = "filasLabel";
            this.filasLabel.Size = new System.Drawing.Size(28, 13);
            this.filasLabel.TabIndex = 1;
            this.filasLabel.Text = "Filas";
            // 
            // filasInput
            // 
            this.filasInput.Location = new System.Drawing.Point(217, 15);
            this.filasInput.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.filasInput.Name = "filasInput";
            this.filasInput.Size = new System.Drawing.Size(48, 20);
            this.filasInput.TabIndex = 2;
            // 
            // columnasInput
            // 
            this.columnasInput.Location = new System.Drawing.Point(330, 15);
            this.columnasInput.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.columnasInput.Name = "columnasInput";
            this.columnasInput.Size = new System.Drawing.Size(48, 20);
            this.columnasInput.TabIndex = 3;
            // 
            // columnasLabel
            // 
            this.columnasLabel.AutoSize = true;
            this.columnasLabel.Location = new System.Drawing.Point(271, 17);
            this.columnasLabel.Name = "columnasLabel";
            this.columnasLabel.Size = new System.Drawing.Size(53, 13);
            this.columnasLabel.TabIndex = 4;
            this.columnasLabel.Text = "Columnas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 49);
            this.Controls.Add(this.columnasLabel);
            this.Controls.Add(this.columnasInput);
            this.Controls.Add(this.filasInput);
            this.Controls.Add(this.filasLabel);
            this.Controls.Add(this.button1);
            this.MinimumSize = new System.Drawing.Size(412, 88);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Matriz(2D) de Botones";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.filasInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnasInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label filasLabel;
        private System.Windows.Forms.NumericUpDown filasInput;
        private System.Windows.Forms.NumericUpDown columnasInput;
        private System.Windows.Forms.Label columnasLabel;
    }
}

