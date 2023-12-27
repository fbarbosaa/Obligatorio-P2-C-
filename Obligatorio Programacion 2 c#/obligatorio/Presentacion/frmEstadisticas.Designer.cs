
namespace obligatorio.Presentacion
{
    partial class frmEstadisticas
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
            this.lstEstudiantes = new System.Windows.Forms.ListBox();
            this.rdbEstudiantesOrdenados = new System.Windows.Forms.RadioButton();
            this.rdbEstudiantesOrdenOriginal = new System.Windows.Forms.RadioButton();
            this.btnCurso = new System.Windows.Forms.Button();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lstCursos = new System.Windows.Forms.ListBox();
            this.rdbCursosOrdenados = new System.Windows.Forms.RadioButton();
            this.rdbCursosOrdenOriginal = new System.Windows.Forms.RadioButton();
            this.btnMostrarEstudiantes = new System.Windows.Forms.Button();
            this.lblEstudiantes = new System.Windows.Forms.Label();
            this.lstCursosDelEstudiante = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstEstudiantes
            // 
            this.lstEstudiantes.FormattingEnabled = true;
            this.lstEstudiantes.Location = new System.Drawing.Point(52, 47);
            this.lstEstudiantes.Name = "lstEstudiantes";
            this.lstEstudiantes.Size = new System.Drawing.Size(151, 121);
            this.lstEstudiantes.TabIndex = 0;
            // 
            // rdbEstudiantesOrdenados
            // 
            this.rdbEstudiantesOrdenados.AutoSize = true;
            this.rdbEstudiantesOrdenados.Location = new System.Drawing.Point(229, 47);
            this.rdbEstudiantesOrdenados.Name = "rdbEstudiantesOrdenados";
            this.rdbEstudiantesOrdenados.Size = new System.Drawing.Size(214, 17);
            this.rdbEstudiantesOrdenados.TabIndex = 1;
            this.rdbEstudiantesOrdenados.TabStop = true;
            this.rdbEstudiantesOrdenados.Text = "Estudiantes Ordenados Alfabeticamente";
            this.rdbEstudiantesOrdenados.UseVisualStyleBackColor = true;
            this.rdbEstudiantesOrdenados.CheckedChanged += new System.EventHandler(this.rdbEstudiantesOrdenados_CheckedChanged);
            // 
            // rdbEstudiantesOrdenOriginal
            // 
            this.rdbEstudiantesOrdenOriginal.AutoSize = true;
            this.rdbEstudiantesOrdenOriginal.Location = new System.Drawing.Point(229, 88);
            this.rdbEstudiantesOrdenOriginal.Name = "rdbEstudiantesOrdenOriginal";
            this.rdbEstudiantesOrdenOriginal.Size = new System.Drawing.Size(150, 17);
            this.rdbEstudiantesOrdenOriginal.TabIndex = 2;
            this.rdbEstudiantesOrdenOriginal.TabStop = true;
            this.rdbEstudiantesOrdenOriginal.Text = "Estudiantes Orden Original";
            this.rdbEstudiantesOrdenOriginal.UseVisualStyleBackColor = true;
            this.rdbEstudiantesOrdenOriginal.CheckedChanged += new System.EventHandler(this.rdbEstudiantesOrdenOriginal_CheckedChanged);
            // 
            // btnCurso
            // 
            this.btnCurso.Location = new System.Drawing.Point(229, 145);
            this.btnCurso.Name = "btnCurso";
            this.btnCurso.Size = new System.Drawing.Size(88, 23);
            this.btnCurso.TabIndex = 3;
            this.btnCurso.Text = "Mostrar Curso";
            this.btnCurso.UseVisualStyleBackColor = true;
            this.btnCurso.Click += new System.EventHandler(this.btnCurso_Click);
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(382, 150);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(10, 13);
            this.lblCurso.TabIndex = 4;
            this.lblCurso.Text = ".";
            // 
            // lstCursos
            // 
            this.lstCursos.FormattingEnabled = true;
            this.lstCursos.Location = new System.Drawing.Point(52, 224);
            this.lstCursos.Name = "lstCursos";
            this.lstCursos.Size = new System.Drawing.Size(151, 134);
            this.lstCursos.TabIndex = 5;
            // 
            // rdbCursosOrdenados
            // 
            this.rdbCursosOrdenados.AutoSize = true;
            this.rdbCursosOrdenados.Location = new System.Drawing.Point(229, 240);
            this.rdbCursosOrdenados.Name = "rdbCursosOrdenados";
            this.rdbCursosOrdenados.Size = new System.Drawing.Size(191, 17);
            this.rdbCursosOrdenados.TabIndex = 6;
            this.rdbCursosOrdenados.TabStop = true;
            this.rdbCursosOrdenados.Text = "Cursos Ordenados Alfabeticamente";
            this.rdbCursosOrdenados.UseVisualStyleBackColor = true;
            this.rdbCursosOrdenados.CheckedChanged += new System.EventHandler(this.rdbCursosOrdenados_CheckedChanged);
            // 
            // rdbCursosOrdenOriginal
            // 
            this.rdbCursosOrdenOriginal.AutoSize = true;
            this.rdbCursosOrdenOriginal.Location = new System.Drawing.Point(229, 290);
            this.rdbCursosOrdenOriginal.Name = "rdbCursosOrdenOriginal";
            this.rdbCursosOrdenOriginal.Size = new System.Drawing.Size(127, 17);
            this.rdbCursosOrdenOriginal.TabIndex = 7;
            this.rdbCursosOrdenOriginal.TabStop = true;
            this.rdbCursosOrdenOriginal.Text = "Cursos Orden Original";
            this.rdbCursosOrdenOriginal.UseVisualStyleBackColor = true;
            this.rdbCursosOrdenOriginal.CheckedChanged += new System.EventHandler(this.rdbCursosOrdenOriginal_CheckedChanged);
            // 
            // btnMostrarEstudiantes
            // 
            this.btnMostrarEstudiantes.Location = new System.Drawing.Point(229, 334);
            this.btnMostrarEstudiantes.Name = "btnMostrarEstudiantes";
            this.btnMostrarEstudiantes.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarEstudiantes.TabIndex = 8;
            this.btnMostrarEstudiantes.Text = "Mostrar Estudiantes";
            this.btnMostrarEstudiantes.UseVisualStyleBackColor = true;
            this.btnMostrarEstudiantes.Click += new System.EventHandler(this.btnMostrarEstudiantes_Click);
            // 
            // lblEstudiantes
            // 
            this.lblEstudiantes.AutoSize = true;
            this.lblEstudiantes.Location = new System.Drawing.Point(385, 344);
            this.lblEstudiantes.Name = "lblEstudiantes";
            this.lblEstudiantes.Size = new System.Drawing.Size(10, 13);
            this.lblEstudiantes.TabIndex = 9;
            this.lblEstudiantes.Text = ".";
            // 
            // lstCursosDelEstudiante
            // 
            this.lstCursosDelEstudiante.FormattingEnabled = true;
            this.lstCursosDelEstudiante.Location = new System.Drawing.Point(579, 47);
            this.lstCursosDelEstudiante.Name = "lstCursosDelEstudiante";
            this.lstCursosDelEstudiante.Size = new System.Drawing.Size(120, 95);
            this.lstCursosDelEstudiante.TabIndex = 10;
            // 
            // frmEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstCursosDelEstudiante);
            this.Controls.Add(this.lblEstudiantes);
            this.Controls.Add(this.btnMostrarEstudiantes);
            this.Controls.Add(this.rdbCursosOrdenOriginal);
            this.Controls.Add(this.rdbCursosOrdenados);
            this.Controls.Add(this.lstCursos);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.btnCurso);
            this.Controls.Add(this.rdbEstudiantesOrdenOriginal);
            this.Controls.Add(this.rdbEstudiantesOrdenados);
            this.Controls.Add(this.lstEstudiantes);
            this.Name = "frmEstadisticas";
            this.Text = "frmEstadisticas";
            this.Load += new System.EventHandler(this.frmEstadisticas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstEstudiantes;
        private System.Windows.Forms.RadioButton rdbEstudiantesOrdenados;
        private System.Windows.Forms.RadioButton rdbEstudiantesOrdenOriginal;
        private System.Windows.Forms.Button btnCurso;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.ListBox lstCursos;
        private System.Windows.Forms.RadioButton rdbCursosOrdenados;
        private System.Windows.Forms.RadioButton rdbCursosOrdenOriginal;
        private System.Windows.Forms.Button btnMostrarEstudiantes;
        private System.Windows.Forms.Label lblEstudiantes;
        private System.Windows.Forms.ListBox lstCursosDelEstudiante;
    }
}