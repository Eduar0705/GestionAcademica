using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text.RegularExpressions;

namespace WF_Examen
{
	public partial class MainForm : Form
	{
		private List<Curso> Lista_Curso = new List<Curso>();
		
		public MainForm()
		{
			InitializeComponent();
			this.FormBorderStyle = FormBorderStyle.FixedSingle; // No redimensionable
            this.MaximizeBox = false; // No maximizable
            this.MinimizeBox = false; // No minimizable
            CM_Tipo.Items.AddRange(new string[] { "Presencial", "Semipresencial", "Virtual" });
            
            BT_Refrescar.Click += delegate {
            	
                BT_Agregar.Enabled = true;
                BT_Actualizar.Enabled = false;
                BT_Buscar.Enabled = true;
                BT_Eliminar.Enabled = true;
                TXT_Codigo.Text = "";
                TXT_Profesor.Text = "";
                TXT_Titulo.Text = "";
                CM_Tipo.Text = "";
                N_Horas.Value = N_Horas.Minimum;
                N_Estudiantes.Value = N_Estudiantes.Minimum;
                FH_Inicio.Value = DateTime.Now;
                FH_Final.Value = DateTime.Now;
               
                RD_SI.Checked = false;
                RD_NO.Checked = false;
                
                TXT_Codigo.Focus();
            };
		}
private bool ValidarCodigo(string codigo)
       {
    string patron = @"^[A-Z]{2}-\d{2}$";
    return Regex.IsMatch(codigo, patron);
}
		
		void BT_AgregarClick(object sender, EventArgs e)
		{
			string codigoCurso = TXT_Codigo.Text;

    if (!ValidarCodigo(codigoCurso))
    {
        MessageBox.Show("El código debe tener el formato: AA-99 (dos letras mayúsculas, un guion y dos números).", "Error de Validación");
        return; // Salir del método si la validación falla
    }
			
			if (string.IsNullOrWhiteSpace(TXT_Codigo.Text) || string.IsNullOrWhiteSpace(TXT_Profesor.Text) ||
			    string.IsNullOrWhiteSpace(TXT_Titulo.Text) ||CM_Tipo.SelectedItem == null || N_Horas.Value < 20 || N_Horas.Value > 80 || 
                N_Estudiantes.Value < 4 ||N_Estudiantes.Value > 10 || FH_Inicio.Value >= FH_Final.Value) 
            {
                MessageBox.Show("ERROR X_X, Debe llenar todos los datos del registro","Mensaje");
                return;
            }

           
            if (Lista_Curso.Any(c => c.CodigoCurso == TXT_Codigo.Text && c.CursoActivo))
            {
                MessageBox.Show("ERROR x_x, ya esta registrado este codigo de curso","Mensaje");
               return;
            }

            Curso w = new Curso
            {
                CodigoCurso = TXT_Codigo.Text,
                Instructor = TXT_Profesor.Text,
                Titulo = TXT_Titulo.Text,
                TipoCurso = CM_Tipo.SelectedItem.ToString(),
                CantHoras = (int)N_Horas.Value,
                FechaInicio = FH_Inicio.Value,
                FechaFinal = FH_Final.Value,
                CantEstudiantes = (int)N_Estudiantes.Value,
                CursoActivo = RD_SI.Checked
            };
            Lista_Curso.Add(w);
            MessageBox.Show("Proseso registrado Exitosamente","Mensaje");
		}
		void BT_BuscarClick(object sender, EventArgs e)
		{
			var curso = Lista_Curso.FirstOrDefault(c => c.CodigoCurso == TXT_Codigo.Text && c.CursoActivo);
            if (curso != null)
            {
                TXT_Profesor.Text = curso.Instructor;
                TXT_Titulo.Text = curso.Titulo;
                CM_Tipo.SelectedItem = curso.TipoCurso;
                N_Horas.Value = curso.CantHoras;
                FH_Inicio.Value = curso.FechaInicio;
                FH_Final.Value = curso.FechaFinal;
                N_Estudiantes.Value = curso.CantEstudiantes;
                RD_SI.Checked = curso.CursoActivo;
            }
            else
            {
                MessageBox.Show("ERROR, Curso no encontrado.","Mensaje");
                return;
            }
		}
		void BT_ActualizarClick(object sender, EventArgs e)
		{
			var curso = Lista_Curso.FirstOrDefault(c => c.CodigoCurso == TXT_Codigo.Text && c.CursoActivo);
            if (curso != null)
            {
                
                if (string.IsNullOrWhiteSpace(TXT_Profesor.Text) || string.IsNullOrWhiteSpace(TXT_Titulo.Text) || 
                    CM_Tipo.SelectedItem == null || N_Horas.Value < 20 || N_Horas.Value > 80 || 
                    N_Estudiantes.Value < 4 || N_Estudiantes.Value > 10 || FH_Inicio.Value >= FH_Final.Value)
                {
                    MessageBox.Show("ERROR, Complete todos los datos correctamente.","Mensaje");
                    return;
                }
                curso.Instructor = TXT_Profesor.Text;
                curso.Titulo = TXT_Titulo.Text;
                curso.TipoCurso = CM_Tipo.SelectedItem.ToString();
                curso.CantHoras = (int)N_Horas.Value;
                curso.FechaInicio = FH_Inicio.Value;
                curso.FechaFinal = FH_Final.Value;
                curso.CantEstudiantes = (int)N_Estudiantes.Value;
                curso.CursoActivo = RD_SI.Checked;

                MessageBox.Show("Actualizado exitosamente <3......","Mensaje");
            }
            else
            {
                MessageBox.Show("ERROR, Curso no encontrado. X_X","Mensaje");
            }
		}
		void BT_EliminarClick(object sender, EventArgs e)
		{
			var curso = Lista_Curso.FirstOrDefault(c => c.CodigoCurso == TXT_Codigo.Text);
            if (curso != null)
            {
                var confirmResult = MessageBox.Show("¿Deseas Borrar este curso?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    
                    MessageBox.Show("Curso eliminado exitosamente. <3........","Mensaje");
                    
                }
            }
            else
            {
                MessageBox.Show("ERROR,Curso no encontrado. X_X","Mensaje");
			}
		}
		
		
		
	}
}
