// =================================================================================
// PROJETO: Sistema de Agentes Comunitários de Saúde (ACS) - Windows Forms
// ARQUIVO: Models/Paciente.cs
// DESCRIÇÃO: Classe que representa a entidade Paciente.
// =================================================================================
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaACS.Models
{
    [Table("Pacientes")]
    public class Paciente
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string NomeCompleto { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }

        [Required]
        [MaxLength(11)]
        public string CPF { get; set; }

        [Required]
        [MaxLength(15)]
        public string CNS { get; set; }

        [Required]
        public int FamiliaId { get; set; } // Chave Estrangeira para Familia

        [ForeignKey("FamiliaId")]
        public virtual Familia Familia { get; set; } // Propriedade de navegação

        // Propriedade de navegação para os Agendamentos do paciente
        public virtual ICollection<Agendamento> Agendamentos { get; set; }

        public Paciente()
        {
            Agendamentos = new HashSet<Agendamento>();
        }
    }
}

