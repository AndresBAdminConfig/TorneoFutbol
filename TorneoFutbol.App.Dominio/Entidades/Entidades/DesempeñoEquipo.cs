using System;
using System.ComponentModel.DataAnnotations;

namespace TorneoFutbol.App.Dominio
{
    public class DesempeñoEquipo
    {
        // Identificador único de cada persona
        public int  Id  { get; set; }
        [Required(ErrorMessage = "Los Datos Son Obligatorios")]
        [StringLength(5, ErrorMessage = "Maximo 5 Caracteres")]
        [Display(Name= "Partidos Jugados")]
        public int Cantidad_Partidos_Jugados { get; set; }
        [Required(ErrorMessage = "Los Datos Son Obligatorios")]
        [StringLength(5, ErrorMessage = "Maximo 5 Caracteres")]
        [Display(Name= "Partidos Ganados")]
        public int Cantidad_Partidos_Ganados { get; set; }
        [Required(ErrorMessage = "Los Datos Son Obligatorios")]
        [StringLength(5, ErrorMessage = "Maximo 5 Caracteres")]
        [Display(Name= "Partidos Empatados")]
        public int Cantidad_Partidos_Empatados { get; set; }
        [Required(ErrorMessage = "Los Datos Son Obligatorios")]
        [StringLength(5, ErrorMessage = "Maximo 10 Caracteres")]
        public int GF { get; set; }
        [Required(ErrorMessage = "Los Datos Son Obligatorios")]
        [StringLength(5, ErrorMessage = "Maximo 10 Caracteres")]
        public int GC { get; set; }
        [Required(ErrorMessage = "Los Datos Son Obligatorios")]
        [StringLength(5, ErrorMessage = "Maximo 10 Caracteres")]
        public int Puntos { get; set; }
                
    }
}