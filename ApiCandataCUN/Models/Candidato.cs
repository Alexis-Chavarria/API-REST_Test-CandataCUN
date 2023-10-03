namespace ApiCandataCUN.Models
{
    public class Candidato
    {
        public string id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string numero { get; set; }

        public Candidato(string id, string nombre, string apelldio, string numero) 
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apelldio;
            this.numero = numero;      
        }
        /*
        public string id { get; set; }
        public string tipo_Documento { get; set; }
        public string num_Documento_Estudiante { get; set; }
        public string cedula_Ciudadania { get; set; }
        public string observacion_Cedula_Ciudadania { get; set; }
        public string diploma_Bachiller { get; set; }
        public string observaciones_Diploma_Bachiller { get; set; }
        public string acta_Bachiller { get; set; }
        public string observaciones_Acta_Bachiller { get; set; }
        public string examen_Icfes_11 { get; set; }
        public string observaciones_Examen_Icfes_11 { get; set; }
        public string diploma_Tecnico { get; set; }
        public string observaciones_Diploma_Tecnico { get; set; }
        public string acta_Tecnico { get; set; }
        public string observaciones_Acta_Tecnico { get; set; }
        public string resultado_TyT_Tecnico { get; set; }
        public string observaciones_Resultado_TyT_Tecnico { get; set; }
        public string observaciones_Diploma_Tecnologo { get; set; }
        public string acta_Tecnologo { get; set; }
        public string observaciones_Acta_Tecnologo { get; set; }
        public string resultado_TyT_Tecnologo { get; set; }
        public string observaciones_Resultado_TyT_Tecnologo { get; set; }
        public string diploma_Profesional { get; set; }
        public string observaciones_Diploma_Profesional { get; set; }
        public string acta_Profesional { get; set; }
        public string observaciones_Acta_Profesional { get; set; }
        public string resultado_Saber_Pro { get; set; }
        public string observaciones_Resultado_Saber_Pro { get; set; }
        public string estado_Final_estudiante { get; set; }
        public string fecha_Revision_Bot { get; set; }
        */

    }
}
