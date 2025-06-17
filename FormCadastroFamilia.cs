// =================================================================================
// PROJETO: Sistema de Agentes Comunitários de Saúde (ACS) - Windows Forms
// ARQUIVO: FormCadastroFamilia.cs
// DESCRIÇÃO: Formulário para registar ou editar uma nova família e seu endereço.
// =================================================================================
using SistemaACS.Data;
using SistemaACS.Models;
using System.Text.Json;

namespace SistemaACS
{
    public partial class FormCadastroFamilia : Form
    {
        private AppDbContext _context;

        public FormCadastroFamilia()
        {
            InitializeComponent();
            _context = new AppDbContext();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Cria um novo objeto Endereco com os dados dos campos
                var endereco = new Endereco
                {
                    Logradouro = txtLogradouro.Text,
                    Numero = txtNumero.Text,
                    Complemento = txtComplemento.Text,
                    Bairro = txtBairro.Text,
                    Cidade = txtCidade.Text,
                    UF = txtUF.Text,
                    CEP = txtCEP.Text
                };

                // Cria um novo objeto Familia
                var familia = new Familia
                {
                    NomeReferencia = txtNomeFamilia.Text,
                    Endereco = endereco, // Associa o endereço à família
                    DataCadastro = DateTime.Now
                };

                // Adiciona a família (e seu endereço) ao contexto e salva no banco de dados
                _context.Familias.Add(familia);
                _context.SaveChanges();

                MessageBox.Show("Família guardada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao guardar a família: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buscarCEP_API_Click(object sender, EventArgs e)
        {
            string cep = txtCEP.Text.Replace("-", "").Replace(".", "").Trim();
            if (string.IsNullOrEmpty(cep) || cep.Length != 8)
            {
                MessageBox.Show("Por favor, insira um CEP válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await httpClient.GetAsync($"https://viacep.com.br/ws/{cep}/json/");

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        ApiCEPResponse endereco = JsonSerializer.Deserialize<ApiCEPResponse>(json);

                        if (endereco != null && endereco.erro != "true")
                        {
                            txtLogradouro.Text = endereco.logradouro;
                            txtBairro.Text = endereco.bairro;
                            txtCidade.Text = endereco.localidade;
                            txtUF.Text = endereco.uf;
                        }
                        else
                        {
                            MessageBox.Show("CEP não encontrado.", "Erro", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erro ao buscar o CEP. Verifique sua conexão com a internet.", "Erro", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }
    }
}