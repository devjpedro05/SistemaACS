// =================================================================================
// PROJETO: Sistema de Agentes Comunitários de Saúde (ACS) - Windows Forms
// ARQUIVO: Models/Endereco.cs
// DESCRIÇÃO: Classe que representa a entidade Endereço.
// =================================================================================
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaACS.Models
{
    [Table("Enderecos")]
    public class Endereco
    {
        [Key] // Define esta propriedade como a Chave Primária
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Logradouro { get; set; }

        [Required]
        [MaxLength(20)]
        public string Numero { get; set; }

        [MaxLength(100)]
        public string? Complemento { get; set; }

        [Required]
        [MaxLength(100)]
        public string Bairro { get; set; }

        [Required]
        [MaxLength(100)]
        public string Cidade { get; set; }

        [Required]
        [MaxLength(2)]
        public string UF { get; set; }

        [Required]
        [MaxLength(8)]
        public string CEP { get; set; }
    }
}