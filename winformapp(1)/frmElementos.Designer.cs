namespace winformapp_1_
{
    partial class frmElementos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvElementos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblAgregarElemento = new System.Windows.Forms.Label();
            this.txtbxElemento = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElementos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvElementos
            // 
            this.dgvElementos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvElementos.Location = new System.Drawing.Point(12, 12);
            this.dgvElementos.Name = "dgvElementos";
            this.dgvElementos.Size = new System.Drawing.Size(354, 260);
            this.dgvElementos.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(409, 61);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblAgregarElemento
            // 
            this.lblAgregarElemento.AutoSize = true;
            this.lblAgregarElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarElemento.Location = new System.Drawing.Point(372, 12);
            this.lblAgregarElemento.Name = "lblAgregarElemento";
            this.lblAgregarElemento.Size = new System.Drawing.Size(154, 20);
            this.lblAgregarElemento.TabIndex = 2;
            this.lblAgregarElemento.Text = "Agregar Elemento";
            // 
            // txtbxElemento
            // 
            this.txtbxElemento.Location = new System.Drawing.Point(399, 35);
            this.txtbxElemento.Name = "txtbxElemento";
            this.txtbxElemento.Size = new System.Drawing.Size(100, 20);
            this.txtbxElemento.TabIndex = 3;
            // 
            // frmElementos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 284);
            this.Controls.Add(this.txtbxElemento);
            this.Controls.Add(this.lblAgregarElemento);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvElementos);
            this.Name = "frmElementos";
            this.Text = "Elementos";
            this.Load += new System.EventHandler(this.FormpruebaElementos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvElementos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvElementos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblAgregarElemento;
        private System.Windows.Forms.TextBox txtbxElemento;
    }
}