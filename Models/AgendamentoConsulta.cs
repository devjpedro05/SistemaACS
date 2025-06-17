// =================================================================================
// PROJETO: Sistema de Agentes Comunitários de Saúde (ACS) - Windows Forms
// ARQUIVO: Models/Agendamento.cs
// DESCRIÇÃO: Classe que representa a entidade Agendamento.
// =================================================================================
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

    namespace SistemaACS.Models
    {
        [Table("Agendamentos")]
        public class Agendamento
        {
            [Key]
            public int Id { get; set; }

            [Required]
            public int PacienteId { get; set; } // Chave Estrangeira

            [ForeignKey("PacienteId")]
            public virtual Paciente Paciente { get; set; }

            [Required]
            public DateTime DataHora { get; set; }

            [Required]
            [MaxLength(500)]
            public string Descricao { get; set; } // Motivo do agendamento

            [Required]
            [MaxLength(50)]
            public string Status { get; set; } // Ex: "Agendado", "Realizado", "Cancelado"

            public Agendamento()
            {
                Status = "Agendado"; // Valor padrão ao criar um novo agendamento
            }
        }
    }
