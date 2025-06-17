// =================================================================================
// PROJETO: Sistema de Agentes Comunitários de Saúde (ACS) - Windows Forms
// ARQUIVO: FormCadastroPaciente.cs
// DESCRIÇÃO: Formulário para registar um novo paciente numa família.
// =================================================================================
using SistemaACS.Data;
using SistemaACS.Models;

namespace SistemaACS
{
    public partial class FormCadastroPaciente : Form
    {
        private readonly int _familiaId;
        private AppDbContext _context;

        public FormCadastroPaciente(int familiaId)
        {
            InitializeComponent();
            _familiaId = familiaId;
            _context = new AppDbContext();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var paciente = new Paciente
                {
                    NomeCompleto = txtNomeCompleto.Text,
                    DataNascimento = dtpDataNascimento.Value,
                    CPF = txtCPF.Text,
                    CNS = txtCNS.Text,
                    FamiliaId = _familiaId // Associa o paciente à família correta
                };

                _context.Pacientes.Add(paciente);
                _context.SaveChanges();

                MessageBox.Show("Paciente guardado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao guardar o paciente: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}