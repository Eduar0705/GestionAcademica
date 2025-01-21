using System;

namespace WF_Examen
{
	public class Curso
	{
		private String codigoCurso;
        private String instructor;
        private String titulo;
        private String tipoCurso;
        private Int32 cantHoras;
        private DateTime fechaInicio;
        private DateTime fechafinal;
        private Int32 cantEstudiantes;
        private Boolean cursoActivo;

        public String CodigoCurso { get { return codigoCurso; } set { codigoCurso = value; } }
        public String Instructor { get { return instructor; } set { instructor = value; } }
        public String Titulo { get { return titulo; } set { titulo = value; } }
        public String TipoCurso { get { return tipoCurso; } set { tipoCurso = value; } }
        public Int32 CantHoras { get { return cantHoras; } set { cantHoras = value; } }
        public DateTime FechaInicio { get { return fechaInicio; } set { fechaInicio = value; } }
        public DateTime FechaFinal { get { return fechafinal; } set { fechafinal = value; } }
        public Int32 CantEstudiantes { get { return cantEstudiantes; } set { cantEstudiantes = value; } }
        public Boolean CursoActivo { get { return cursoActivo; } set { cursoActivo = value; } }

		public Curso()
		{
			
		}
	}
}
