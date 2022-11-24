namespace winformapp_1_
{
    partial class frmPokemons
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
            this.dgvPokemons = new System.Windows.Forms.DataGridView();
            this.pbxPokemons = new System.Windows.Forms.PictureBox();
            this.btnElementos = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminarFisico = new System.Windows.Forms.Button();
            this.btnEliminarLogico = new System.Windows.Forms.Button();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblFIltroAvanzado = new System.Windows.Forms.Label();
            this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.txtFiltroAvanzado2 = new System.Windows.Forms.TextBox();
            this.lblFiltroAvanzado2 = new System.Windows.Forms.Label();
            this.lblCriterio2 = new System.Windows.Forms.Label();
            this.lblCampo2 = new System.Windows.Forms.Label();
            this.cboCriterio2 = new System.Windows.Forms.ComboBox();
            this.cboCampo2 = new System.Windows.Forms.ComboBox();
            this.btnAgregarFiltro = new System.Windows.Forms.Button();
            this.rbNumero = new System.Windows.Forms.RadioButton();
            this.gbxCampos = new System.Windows.Forms.GroupBox();
            this.rbDescripcion = new System.Windows.Forms.RadioButton();
            this.rbDebilidad = new System.Windows.Forms.RadioButton();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.rbTipo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPokemons)).BeginInit();
            this.gbxCampos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPokemons
            // 
            this.dgvPokemons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPokemons.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPokemons.Location = new System.Drawing.Point(12, 51);
            this.dgvPokemons.MultiSelect = false;
            this.dgvPokemons.Name = "dgvPokemons";
            this.dgvPokemons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPokemons.Size = new System.Drawing.Size(703, 305);
            this.dgvPokemons.TabIndex = 0;
            this.dgvPokemons.DataSourceChanged += new System.EventHandler(this.dgvPokemons_DataSourceChanged);
            this.dgvPokemons.SelectionChanged += new System.EventHandler(this.dgvPokemons_SelectionChanged);
            // 
            // pbxPokemons
            // 
            this.pbxPokemons.Location = new System.Drawing.Point(721, 51);
            this.pbxPokemons.Name = "pbxPokemons";
            this.pbxPokemons.Size = new System.Drawing.Size(314, 305);
            this.pbxPokemons.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPokemons.TabIndex = 1;
            this.pbxPokemons.TabStop = false;
            // 
            // btnElementos
            // 
            this.btnElementos.Location = new System.Drawing.Point(960, 371);
            this.btnElementos.Name = "btnElementos";
            this.btnElementos.Size = new System.Drawing.Size(75, 23);
            this.btnElementos.TabIndex = 2;
            this.btnElementos.Text = "Elementos";
            this.btnElementos.UseVisualStyleBackColor = true;
            this.btnElementos.Click += new System.EventHandler(this.btnElementos_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 22);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(93, 22);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminarFisico
            // 
            this.btnEliminarFisico.Location = new System.Drawing.Point(174, 22);
            this.btnEliminarFisico.Name = "btnEliminarFisico";
            this.btnEliminarFisico.Size = new System.Drawing.Size(103, 23);
            this.btnEliminarFisico.TabIndex = 5;
            this.btnEliminarFisico.Text = "Eliminar Físico";
            this.btnEliminarFisico.UseVisualStyleBackColor = true;
            this.btnEliminarFisico.Click += new System.EventHandler(this.btnEliminarFisico_Click);
            // 
            // btnEliminarLogico
            // 
            this.btnEliminarLogico.Location = new System.Drawing.Point(283, 22);
            this.btnEliminarLogico.Name = "btnEliminarLogico";
            this.btnEliminarLogico.Size = new System.Drawing.Size(103, 23);
            this.btnEliminarLogico.TabIndex = 6;
            this.btnEliminarLogico.Text = "Eliminar Lógico";
            this.btnEliminarLogico.UseVisualStyleBackColor = true;
            this.btnEliminarLogico.Click += new System.EventHandler(this.btnEliminarLogico_Click);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(12, 381);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(69, 13);
            this.lblFiltro.TabIndex = 7;
            this.lblFiltro.Text = "Filtro Rápido:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(87, 378);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(157, 20);
            this.txtFiltro.TabIndex = 8;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(618, 487);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(75, 20);
            this.btnFiltro.TabIndex = 9;
            this.btnFiltro.Text = "Buscar:";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(70, 487);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(121, 21);
            this.cboCampo.TabIndex = 10;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(263, 487);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(121, 21);
            this.cboCriterio.TabIndex = 11;
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(12, 491);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(43, 13);
            this.lblCampo.TabIndex = 12;
            this.lblCampo.Text = "Campo:";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(206, 491);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(42, 13);
            this.lblCriterio.TabIndex = 13;
            this.lblCriterio.Text = "Criterio:";
            // 
            // lblFIltroAvanzado
            // 
            this.lblFIltroAvanzado.AutoSize = true;
            this.lblFIltroAvanzado.Location = new System.Drawing.Point(399, 491);
            this.lblFIltroAvanzado.Name = "lblFIltroAvanzado";
            this.lblFIltroAvanzado.Size = new System.Drawing.Size(32, 13);
            this.lblFIltroAvanzado.TabIndex = 14;
            this.lblFIltroAvanzado.Text = "Filtro:";
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(446, 487);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(157, 20);
            this.txtFiltroAvanzado.TabIndex = 15;
            // 
            // txtFiltroAvanzado2
            // 
            this.txtFiltroAvanzado2.Location = new System.Drawing.Point(446, 513);
            this.txtFiltroAvanzado2.Name = "txtFiltroAvanzado2";
            this.txtFiltroAvanzado2.Size = new System.Drawing.Size(157, 20);
            this.txtFiltroAvanzado2.TabIndex = 24;
            this.txtFiltroAvanzado2.Visible = false;
            // 
            // lblFiltroAvanzado2
            // 
            this.lblFiltroAvanzado2.AutoSize = true;
            this.lblFiltroAvanzado2.Location = new System.Drawing.Point(399, 517);
            this.lblFiltroAvanzado2.Name = "lblFiltroAvanzado2";
            this.lblFiltroAvanzado2.Size = new System.Drawing.Size(32, 13);
            this.lblFiltroAvanzado2.TabIndex = 23;
            this.lblFiltroAvanzado2.Text = "Filtro:";
            this.lblFiltroAvanzado2.Visible = false;
            // 
            // lblCriterio2
            // 
            this.lblCriterio2.AutoSize = true;
            this.lblCriterio2.Location = new System.Drawing.Point(206, 517);
            this.lblCriterio2.Name = "lblCriterio2";
            this.lblCriterio2.Size = new System.Drawing.Size(42, 13);
            this.lblCriterio2.TabIndex = 22;
            this.lblCriterio2.Text = "Criterio:";
            this.lblCriterio2.Visible = false;
            // 
            // lblCampo2
            // 
            this.lblCampo2.AutoSize = true;
            this.lblCampo2.Location = new System.Drawing.Point(12, 517);
            this.lblCampo2.Name = "lblCampo2";
            this.lblCampo2.Size = new System.Drawing.Size(43, 13);
            this.lblCampo2.TabIndex = 21;
            this.lblCampo2.Text = "Campo:";
            this.lblCampo2.Visible = false;
            // 
            // cboCriterio2
            // 
            this.cboCriterio2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio2.FormattingEnabled = true;
            this.cboCriterio2.Location = new System.Drawing.Point(263, 513);
            this.cboCriterio2.Name = "cboCriterio2";
            this.cboCriterio2.Size = new System.Drawing.Size(121, 21);
            this.cboCriterio2.TabIndex = 20;
            this.cboCriterio2.Visible = false;
            // 
            // cboCampo2
            // 
            this.cboCampo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo2.FormattingEnabled = true;
            this.cboCampo2.Location = new System.Drawing.Point(70, 513);
            this.cboCampo2.Name = "cboCampo2";
            this.cboCampo2.Size = new System.Drawing.Size(121, 21);
            this.cboCampo2.TabIndex = 19;
            this.cboCampo2.Visible = false;
            this.cboCampo2.SelectedIndexChanged += new System.EventHandler(this.cboCampo2_SelectedIndexChanged);
            // 
            // btnAgregarFiltro
            // 
            this.btnAgregarFiltro.Location = new System.Drawing.Point(618, 513);
            this.btnAgregarFiltro.Name = "btnAgregarFiltro";
            this.btnAgregarFiltro.Size = new System.Drawing.Size(85, 22);
            this.btnAgregarFiltro.TabIndex = 25;
            this.btnAgregarFiltro.Text = "Agregar Filtro";
            this.btnAgregarFiltro.UseVisualStyleBackColor = true;
            this.btnAgregarFiltro.Click += new System.EventHandler(this.btnAgregarFiltro_Click);
            // 
            // rbNumero
            // 
            this.rbNumero.AutoSize = true;
            this.rbNumero.Location = new System.Drawing.Point(6, 19);
            this.rbNumero.Name = "rbNumero";
            this.rbNumero.Size = new System.Drawing.Size(62, 17);
            this.rbNumero.TabIndex = 26;
            this.rbNumero.Text = "Número";
            this.rbNumero.UseVisualStyleBackColor = true;
            // 
            // gbxCampos
            // 
            this.gbxCampos.Controls.Add(this.rbDescripcion);
            this.gbxCampos.Controls.Add(this.rbDebilidad);
            this.gbxCampos.Controls.Add(this.rbNombre);
            this.gbxCampos.Controls.Add(this.rbTipo);
            this.gbxCampos.Controls.Add(this.rbNumero);
            this.gbxCampos.Location = new System.Drawing.Point(263, 362);
            this.gbxCampos.Name = "gbxCampos";
            this.gbxCampos.Size = new System.Drawing.Size(168, 90);
            this.gbxCampos.TabIndex = 27;
            this.gbxCampos.TabStop = false;
            this.gbxCampos.Text = "Campos";
            // 
            // rbDescripcion
            // 
            this.rbDescripcion.AutoSize = true;
            this.rbDescripcion.Location = new System.Drawing.Point(6, 42);
            this.rbDescripcion.Name = "rbDescripcion";
            this.rbDescripcion.Size = new System.Drawing.Size(81, 17);
            this.rbDescripcion.TabIndex = 30;
            this.rbDescripcion.Text = "Descripción";
            this.rbDescripcion.UseVisualStyleBackColor = true;
            // 
            // rbDebilidad
            // 
            this.rbDebilidad.AutoSize = true;
            this.rbDebilidad.Location = new System.Drawing.Point(6, 65);
            this.rbDebilidad.Name = "rbDebilidad";
            this.rbDebilidad.Size = new System.Drawing.Size(69, 17);
            this.rbDebilidad.TabIndex = 29;
            this.rbDebilidad.Text = "Debilidad";
            this.rbDebilidad.UseVisualStyleBackColor = true;
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.Checked = true;
            this.rbNombre.Location = new System.Drawing.Point(93, 19);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(62, 17);
            this.rbNombre.TabIndex = 28;
            this.rbNombre.TabStop = true;
            this.rbNombre.Text = "Nombre";
            this.rbNombre.UseVisualStyleBackColor = true;
            // 
            // rbTipo
            // 
            this.rbTipo.AutoSize = true;
            this.rbTipo.Location = new System.Drawing.Point(93, 42);
            this.rbTipo.Name = "rbTipo";
            this.rbTipo.Size = new System.Drawing.Size(46, 17);
            this.rbTipo.TabIndex = 27;
            this.rbTipo.Text = "Tipo";
            this.rbTipo.UseVisualStyleBackColor = true;
            // 
            // frmPokemons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 575);
            this.Controls.Add(this.gbxCampos);
            this.Controls.Add(this.btnAgregarFiltro);
            this.Controls.Add(this.txtFiltroAvanzado2);
            this.Controls.Add(this.lblFiltroAvanzado2);
            this.Controls.Add(this.lblCriterio2);
            this.Controls.Add(this.lblCampo2);
            this.Controls.Add(this.cboCriterio2);
            this.Controls.Add(this.cboCampo2);
            this.Controls.Add(this.txtFiltroAvanzado);
            this.Controls.Add(this.lblFIltroAvanzado);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.cboCriterio);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.btnEliminarLogico);
            this.Controls.Add(this.btnEliminarFisico);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnElementos);
            this.Controls.Add(this.pbxPokemons);
            this.Controls.Add(this.dgvPokemons);
            this.Name = "frmPokemons";
            this.Text = "Pokemons";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPokemons)).EndInit();
            this.gbxCampos.ResumeLayout(false);
            this.gbxCampos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPokemons;
        private System.Windows.Forms.PictureBox pbxPokemons;
        private System.Windows.Forms.Button btnElementos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminarFisico;
        private System.Windows.Forms.Button btnEliminarLogico;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblFIltroAvanzado;
        private System.Windows.Forms.TextBox txtFiltroAvanzado;
        private System.Windows.Forms.TextBox txtFiltroAvanzado2;
        private System.Windows.Forms.Label lblFiltroAvanzado2;
        private System.Windows.Forms.Label lblCriterio2;
        private System.Windows.Forms.Label lblCampo2;
        private System.Windows.Forms.ComboBox cboCriterio2;
        private System.Windows.Forms.ComboBox cboCampo2;
        private System.Windows.Forms.Button btnAgregarFiltro;
        private System.Windows.Forms.RadioButton rbNumero;
        private System.Windows.Forms.GroupBox gbxCampos;
        private System.Windows.Forms.RadioButton rbDescripcion;
        private System.Windows.Forms.RadioButton rbDebilidad;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.RadioButton rbTipo;
    }
}

