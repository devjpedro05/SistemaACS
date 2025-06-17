// =================================================================================
// PROJETO: Sistema de Agentes Comunitários de Saúde (ACS) - Windows Forms
// ARQUIVO: Models/Familia.cs
// DESCRIÇÃO: Classe que representa a entidade Família.
// =================================================================================
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaACS.Models
{
    [Table("Familias")]
    public class Familia
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(255)]
        public string? NomeReferencia { get; set; }

        [Required]
        public int EnderecoId { get; set; } // Chave Estrangeira para Endereco

        [ForeignKey("EnderecoId")]
        public virtual Endereco Endereco { get; set; } // Propriedade de navegação

        public DateTime DataCadastro { get; set; }

        // Propriedade de navegação para os Pacientes que pertencem a esta família
        public virtual ICollection<Paciente> Pacientes { get; set; }

        public Familia()
        {
            // Inicializa a coleção para evitar erros de referência nula
            Pacientes = new HashSet<Paciente>();
            DataCadastro = DateTime.Now;
        }
    }
}
