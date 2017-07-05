namespace ESCUELAS
{
    partial class GuardarAlumno
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxApoderados = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxCurso = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtApellidoP = new System.Windows.Forms.TextBox();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.txtApellidoM = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.Rut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apoderado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Del = new System.Windows.Forms.DataGridViewButtonColumn();
            this.errorMensaje = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMensaje)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbxApoderados);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbxCurso);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtApellidoP);
            this.groupBox1.Controls.Add(this.txtRut);
            this.groupBox1.Controls.Add(this.txtApellidoM);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 167);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso Alumno";
            // 
            // button1
            // 
            this.button1.Image = global::ESCUELAS.Properties.Resources.search_16;
            this.button1.Location = new System.Drawing.Point(134, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 23);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 7.75F);
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rut";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 7.75F);
            this.label2.Location = new System.Drawing.Point(25, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 7.75F);
            this.btnGuardar.Image = global::ESCUELAS.Properties.Resources.save_16;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnGuardar.Location = new System.Drawing.Point(598, 124);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(69, 23);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 7.75F);
            this.label3.Location = new System.Drawing.Point(201, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido Paterno";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 7.75F);
            this.btnCancelar.Image = global::ESCUELAS.Properties.Resources.edit_clear;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCancelar.Location = new System.Drawing.Point(517, 124);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 7.75F);
            this.label4.Location = new System.Drawing.Point(428, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido Materno";
            // 
            // cbxApoderados
            // 
            this.cbxApoderados.FormattingEnabled = true;
            this.cbxApoderados.Location = new System.Drawing.Point(204, 126);
            this.cbxApoderados.Name = "cbxApoderados";
            this.cbxApoderados.Size = new System.Drawing.Size(267, 24);
            this.cbxApoderados.TabIndex = 6;
            this.cbxApoderados.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbxApoderados_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 7.75F);
            this.label5.Location = new System.Drawing.Point(25, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "Curso";
            // 
            // cbxCurso
            // 
            this.cbxCurso.FormattingEnabled = true;
            this.cbxCurso.Location = new System.Drawing.Point(28, 124);
            this.cbxCurso.Name = "cbxCurso";
            this.cbxCurso.Size = new System.Drawing.Size(159, 24);
            this.cbxCurso.TabIndex = 5;
            this.cbxCurso.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbxCurso_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 7.75F);
            this.label6.Location = new System.Drawing.Point(201, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "Apoderado";
            // 
            // txtApellidoP
            // 
            this.txtApellidoP.Location = new System.Drawing.Point(204, 79);
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Size = new System.Drawing.Size(205, 22);
            this.txtApellidoP.TabIndex = 3;
            this.txtApellidoP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloLetras);
            this.txtApellidoP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtApellidoP_KeyUp);
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(28, 41);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(100, 22);
            this.txtRut.TabIndex = 1;
            this.txtRut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRut_KeyPress);
            this.txtRut.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRut_KeyUp);
            // 
            // txtApellidoM
            // 
            this.txtApellidoM.Location = new System.Drawing.Point(431, 79);
            this.txtApellidoM.Name = "txtApellidoM";
            this.txtApellidoM.Size = new System.Drawing.Size(225, 22);
            this.txtApellidoM.TabIndex = 4;
            this.txtApellidoM.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtApellidoM_KeyUp);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(28, 81);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(159, 22);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloLetras);
            this.txtNombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNombre_KeyUp);
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.AllowUserToAddRows = false;
            this.dgvAlumnos.AllowUserToDeleteRows = false;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rut,
            this.Nombre,
            this.Apoderado,
            this.Curso,
            this.Edit,
            this.Del});
            this.dgvAlumnos.Location = new System.Drawing.Point(24, 185);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.Size = new System.Drawing.Size(696, 217);
            this.dgvAlumnos.TabIndex = 14;
            this.dgvAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlumnos_CellContentClick);
            this.dgvAlumnos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAlumnos_CellFormatting);
            this.dgvAlumnos.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvAlumnos_CellPainting);
            // 
            // Rut
            // 
            this.Rut.HeaderText = "Rut";
            this.Rut.Name = "Rut";
            this.Rut.ReadOnly = true;
            this.Rut.Width = 80;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 180;
            // 
            // Apoderado
            // 
            this.Apoderado.HeaderText = "Apoderado";
            this.Apoderado.Name = "Apoderado";
            this.Apoderado.ReadOnly = true;
            this.Apoderado.Width = 180;
            // 
            // Curso
            // 
            this.Curso.HeaderText = "Curso";
            this.Curso.Name = "Curso";
            this.Curso.ReadOnly = true;
            this.Curso.Width = 120;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Editar";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = " ";
            this.Edit.Width = 40;
            // 
            // Del
            // 
            this.Del.HeaderText = "Quitar";
            this.Del.Name = "Del";
            this.Del.ReadOnly = true;
            this.Del.Width = 40;
            // 
            // errorMensaje
            // 
            this.errorMensaje.ContainerControl = this;
            // 
            // GuardarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 424);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvAlumnos);
            this.Name = "GuardarAlumno";
            this.Text = "Formulario Alumno";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.cargarControlesIniciales);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMensaje)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxApoderados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxCurso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtApellidoP;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.TextBox txtApellidoM;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apoderado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Del;
        private System.Windows.Forms.ErrorProvider errorMensaje;
    }
}

