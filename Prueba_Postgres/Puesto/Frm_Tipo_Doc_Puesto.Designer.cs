namespace Prueba_Postgres.Puesto
{
    partial class Frm_Tipo_Doc_Puesto
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
            this.Mostrar = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.Volver = new System.Windows.Forms.Button();
            this.Actualizar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Consultar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.datos = new System.Windows.Forms.DataGridView();
            this.cmbestado = new System.Windows.Forms.ComboBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datos)).BeginInit();
            this.SuspendLayout();
            // 
            // Mostrar
            // 
            this.Mostrar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mostrar.Location = new System.Drawing.Point(23, 90);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Size = new System.Drawing.Size(124, 32);
            this.Mostrar.TabIndex = 251;
            this.Mostrar.Text = "Mostrar";
            this.Mostrar.UseVisualStyleBackColor = true;
            this.Mostrar.Click += new System.EventHandler(this.Mostrar_Click);
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(471, 176);
            this.txtid.MaxLength = 2;
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(60, 32);
            this.txtid.TabIndex = 250;
            // 
            // Volver
            // 
            this.Volver.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volver.Location = new System.Drawing.Point(638, 21);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(78, 32);
            this.Volver.TabIndex = 249;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // Actualizar
            // 
            this.Actualizar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actualizar.Location = new System.Drawing.Point(167, 90);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(124, 32);
            this.Actualizar.TabIndex = 248;
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.UseVisualStyleBackColor = true;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar.Location = new System.Drawing.Point(167, 128);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(124, 32);
            this.Eliminar.TabIndex = 247;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Consultar
            // 
            this.Consultar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consultar.Location = new System.Drawing.Point(328, 176);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(124, 32);
            this.Consultar.TabIndex = 246;
            this.Consultar.Text = "Consultar";
            this.Consultar.UseVisualStyleBackColor = true;
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // Guardar
            // 
            this.Guardar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar.Location = new System.Drawing.Point(23, 128);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(124, 32);
            this.Guardar.TabIndex = 245;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // datos
            // 
            this.datos.AllowUserToAddRows = false;
            this.datos.AllowUserToDeleteRows = false;
            this.datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datos.Location = new System.Drawing.Point(308, 21);
            this.datos.Name = "datos";
            this.datos.ReadOnly = true;
            this.datos.Size = new System.Drawing.Size(309, 139);
            this.datos.TabIndex = 244;
            // 
            // cmbestado
            // 
            this.cmbestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbestado.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbestado.FormattingEnabled = true;
            this.cmbestado.Location = new System.Drawing.Point(223, 43);
            this.cmbestado.Name = "cmbestado";
            this.cmbestado.Size = new System.Drawing.Size(68, 25);
            this.cmbestado.TabIndex = 243;
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(23, 43);
            this.txtnombre.MaxLength = 50;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(166, 25);
            this.txtnombre.TabIndex = 242;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(219, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 19);
            this.label8.TabIndex = 241;
            this.label8.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 240;
            this.label1.Text = "Nombre";
            // 
            // Frm_Tipo_Doc_Puesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 222);
            this.Controls.Add(this.Mostrar);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.Actualizar);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Consultar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.datos);
            this.Controls.Add(this.cmbestado);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Tipo_Doc_Puesto";
            this.Text = "Frm_Tipo_Doc_Puesto";
            this.Load += new System.EventHandler(this.Frm_Tipo_Doc_Puesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Mostrar;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button Volver;
        private System.Windows.Forms.Button Actualizar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button Consultar;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.DataGridView datos;
        private System.Windows.Forms.ComboBox cmbestado;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
    }
}