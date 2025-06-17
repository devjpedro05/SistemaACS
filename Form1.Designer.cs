// =================================================================================
// PROJETO: Sistema de Agentes Comunitários de Saúde (ACS) - Windows Forms
// ARQUIVO: Form1.Designer.cs
// DESCRIÇÃO: Código gerado pelo designer para o formulário principal.
// =================================================================================
namespace SistemaACS
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.dataGridViewFamilias = new System.Windows.Forms.DataGridView();
            this.dataGridViewPacientes = new System.Windows.Forms.DataGridView();
            this.btnAdicionarFamilia = new System.Windows.Forms.Button();
            this.btnAdicionarPaciente = new System.Windows.Forms.Button();
            this.labelFamilias = new System.Windows.Forms.Label();
            this.labelPacientes = new System.Windows.Forms.Label();
            this.labelAgendamentos = new System.Windows.Forms.Label();
            this.dataGridViewAgendamentos = new System.Windows.Forms.DataGridView();
            this.btnAdicionarAgendamento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFamilias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgendamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFamilias
            // 
            this.dataGridViewFamilias.AllowUserToAddRows = false;
            this.dataGridViewFamilias.AllowUserToDeleteRows = false;
            this.dataGridViewFamilias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFamilias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFamilias.Location = new System.Drawing.Point(12, 34);
            this.dataGridViewFamilias.Name = "dataGridViewFamilias";
            this.dataGridViewFamilias.ReadOnly = true;
            this.dataGridViewFamilias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFamilias.Size = new System.Drawing.Size(776, 130);
            this.dataGridViewFamilias.TabIndex = 0;
            this.dataGridViewFamilias.SelectionChanged += new System.EventHandler(this.dataGridViewFamilias_SelectionChanged);
            // 
            // dataGridViewPacientes
            // 
            this.dataGridViewPacientes.AllowUserToAddRows = false;
            this.dataGridViewPacientes.AllowUserToDeleteRows = false;
            this.dataGridViewPacientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPacientes.Location = new System.Drawing.Point(12, 226);
            this.dataGridViewPacientes.Name = "dataGridViewPacientes";
            this.dataGridViewPacientes.ReadOnly = true;
            this.dataGridViewPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPacientes.Size = new System.Drawing.Size(776, 130);
            this.dataGridViewPacientes.TabIndex = 1;
            this.dataGridViewPacientes.SelectionChanged += new System.EventHandler(this.dataGridViewPacientes_SelectionChanged);
            // 
            // btnAdicionarFamilia
            // 
            this.btnAdicionarFamilia.Location = new System.Drawing.Point(12, 170);
            this.btnAdicionarFamilia.Name = "btnAdicionarFamilia";
            this.btnAdicionarFamilia.Size = new System.Drawing.Size(120, 23);
            this.btnAdicionarFamilia.TabIndex = 2;
            this.btnAdicionarFamilia.Text = "Adicionar Família";
            this.btnAdicionarFamilia.UseVisualStyleBackColor = true;
            this.btnAdicionarFamilia.Click += new System.EventHandler(this.btnAdicionarFamilia_Click);
            // 
            // btnAdicionarPaciente
            // 
            this.btnAdicionarPaciente.Location = new System.Drawing.Point(12, 362);
            this.btnAdicionarPaciente.Name = "btnAdicionarPaciente";
            this.btnAdicionarPaciente.Size = new System.Drawing.Size(120, 23);
            this.btnAdicionarPaciente.TabIndex = 3;
            this.btnAdicionarPaciente.Text = "Adicionar Paciente";
            this.btnAdicionarPaciente.UseVisualStyleBackColor = true;
            this.btnAdicionarPaciente.Click += new System.EventHandler(this.btnAdicionarPaciente_Click);
            // 
            // labelFamilias
            // 
            this.labelFamilias.AutoSize = true;
            this.labelFamilias.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFamilias.Location = new System.Drawing.Point(12, 9);
            this.labelFamilias.Name = "labelFamilias";
            this.labelFamilias.Size = new System.Drawing.Size(163, 21);
            this.labelFamilias.TabIndex = 4;
            this.labelFamilias.Text = "Famílias Registadas";
            // 
            // labelPacientes
            // 
            this.labelPacientes.AutoSize = true;
            this.labelPacientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPacientes.Location = new System.Drawing.Point(12, 202);
            this.labelPacientes.Name = "labelPacientes";
            this.labelPacientes.Size = new System.Drawing.Size(207, 21);
            this.labelPacientes.TabIndex = 5;
            this.labelPacientes.Text = "Pacientes (Membros da Família)";
            // 
            // labelAgendamentos
            // 
            this.labelAgendamentos.AutoSize = true;
            this.labelAgendamentos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgendamentos.Location = new System.Drawing.Point(12, 398);
            this.labelAgendamentos.Name = "labelAgendamentos";
            this.labelAgendamentos.Size = new System.Drawing.Size(217, 21);
            this.labelAgendamentos.TabIndex = 6;
            this.labelAgendamentos.Text = "Agendamentos do Paciente";
            // 
            // dataGridViewAgendamentos
            // 
            this.dataGridViewAgendamentos.AllowUserToAddRows = false;
            this.dataGridViewAgendamentos.AllowUserToDeleteRows = false;
            this.dataGridViewAgendamentos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAgendamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAgendamentos.Location = new System.Drawing.Point(12, 422);
            this.dataGridViewAgendamentos.Name = "dataGridViewAgendamentos";
            this.dataGridViewAgendamentos.ReadOnly = true;
            this.dataGridViewAgendamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAgendamentos.Size = new System.Drawing.Size(776, 130);
            this.dataGridViewAgendamentos.TabIndex = 7;
            // 
            // btnAdicionarAgendamento
            // 
            this.btnAdicionarAgendamento.Location = new System.Drawing.Point(12, 558);
            this.btnAdicionarAgendamento.Name = "btnAdicionarAgendamento";
            this.btnAdicionarAgendamento.Size = new System.Drawing.Size(145, 23);
            this.btnAdicionarAgendamento.TabIndex = 8;
            this.btnAdicionarAgendamento.Text = "Adicionar Agendamento";
            this.btnAdicionarAgendamento.UseVisualStyleBackColor = true;
            this.btnAdicionarAgendamento.Click += new System.EventHandler(this.btnAdicionarAgendamento_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 593);
            this.Controls.Add(this.btnAdicionarAgendamento);
            this.Controls.Add(this.dataGridViewAgendamentos);
            this.Controls.Add(this.labelAgendamentos);
            this.Controls.Add(this.labelPacientes);
            this.Controls.Add(this.labelFamilias);
            this.Controls.Add(this.btnAdicionarPaciente);
            this.Controls.Add(this.btnAdicionarFamilia);
            this.Controls.Add(this.dataGridViewPacientes);
            this.Controls.Add(this.dataGridViewFamilias);
            this.Name = "Form1";
            this.Text = "Sistema de Agentes Comunitários de Saúde (ACS)";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFamilias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgendamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFamilias;
        private System.Windows.Forms.DataGridView dataGridViewPacientes;
        private System.Windows.Forms.Button btnAdicionarFamilia;
        private System.Windows.Forms.Button btnAdicionarPaciente;
        private System.Windows.Forms.Label labelFamilias;
        private System.Windows.Forms.Label labelPacientes;
        private System.Windows.Forms.Label labelAgendamentos;
        private System.Windows.Forms.DataGridView dataGridViewAgendamentos;
        private System.Windows.Forms.Button btnAdicionarAgendamento;
    }
}