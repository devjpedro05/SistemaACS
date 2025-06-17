// =================================================================================
// PROJETO: Sistema de Agentes Comunitários de Saúde (ACS) - Windows Forms
// ARQUIVO: FormCadastroAgendamento.cs
// DESCRIÇÃO: Formulário para registar um novo agendamento para um paciente.
// =================================================================================
using SistemaACS.Data;
using SistemaACS.Models;
using System.Windows.Forms;

namespace SistemaACS
{
    public partial class FormCadastroAgendamento : Form
    {
        private readonly int _pacienteId;
        private AppDbContext _context;

        public FormCadastroAgendamento(int pacienteId)
        {
            InitializeComponent();
            _pacienteId = pacienteId;
            _context = new AppDbContext();

            // ALTERAÇÃO: Preenche o nome do paciente no título do formulário
            var paciente = _context.Pacientes.Find(pacienteId);
            if (paciente != null)
            {
                this.Text = $"Novo Agendamento para: {paciente.NomeCompleto}";
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                MessageBox.Show("A descrição é obrigatória.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var agendamento = new Agendamento
                {
                    PacienteId = _pacienteId,
                    DataHora = dtpDataHora.Value,
                    Descricao = txtDescricao.Text,
                    Status = "Agendado" // Status inicial
                };

                _context.Agendamentos.Add(agendamento);
                _context.SaveChanges();

                MessageBox.Show("Agendamento guardado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao guardar o agendamento: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
