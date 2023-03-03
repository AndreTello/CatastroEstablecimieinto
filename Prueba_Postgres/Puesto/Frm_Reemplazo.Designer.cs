namespace Prueba_Postgres.Puesto
{
    partial class Frm_Reemplazo
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
            this.dateinicio = new System.Windows.Forms.DateTimePicker();
            this.Mostrar = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.Volver = new System.Windows.Forms.Button();
            this.Actualizar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Consultar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.datos = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.txtnoficio = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtautorizacion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtnombres = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtapellidos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbestado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.datefin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datos)).BeginInit();
            this.SuspendLayout();
            // 
            // dateinicio
            // 
            this.dateinicio.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateinicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateinicio.Location = new System.Drawing.Point(209, 97);
            this.dateinicio.Name = "dateinicio";
            this.dateinicio.Size = new System.Drawing.Size(166, 25);
            this.dateinicio.TabIndex = 211;
            // 
            // Mostrar
            // 
            this.Mostrar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mostrar.Location = new System.Drawing.Point(89, 143);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Size = new System.Drawing.Size(124, 32);
            this.Mostrar.TabIndex = 210;
            this.Mostrar.Text = "Mostrar";
            this.Mostrar.UseVisualStyleBackColor = true;
            this.Mostrar.Click += new System.EventHandler(this.Mostrar_Click);
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(156, 364);
            this.txtid.MaxLength = 2;
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(60, 32);
            this.txtid.TabIndex = 209;
            // 
            // Volver
            // 
            this.Volver.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volver.Location = new System.Drawing.Point(679, 364);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(78, 32);
            this.Volver.TabIndex = 208;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // Actualizar
            // 
            this.Actualizar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actualizar.Location = new System.Drawing.Point(387, 143);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(124, 32);
            this.Actualizar.TabIndex = 207;
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.UseVisualStyleBackColor = true;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar.Location = new System.Drawing.Point(536, 143);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(124, 32);
            this.Eliminar.TabIndex = 206;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Consultar
            // 
            this.Consultar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consultar.Location = new System.Drawing.Point(11, 364);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(124, 32);
            this.Consultar.TabIndex = 205;
            this.Consultar.Text = "Consultar";
            this.Consultar.UseVisualStyleBackColor = true;
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // Guardar
            // 
            this.Guardar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar.Location = new System.Drawing.Point(240, 143);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(124, 32);
            this.Guardar.TabIndex = 204;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // datos
            // 
            this.datos.AllowUserToAddRows = false;
            this.datos.AllowUserToDeleteRows = false;
            this.datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datos.Location = new System.Drawing.Point(11, 195);
            this.datos.Name = "datos";
            this.datos.ReadOnly = true;
            this.datos.Size = new System.Drawing.Size(746, 150);
            this.datos.TabIndex = 203;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(205, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 19);
            this.label14.TabIndex = 202;
            this.label14.Text = "Fecha_Oficio";
            // 
            // txtnoficio
            // 
            this.txtnoficio.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnoficio.Location = new System.Drawing.Point(23, 97);
            this.txtnoficio.MaxLength = 20;
            this.txtnoficio.Name = "txtnoficio";
            this.txtnoficio.Size = new System.Drawing.Size(166, 25);
            this.txtnoficio.TabIndex = 201;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(19, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 19);
            this.label12.TabIndex = 200;
            this.label12.Text = "Numero_Oficio";
            // 
            // txtautorizacion
            // 
            this.txtautorizacion.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtautorizacion.Location = new System.Drawing.Point(581, 37);
            this.txtautorizacion.MaxLength = 10;
            this.txtautorizacion.Name = "txtautorizacion";
            this.txtautorizacion.Size = new System.Drawing.Size(166, 25);
            this.txtautorizacion.TabIndex = 199;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(577, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 19);
            this.label11.TabIndex = 198;
            this.label11.Text = "Autorizacion";
            // 
            // txtnombres
            // 
            this.txtnombres.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombres.Location = new System.Drawing.Point(397, 37);
            this.txtnombres.MaxLength = 50;
            this.txtnombres.Name = "txtnombres";
            this.txtnombres.Size = new System.Drawing.Size(166, 25);
            this.txtnombres.TabIndex = 195;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(393, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 19);
            this.label9.TabIndex = 194;
            this.label9.Text = "Nombres";
            // 
            // txtapellidos
            // 
            this.txtapellidos.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellidos.Location = new System.Drawing.Point(209, 37);
            this.txtapellidos.MaxLength = 50;
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(166, 25);
            this.txtapellidos.TabIndex = 193;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(205, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 19);
            this.label7.TabIndex = 192;
            this.label7.Text = "Apellidos";
            // 
            // txtcedula
            // 
            this.txtcedula.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcedula.Location = new System.Drawing.Point(23, 37);
            this.txtcedula.MaxLength = 10;
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(166, 25);
            this.txtcedula.TabIndex = 191;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 19);
            this.label6.TabIndex = 190;
            this.label6.Text = "Cedula";
            // 
            // cmbestado
            // 
            this.cmbestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbestado.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbestado.FormattingEnabled = true;
            this.cmbestado.Location = new System.Drawing.Point(581, 97);
            this.cmbestado.Name = "cmbestado";
            this.cmbestado.Size = new System.Drawing.Size(68, 25);
            this.cmbestado.TabIndex = 189;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(577, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 19);
            this.label8.TabIndex = 188;
            this.label8.Text = "Estado";
            // 
            // datefin
            // 
            this.datefin.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datefin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datefin.Location = new System.Drawing.Point(397, 97);
            this.datefin.Name = "datefin";
            this.datefin.Size = new System.Drawing.Size(166, 25);
            this.datefin.TabIndex = 213;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(393, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 212;
            this.label1.Text = "Fecha_Oficio";
            // 
            // Frm_Reemplazo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 410);
            this.Controls.Add(this.datefin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateinicio);
            this.Controls.Add(this.Mostrar);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.Actualizar);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Consultar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.datos);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtnoficio);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtautorizacion);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtnombres);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtapellidos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtcedula);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbestado);
            this.Controls.Add(this.label8);
            this.Name = "Frm_Reemplazo";
            this.Text = "Frm_Reemplazo";
            this.Load += new System.EventHandler(this.Frm_Reemplazo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateinicio;
        private System.Windows.Forms.Button Mostrar;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button Volver;
        private System.Windows.Forms.Button Actualizar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button Consultar;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.DataGridView datos;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtnoficio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtautorizacion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtnombres;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtapellidos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbestado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker datefin;
        private System.Windows.Forms.Label label1;
    }
}