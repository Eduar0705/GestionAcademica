/*
 * Creado por SharpDevelop.
 * Usuario: eduar
 * Fecha: 20/01/2025
 * Hora: 18:41
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace WF_Examen
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox TXT_Codigo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox TXT_Profesor;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox TXT_Titulo;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DateTimePicker FH_Inicio;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.DateTimePicker FH_Final;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.RadioButton RD_SI;
		private System.Windows.Forms.RadioButton RD_NO;
		private System.Windows.Forms.Button BT_Agregar;
		private System.Windows.Forms.Button BT_Buscar;
		private System.Windows.Forms.Button BT_Actualizar;
		private System.Windows.Forms.Button BT_Eliminar;
		private System.Windows.Forms.Button BT_Refrescar;
		private System.Windows.Forms.NumericUpDown N_Horas;
		private System.Windows.Forms.NumericUpDown N_Estudiantes;
		private System.Windows.Forms.ComboBox CM_Tipo;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.TXT_Codigo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.TXT_Profesor = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.TXT_Titulo = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.FH_Inicio = new System.Windows.Forms.DateTimePicker();
			this.label9 = new System.Windows.Forms.Label();
			this.FH_Final = new System.Windows.Forms.DateTimePicker();
			this.label10 = new System.Windows.Forms.Label();
			this.RD_SI = new System.Windows.Forms.RadioButton();
			this.RD_NO = new System.Windows.Forms.RadioButton();
			this.BT_Agregar = new System.Windows.Forms.Button();
			this.BT_Buscar = new System.Windows.Forms.Button();
			this.BT_Actualizar = new System.Windows.Forms.Button();
			this.BT_Eliminar = new System.Windows.Forms.Button();
			this.BT_Refrescar = new System.Windows.Forms.Button();
			this.N_Horas = new System.Windows.Forms.NumericUpDown();
			this.N_Estudiantes = new System.Windows.Forms.NumericUpDown();
			this.CM_Tipo = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.N_Horas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.N_Estudiantes)).BeginInit();
			this.SuspendLayout();
			// 
			// TXT_Codigo
			// 
			this.TXT_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TXT_Codigo.Location = new System.Drawing.Point(140, 118);
			this.TXT_Codigo.Margin = new System.Windows.Forms.Padding(2);
			this.TXT_Codigo.MaxLength = 5;
			this.TXT_Codigo.Name = "TXT_Codigo";
			this.TXT_Codigo.Size = new System.Drawing.Size(134, 26);
			this.TXT_Codigo.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(2, 121);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(135, 18);
			this.label1.TabIndex = 1;
			this.label1.Text = "Codigo del Curso:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(311, 22);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(307, 32);
			this.label2.TabIndex = 2;
			this.label2.Text = "SISTEMA ACADEMICO";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(292, 118);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(178, 18);
			this.label3.TabIndex = 3;
			this.label3.Text = "Nombre del Instructor(a):";
			// 
			// TXT_Profesor
			// 
			this.TXT_Profesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TXT_Profesor.Location = new System.Drawing.Point(470, 118);
			this.TXT_Profesor.Margin = new System.Windows.Forms.Padding(2);
			this.TXT_Profesor.Name = "TXT_Profesor";
			this.TXT_Profesor.Size = new System.Drawing.Size(134, 26);
			this.TXT_Profesor.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(627, 121);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(115, 18);
			this.label4.TabIndex = 5;
			this.label4.Text = "Titulo del curso:";
			// 
			// TXT_Titulo
			// 
			this.TXT_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TXT_Titulo.Location = new System.Drawing.Point(742, 118);
			this.TXT_Titulo.Margin = new System.Windows.Forms.Padding(2);
			this.TXT_Titulo.Name = "TXT_Titulo";
			this.TXT_Titulo.Size = new System.Drawing.Size(134, 26);
			this.TXT_Titulo.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(10, 197);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(110, 18);
			this.label5.TabIndex = 7;
			this.label5.Text = "Tipo de Curso:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(300, 193);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(125, 18);
			this.label6.TabIndex = 9;
			this.label6.Text = "Horas del Curso:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(495, 193);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(188, 18);
			this.label7.TabIndex = 11;
			this.label7.Text = "Cantidad de Estudiantes: ";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Transparent;
			this.label8.Location = new System.Drawing.Point(9, 274);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(96, 18);
			this.label8.TabIndex = 13;
			this.label8.Text = "Fecha Inicio:";
			// 
			// FH_Inicio
			// 
			this.FH_Inicio.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FH_Inicio.Location = new System.Drawing.Point(106, 272);
			this.FH_Inicio.Margin = new System.Windows.Forms.Padding(2);
			this.FH_Inicio.Name = "FH_Inicio";
			this.FH_Inicio.Size = new System.Drawing.Size(151, 23);
			this.FH_Inicio.TabIndex = 14;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(280, 275);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(94, 18);
			this.label9.TabIndex = 15;
			this.label9.Text = "Fecha Final:";
			// 
			// FH_Final
			// 
			this.FH_Final.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FH_Final.Location = new System.Drawing.Point(379, 275);
			this.FH_Final.Margin = new System.Windows.Forms.Padding(2);
			this.FH_Final.Name = "FH_Final";
			this.FH_Final.Size = new System.Drawing.Size(151, 23);
			this.FH_Final.TabIndex = 16;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(546, 279);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 18);
			this.label10.TabIndex = 17;
			this.label10.Text = "Curso Activo:";
			// 
			// RD_SI
			// 
			this.RD_SI.AutoSize = true;
			this.RD_SI.BackColor = System.Drawing.Color.Transparent;
			this.RD_SI.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RD_SI.ForeColor = System.Drawing.Color.Transparent;
			this.RD_SI.Location = new System.Drawing.Point(660, 279);
			this.RD_SI.Margin = new System.Windows.Forms.Padding(2);
			this.RD_SI.Name = "RD_SI";
			this.RD_SI.Size = new System.Drawing.Size(38, 20);
			this.RD_SI.TabIndex = 18;
			this.RD_SI.TabStop = true;
			this.RD_SI.Text = "Si";
			this.RD_SI.UseVisualStyleBackColor = false;
			// 
			// RD_NO
			// 
			this.RD_NO.AutoSize = true;
			this.RD_NO.BackColor = System.Drawing.Color.Transparent;
			this.RD_NO.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RD_NO.ForeColor = System.Drawing.Color.Transparent;
			this.RD_NO.Location = new System.Drawing.Point(708, 279);
			this.RD_NO.Margin = new System.Windows.Forms.Padding(2);
			this.RD_NO.Name = "RD_NO";
			this.RD_NO.Size = new System.Drawing.Size(43, 20);
			this.RD_NO.TabIndex = 19;
			this.RD_NO.TabStop = true;
			this.RD_NO.Text = "No";
			this.RD_NO.UseVisualStyleBackColor = false;
			// 
			// BT_Agregar
			// 
			this.BT_Agregar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BT_Agregar.Location = new System.Drawing.Point(72, 359);
			this.BT_Agregar.Margin = new System.Windows.Forms.Padding(2);
			this.BT_Agregar.Name = "BT_Agregar";
			this.BT_Agregar.Size = new System.Drawing.Size(117, 38);
			this.BT_Agregar.TabIndex = 21;
			this.BT_Agregar.Text = "REGISTRAR";
			this.BT_Agregar.UseVisualStyleBackColor = true;
			this.BT_Agregar.Click += new System.EventHandler(this.BT_AgregarClick);
			// 
			// BT_Buscar
			// 
			this.BT_Buscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BT_Buscar.Location = new System.Drawing.Point(231, 359);
			this.BT_Buscar.Margin = new System.Windows.Forms.Padding(2);
			this.BT_Buscar.Name = "BT_Buscar";
			this.BT_Buscar.Size = new System.Drawing.Size(120, 38);
			this.BT_Buscar.TabIndex = 22;
			this.BT_Buscar.Text = "CONSULTAR";
			this.BT_Buscar.UseVisualStyleBackColor = true;
			this.BT_Buscar.Click += new System.EventHandler(this.BT_BuscarClick);
			// 
			// BT_Actualizar
			// 
			this.BT_Actualizar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BT_Actualizar.Location = new System.Drawing.Point(390, 359);
			this.BT_Actualizar.Margin = new System.Windows.Forms.Padding(2);
			this.BT_Actualizar.Name = "BT_Actualizar";
			this.BT_Actualizar.Size = new System.Drawing.Size(124, 38);
			this.BT_Actualizar.TabIndex = 23;
			this.BT_Actualizar.Text = "ACTUALIZAR";
			this.BT_Actualizar.UseVisualStyleBackColor = true;
			this.BT_Actualizar.Click += new System.EventHandler(this.BT_ActualizarClick);
			// 
			// BT_Eliminar
			// 
			this.BT_Eliminar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BT_Eliminar.Location = new System.Drawing.Point(560, 359);
			this.BT_Eliminar.Margin = new System.Windows.Forms.Padding(2);
			this.BT_Eliminar.Name = "BT_Eliminar";
			this.BT_Eliminar.Size = new System.Drawing.Size(123, 38);
			this.BT_Eliminar.TabIndex = 24;
			this.BT_Eliminar.Text = "ELIMINAR";
			this.BT_Eliminar.UseVisualStyleBackColor = true;
			this.BT_Eliminar.Click += new System.EventHandler(this.BT_EliminarClick);
			// 
			// BT_Refrescar
			// 
			this.BT_Refrescar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BT_Refrescar.Location = new System.Drawing.Point(708, 359);
			this.BT_Refrescar.Margin = new System.Windows.Forms.Padding(2);
			this.BT_Refrescar.Name = "BT_Refrescar";
			this.BT_Refrescar.Size = new System.Drawing.Size(123, 38);
			this.BT_Refrescar.TabIndex = 25;
			this.BT_Refrescar.Text = "REINICIAR";
			this.BT_Refrescar.UseVisualStyleBackColor = true;
			// 
			// N_Horas
			// 
			this.N_Horas.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.N_Horas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.N_Horas.Location = new System.Drawing.Point(424, 190);
			this.N_Horas.Name = "N_Horas";
			this.N_Horas.Size = new System.Drawing.Size(45, 26);
			this.N_Horas.TabIndex = 26;
			// 
			// N_Estudiantes
			// 
			this.N_Estudiantes.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.N_Estudiantes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.N_Estudiantes.Location = new System.Drawing.Point(677, 190);
			this.N_Estudiantes.Name = "N_Estudiantes";
			this.N_Estudiantes.Size = new System.Drawing.Size(45, 26);
			this.N_Estudiantes.TabIndex = 27;
			// 
			// CM_Tipo
			// 
			this.CM_Tipo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CM_Tipo.FormattingEnabled = true;
			this.CM_Tipo.Location = new System.Drawing.Point(140, 194);
			this.CM_Tipo.Margin = new System.Windows.Forms.Padding(2);
			this.CM_Tipo.Name = "CM_Tipo";
			this.CM_Tipo.Size = new System.Drawing.Size(134, 24);
			this.CM_Tipo.TabIndex = 28;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(899, 434);
			this.Controls.Add(this.CM_Tipo);
			this.Controls.Add(this.N_Estudiantes);
			this.Controls.Add(this.N_Horas);
			this.Controls.Add(this.BT_Refrescar);
			this.Controls.Add(this.BT_Eliminar);
			this.Controls.Add(this.BT_Actualizar);
			this.Controls.Add(this.BT_Buscar);
			this.Controls.Add(this.BT_Agregar);
			this.Controls.Add(this.RD_NO);
			this.Controls.Add(this.RD_SI);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.FH_Final);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.FH_Inicio);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.TXT_Titulo);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.TXT_Profesor);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TXT_Codigo);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MainForm";
			this.Text = "Sistema Academico";
			((System.ComponentModel.ISupportInitialize)(this.N_Horas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.N_Estudiantes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
