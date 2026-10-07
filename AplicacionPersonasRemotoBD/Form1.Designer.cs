namespace AplicacionPersonasRemotoBD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TxtID = new TextBox();
            TxtNombre = new TextBox();
            TxtTelefono = new TextBox();
            BtnNuevo = new Button();
            BtnGuardar = new Button();
            BtnCancelar = new Button();
            BtnEditar = new Button();
            BtnEliminar = new Button();
            BtnSalir = new Button();
            DgvPersonas = new DataGridView();
            BtnImprimir = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)DgvPersonas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 92);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 141);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 184);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 3;
            label3.Text = "Telefono";
            // 
            // TxtID
            // 
            TxtID.Enabled = false;
            TxtID.Location = new Point(211, 92);
            TxtID.MaxLength = 19;
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(183, 27);
            TxtID.TabIndex = 4;
            TxtID.KeyPress += TxtID_KeyPress;
            // 
            // TxtNombre
            // 
            TxtNombre.Enabled = false;
            TxtNombre.Location = new Point(211, 134);
            TxtNombre.MaxLength = 100;
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(309, 27);
            TxtNombre.TabIndex = 5;
            // 
            // TxtTelefono
            // 
            TxtTelefono.Enabled = false;
            TxtTelefono.Location = new Point(211, 181);
            TxtTelefono.MaxLength = 100;
            TxtTelefono.Name = "TxtTelefono";
            TxtTelefono.Size = new Size(256, 27);
            TxtTelefono.TabIndex = 6;
            // 
            // BtnNuevo
            // 
            BtnNuevo.Image = (Image)resources.GetObject("BtnNuevo.Image");
            BtnNuevo.Location = new Point(85, 250);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(92, 105);
            BtnNuevo.TabIndex = 7;
            BtnNuevo.Text = "Nuevo";
            BtnNuevo.TextAlign = ContentAlignment.BottomCenter;
            BtnNuevo.UseVisualStyleBackColor = true;
            BtnNuevo.Click += BtnNuevo_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Enabled = false;
            BtnGuardar.Image = (Image)resources.GetObject("BtnGuardar.Image");
            BtnGuardar.Location = new Point(193, 250);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(92, 105);
            BtnGuardar.TabIndex = 8;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.TextAlign = ContentAlignment.BottomCenter;
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Enabled = false;
            BtnCancelar.Image = (Image)resources.GetObject("BtnCancelar.Image");
            BtnCancelar.Location = new Point(300, 250);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(92, 105);
            BtnCancelar.TabIndex = 9;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.TextAlign = ContentAlignment.BottomCenter;
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.Image = (Image)resources.GetObject("BtnEditar.Image");
            BtnEditar.Location = new Point(408, 250);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(92, 105);
            BtnEditar.TabIndex = 10;
            BtnEditar.Text = "Editar";
            BtnEditar.TextAlign = ContentAlignment.BottomCenter;
            BtnEditar.UseVisualStyleBackColor = true;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Image = (Image)resources.GetObject("BtnEliminar.Image");
            BtnEliminar.Location = new Point(515, 250);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(92, 105);
            BtnEliminar.TabIndex = 11;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.TextAlign = ContentAlignment.BottomCenter;
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnSalir
            // 
            BtnSalir.Image = (Image)resources.GetObject("BtnSalir.Image");
            BtnSalir.Location = new Point(622, 250);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(92, 105);
            BtnSalir.TabIndex = 12;
            BtnSalir.Text = "Salir";
            BtnSalir.TextAlign = ContentAlignment.BottomCenter;
            BtnSalir.UseVisualStyleBackColor = true;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // DgvPersonas
            // 
            DgvPersonas.AllowUserToAddRows = false;
            DgvPersonas.AllowUserToDeleteRows = false;
            DgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPersonas.Location = new Point(85, 380);
            DgvPersonas.Name = "DgvPersonas";
            DgvPersonas.ReadOnly = true;
            DgvPersonas.RowHeadersWidth = 51;
            DgvPersonas.Size = new Size(638, 266);
            DgvPersonas.TabIndex = 13;
            // 
            // BtnImprimir
            // 
            BtnImprimir.Image = (Image)resources.GetObject("BtnImprimir.Image");
            BtnImprimir.Location = new Point(622, 103);
            BtnImprimir.Name = "BtnImprimir";
            BtnImprimir.Size = new Size(92, 105);
            BtnImprimir.TabIndex = 14;
            BtnImprimir.Text = "Imprimir";
            BtnImprimir.TextAlign = ContentAlignment.BottomCenter;
            BtnImprimir.UseVisualStyleBackColor = true;
            BtnImprimir.Click += BtnImprimir_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 658);
            ControlBox = false;
            Controls.Add(BtnImprimir);
            Controls.Add(DgvPersonas);
            Controls.Add(BtnSalir);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnEditar);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnGuardar);
            Controls.Add(BtnNuevo);
            Controls.Add(TxtTelefono);
            Controls.Add(TxtNombre);
            Controls.Add(TxtID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DgvPersonas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtID;
        private TextBox TxtNombre;
        private TextBox TxtTelefono;
        private Button BtnNuevo;
        private Button BtnGuardar;
        private Button BtnCancelar;
        private Button BtnEditar;
        private Button BtnEliminar;
        private Button BtnSalir;
        private DataGridView DgvPersonas;
        private Button BtnImprimir;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
