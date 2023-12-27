
namespace obligatorio.Presentacion
{
    partial class frmCursos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.lstDocentes = new System.Windows.Forms.ListBox();
            this.lstDocentesDelCurso = new System.Windows.Forms.ListBox();
            this.btnAgregarDocente = new System.Windows.Forms.Button();
            this.btnEliminarDocente = new System.Windows.Forms.Button();
            this.lstEstudiantes = new System.Windows.Forms.ListBox();
            this.lstEstudiantesDelCurso = new System.Windows.Forms.ListBox();
            this.btnAgregarEstudiante = new System.Windows.Forms.Button();
            this.btnEliminarEstudiante = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblMensajes = new System.Windows.Forms.Label();
            this.lstCursos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(176, 36);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Especialidad";
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Location = new System.Drawing.Point(176, 76);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Size = new System.Drawing.Size(100, 20);
            this.txtEspecialidad.TabIndex = 3;
            // 
            // lstDocentes
            // 
            this.lstDocentes.FormattingEnabled = true;
            this.lstDocentes.Location = new System.Drawing.Point(176, 126);
            this.lstDocentes.Name = "lstDocentes";
            this.lstDocentes.Size = new System.Drawing.Size(122, 69);
            this.lstDocentes.TabIndex = 4;
            // 
            // lstDocentesDelCurso
            // 
            this.lstDocentesDelCurso.FormattingEnabled = true;
            this.lstDocentesDelCurso.Location = new System.Drawing.Point(57, 126);
            this.lstDocentesDelCurso.Name = "lstDocentesDelCurso";
            this.lstDocentesDelCurso.Size = new System.Drawing.Size(113, 69);
            this.lstDocentesDelCurso.TabIndex = 5;
            // 
            // btnAgregarDocente
            // 
            this.btnAgregarDocente.Location = new System.Drawing.Point(317, 126);
            this.btnAgregarDocente.Name = "btnAgregarDocente";
            this.btnAgregarDocente.Size = new System.Drawing.Size(107, 23);
            this.btnAgregarDocente.TabIndex = 6;
            this.btnAgregarDocente.Text = "Agregar Docente";
            this.btnAgregarDocente.UseVisualStyleBackColor = true;
            this.btnAgregarDocente.Click += new System.EventHandler(this.btnAgregarDocente_Click);
            // 
            // btnEliminarDocente
            // 
            this.btnEliminarDocente.Location = new System.Drawing.Point(317, 172);
            this.btnEliminarDocente.Name = "btnEliminarDocente";
            this.btnEliminarDocente.Size = new System.Drawing.Size(107, 23);
            this.btnEliminarDocente.TabIndex = 7;
            this.btnEliminarDocente.Text = "Eliminar Docente";
            this.btnEliminarDocente.UseVisualStyleBackColor = true;
            this.btnEliminarDocente.Click += new System.EventHandler(this.btnEliminarDocente_Click);
            // 
            // lstEstudiantes
            // 
            this.lstEstudiantes.FormattingEnabled = true;
            this.lstEstudiantes.Location = new System.Drawing.Point(176, 211);
            this.lstEstudiantes.Name = "lstEstudiantes";
            this.lstEstudiantes.Size = new System.Drawing.Size(122, 82);
            this.lstEstudiantes.TabIndex = 8;
            // 
            // lstEstudiantesDelCurso
            // 
            this.lstEstudiantesDelCurso.FormattingEnabled = true;
            this.lstEstudiantesDelCurso.Location = new System.Drawing.Point(57, 211);
            this.lstEstudiantesDelCurso.Name = "lstEstudiantesDelCurso";
            this.lstEstudiantesDelCurso.Size = new System.Drawing.Size(113, 82);
            this.lstEstudiantesDelCurso.TabIndex = 9;
            // 
            // btnAgregarEstudiante
            // 
            this.btnAgregarEstudiante.Location = new System.Drawing.Point(317, 220);
            this.btnAgregarEstudiante.Name = "btnAgregarEstudiante";
            this.btnAgregarEstudiante.Size = new System.Drawing.Size(107, 23);
            this.btnAgregarEstudiante.TabIndex = 10;
            this.btnAgregarEstudiante.Text = "Agregar Estudiante";
            this.btnAgregarEstudiante.UseVisualStyleBackColor = true;
            this.btnAgregarEstudiante.Click += new System.EventHandler(this.btnAgregarEstudiante_Click);
            // 
            // btnEliminarEstudiante
            // 
            this.btnEliminarEstudiante.Location = new System.Drawing.Point(317, 270);
            this.btnEliminarEstudiante.Name = "btnEliminarEstudiante";
            this.btnEliminarEstudiante.Size = new System.Drawing.Size(107, 23);
            this.btnEliminarEstudiante.TabIndex = 11;
            this.btnEliminarEstudiante.Text = "Eliminar Estudiante";
            this.btnEliminarEstudiante.UseVisualStyleBackColor = true;
            this.btnEliminarEstudiante.Click += new System.EventHandler(this.btnEliminarEstudiante_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(468, 32);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(153, 45);
            this.btnAlta.TabIndex = 12;
            this.btnAlta.Text = "ALTA";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(468, 126);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(153, 52);
            this.btnBaja.TabIndex = 13;
            this.btnBaja.Text = "BAJA";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(468, 220);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(153, 56);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblMensajes
            // 
            this.lblMensajes.AutoSize = true;
            this.lblMensajes.Location = new System.Drawing.Point(57, 310);
            this.lblMensajes.Name = "lblMensajes";
            this.lblMensajes.Size = new System.Drawing.Size(10, 13);
            this.lblMensajes.TabIndex = 15;
            this.lblMensajes.Text = ".";
            // 
            // lstCursos
            // 
            this.lstCursos.FormattingEnabled = true;
            this.lstCursos.Location = new System.Drawing.Point(60, 341);
            this.lstCursos.Name = "lstCursos";
            this.lstCursos.Size = new System.Drawing.Size(561, 95);
            this.lstCursos.TabIndex = 16;
            this.lstCursos.SelectedIndexChanged += new System.EventHandler(this.lstCursos_SelectedIndexChanged);
            // 
            // frmCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstCursos);
            this.Controls.Add(this.lblMensajes);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.btnEliminarEstudiante);
            this.Controls.Add(this.btnAgregarEstudiante);
            this.Controls.Add(this.lstEstudiantesDelCurso);
            this.Controls.Add(this.lstEstudiantes);
            this.Controls.Add(this.btnEliminarDocente);
            this.Controls.Add(this.btnAgregarDocente);
            this.Controls.Add(this.lstDocentesDelCurso);
            this.Controls.Add(this.lstDocentes);
            this.Controls.Add(this.txtEspecialidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Name = "frmCursos";
            this.Text = "frmCursos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.ListBox lstDocentes;
        private System.Windows.Forms.ListBox lstDocentesDelCurso;
        private System.Windows.Forms.Button btnAgregarDocente;
        private System.Windows.Forms.Button btnEliminarDocente;
        private System.Windows.Forms.ListBox lstEstudiantes;
        private System.Windows.Forms.ListBox lstEstudiantesDelCurso;
        private System.Windows.Forms.Button btnAgregarEstudiante;
        private System.Windows.Forms.Button btnEliminarEstudiante;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblMensajes;
        private System.Windows.Forms.ListBox lstCursos;
    }
}