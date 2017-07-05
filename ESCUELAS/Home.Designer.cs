namespace ESCUELAS
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarAlumnosSegunApoderadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ingresarApoderadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.matriculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosSegunCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoAlumnosPorCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem,
            this.matriculaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(849, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarAlumnoToolStripMenuItem,
            this.ingresarApoderadoToolStripMenuItem,
            this.ingresarCursoToolStripMenuItem,
            this.toolStripSeparator1,
            this.listarAlumnosSegunApoderadoToolStripMenuItem,
            this.listadoAlumnosPorCursoToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.opcionesToolStripMenuItem.Text = "Ingresos";
            // 
            // ingresarAlumnoToolStripMenuItem
            // 
            this.ingresarAlumnoToolStripMenuItem.Name = "ingresarAlumnoToolStripMenuItem";
            this.ingresarAlumnoToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.ingresarAlumnoToolStripMenuItem.Text = "Ingresar Alumno";
            this.ingresarAlumnoToolStripMenuItem.Click += new System.EventHandler(this.ingresarAlumnoToolStripMenuItem_Click);
            // 
            // listarAlumnosSegunApoderadoToolStripMenuItem
            // 
            this.listarAlumnosSegunApoderadoToolStripMenuItem.Name = "listarAlumnosSegunApoderadoToolStripMenuItem";
            this.listarAlumnosSegunApoderadoToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.listarAlumnosSegunApoderadoToolStripMenuItem.Text = "Listado Alumnos por Apoderado";
            this.listarAlumnosSegunApoderadoToolStripMenuItem.Click += new System.EventHandler(this.listarAlumnosSegunApoderadoToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ingresarApoderadoToolStripMenuItem
            // 
            this.ingresarApoderadoToolStripMenuItem.Name = "ingresarApoderadoToolStripMenuItem";
            this.ingresarApoderadoToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.ingresarApoderadoToolStripMenuItem.Text = "Ingresar Apoderado";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(284, 6);
            // 
            // matriculaToolStripMenuItem
            // 
            this.matriculaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnosSegunCursoToolStripMenuItem});
            this.matriculaToolStripMenuItem.Name = "matriculaToolStripMenuItem";
            this.matriculaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.matriculaToolStripMenuItem.Text = "Matricula";
            // 
            // alumnosSegunCursoToolStripMenuItem
            // 
            this.alumnosSegunCursoToolStripMenuItem.Name = "alumnosSegunCursoToolStripMenuItem";
            this.alumnosSegunCursoToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.alumnosSegunCursoToolStripMenuItem.Text = "Carpeta de Cursos";
            // 
            // ingresarCursoToolStripMenuItem
            // 
            this.ingresarCursoToolStripMenuItem.Name = "ingresarCursoToolStripMenuItem";
            this.ingresarCursoToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.ingresarCursoToolStripMenuItem.Text = "Administrar Carpetas (Curso/asignatura)";
            // 
            // listadoAlumnosPorCursoToolStripMenuItem
            // 
            this.listadoAlumnosPorCursoToolStripMenuItem.Name = "listadoAlumnosPorCursoToolStripMenuItem";
            this.listadoAlumnosPorCursoToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.listadoAlumnosPorCursoToolStripMenuItem.Text = "Listado Alumnos por Curso";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 480);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Homecs";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarAlumnosSegunApoderadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarApoderadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem listadoAlumnosPorCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matriculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosSegunCursoToolStripMenuItem;
    }
}