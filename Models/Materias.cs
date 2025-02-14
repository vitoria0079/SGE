using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SGE.Models
{
    [Table("Materias")]
    public class Materias
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }


        [Column("Titulo")]
        [Display(Name = "Titulo")]
        public string Titulo { get; set; } = string.Empty;


        [ForeignKey("ProfessoresId")]
        [Display(Name = "Professores")]
        public int ProfessoresId { get; set; }
        public Professores? Professores { get; set; }
    }
}
