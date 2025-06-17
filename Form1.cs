// =================================================================================
// PROJETO: Sistema de Agentes Comunitários de Saúde (ACS) - Windows Forms
// ARQUIVO: Form1.cs
// DESCRIÇÃO: Formulário principal da aplicação. Exibe famílias, pacientes e agendamentos.
// =================================================================================
using Microsoft.EntityFrameworkCore;
using SistemaACS.Data;
using SistemaACS.Models;
using System.Windows.Forms;

namespace SistemaACS
{
    public partial class Form1 : Form
    {
        private AppDbContext _context;

        public Form1()
        {
            InitializeComponent();
            _context = new AppDbContext();
            CarregarFamilias();
        }

        private void CarregarFamilias()
        {
            // Limpa as grelhas para evitar dados antigos
            dataGridViewFamilias.DataSource = null;
            dataGridViewPacientes.DataSource = null;
            dataGridViewAgendamentos.DataSource = null;

            var familias = _context.Familias
                                    .Include(f => f.Endereco)
                                    .Select(f => new
                                    {
                                        Id = f.Id,
                                        Nome = f.NomeReferencia,
                                        Logradouro = f.Endereco.Logradouro,
                                        Numero = f.Endereco.Numero,
                                        Bairro = f.Endereco.Bairro
                                    })
                                    .ToList();

            dataGridViewFamilias.DataSource = familias;
        }

        private void CarregarPacientes(int familiaId)
        {
            dataGridViewPacientes.DataSource = null;
            dataGridViewAgendamentos.DataSource = null;

            // ALTERAÇÃO: A consulta agora inclui o nome da família
            var pacientes = _context.Pacientes
                                    .Include(p => p.Familia) // Inclui o objeto Familia relacionado
                                    .Where(p => p.FamiliaId == familiaId)
                                    .Select(p => new {
                                        Id = p.Id,
                                        NomeCompleto = p.NomeCompleto,
                                        DataNascimento = p.DataNascimento,
                                        CPF = p.CPF,
                                        CNS = p.CNS,
                                        NomeFamilia = p.Familia.NomeReferencia // Seleciona o nome da família
                                    })
                                    .ToList();

            dataGridViewPacientes.DataSource = pacientes;
        }

        private void CarregarAgendamentos(int pacienteId)
        {
            dataGridViewAgendamentos.DataSource = null;

            // A consulta agora inclui o nome do paciente
            var agendamentos = _context.Agendamentos
                                        .Include(a => a.Paciente) // Inclui o objeto Paciente relacionado
                                        .Where(a => a.PacienteId == pacienteId)
                                        .OrderByDescending(a => a.DataHora)
                                        .Select(a => new {
                                            Id = a.Id,
                                            DataHora = a.DataHora,
                                            Descricao = a.Descricao,
                                            Status = a.Status,
                                            Paciente = a.Paciente.NomeCompleto // Seleciona o nome do paciente
                                        })
                                        .ToList();

            dataGridViewAgendamentos.DataSource = agendamentos;
        }

        private void dataGridViewFamilias_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewFamilias.CurrentRow != null && dataGridViewFamilias.CurrentRow.DataBoundItem != null)
            {
                var familiaId = (int)dataGridViewFamilias.CurrentRow.Cells["Id"].Value;
                CarregarPacientes(familiaId);
            }
        }

        private void dataGridViewPacientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewPacientes.CurrentRow != null && dataGridViewPacientes.CurrentRow.DataBoundItem != null)
            {
                var pacienteId = (int)dataGridViewPacientes.CurrentRow.Cells["Id"].Value;
                CarregarAgendamentos(pacienteId);
            }
        }

        private void btnAdicionarFamilia_Click(object sender, EventArgs e)
        {
            var formCadastro = new FormCadastroFamilia();
            if (formCadastro.ShowDialog() == DialogResult.OK)
            {
                CarregarFamilias();
            }
        }

        private void btnAdicionarPaciente_Click(object sender, EventArgs e)
        {
            if (dataGridViewFamilias.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecione uma família primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var familiaId = (int)dataGridViewFamilias.CurrentRow.Cells["Id"].Value;

            var formCadastro = new FormCadastroPaciente(familiaId);
            if (formCadastro.ShowDialog() == DialogResult.OK)
            {
                CarregarPacientes(familiaId);
            }
        }

        private void btnAdicionarAgendamento_Click(object sender, EventArgs e)
        {
            if (dataGridViewPacientes.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecione um paciente primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var pacienteId = (int)dataGridViewPacientes.CurrentRow.Cells["Id"].Value;

            var formCadastro = new FormCadastroAgendamento(pacienteId);
            if (formCadastro.ShowDialog() == DialogResult.OK)
            {
                CarregarAgendamentos(pacienteId);
            }
        }
    }
}
