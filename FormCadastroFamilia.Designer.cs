// =================================================================================
// PROJETO: Sistema de Agentes Comunitários de Saúde (ACS) - Windows Forms
// ARQUIVO: FormCadastroFamilia.Designer.cs
// DESCRIÇÃO: Código gerado pelo designer para o formulário de cadastro de família.
// =================================================================================
namespace SistemaACS
{
    partial class FormCadastroFamilia
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
            label1 = new Label();
            txtNomeFamilia = new TextBox();
            groupBox1 = new GroupBox();
            txtCEP = new TextBox();
            label8 = new Label();
            txtUF = new TextBox();
            label7 = new Label();
            txtCidade = new TextBox();
            label6 = new Label();
            txtBairro = new TextBox();
            label5 = new Label();
            txtComplemento = new TextBox();
            label4 = new Label();
            txtNumero = new TextBox();
            label3 = new Label();
            txtLogradouro = new TextBox();
            label2 = new Label();
            btnSalvar = new Button();
            buscarCEP_API = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 13);
            label1.Name = "label1";
            label1.Size = new Size(161, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome da Família (Ref.)";
            // 
            // txtNomeFamilia
            // 
            txtNomeFamilia.Location = new Point(16, 30);
            txtNomeFamilia.Name = "txtNomeFamilia";
            txtNomeFamilia.Size = new Size(356, 27);
            txtNomeFamilia.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buscarCEP_API);
            groupBox1.Controls.Add(txtCEP);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtUF);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtCidade);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtBairro);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtComplemento);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtNumero);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtLogradouro);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(16, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(356, 260);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Endereço";
            // 
            // txtCEP
            // 
            txtCEP.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCEP.Location = new Point(135, 222);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(100, 23);
            txtCEP.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(132, 206);
            label8.Name = "label8";
            label8.Size = new Size(35, 17);
            label8.TabIndex = 12;
            label8.Text = "CEP";
            // 
            // txtUF
            // 
            txtUF.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUF.Location = new Point(9, 222);
            txtUF.Name = "txtUF";
            txtUF.Size = new Size(100, 23);
            txtUF.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(6, 206);
            label7.Name = "label7";
            label7.Size = new Size(26, 17);
            label7.TabIndex = 10;
            label7.Text = "UF";
            // 
            // txtCidade
            // 
            txtCidade.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCidade.Location = new Point(9, 174);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(341, 23);
            txtCidade.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 158);
            label6.Name = "label6";
            label6.Size = new Size(52, 17);
            label6.TabIndex = 8;
            label6.Text = "Cidade";
            // 
            // txtBairro
            // 
            txtBairro.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBairro.Location = new Point(9, 126);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(341, 23);
            txtBairro.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 110);
            label5.Name = "label5";
            label5.Size = new Size(46, 17);
            label5.TabIndex = 6;
            label5.Text = "Bairro";
            // 
            // txtComplemento
            // 
            txtComplemento.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtComplemento.Location = new Point(135, 78);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(215, 23);
            txtComplemento.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(132, 62);
            label4.Name = "label4";
            label4.Size = new Size(94, 17);
            label4.TabIndex = 4;
            label4.Text = "Complemento";
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumero.Location = new Point(9, 78);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 62);
            label3.Name = "label3";
            label3.Size = new Size(58, 17);
            label3.TabIndex = 2;
            label3.Text = "Número";
            // 
            // txtLogradouro
            // 
            txtLogradouro.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLogradouro.Location = new Point(9, 32);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(341, 23);
            txtLogradouro.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 16);
            label2.Name = "label2";
            label2.Size = new Size(82, 17);
            label2.TabIndex = 0;
            label2.Text = "Logradouro";
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(297, 345);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Guardar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // buscarCEP_API
            // 
            buscarCEP_API.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buscarCEP_API.Location = new Point(253, 222);
            buscarCEP_API.Name = "buscarCEP_API";
            buscarCEP_API.Size = new Size(82, 23);
            buscarCEP_API.TabIndex = 14;
            buscarCEP_API.Text = "BUSCAR";
            buscarCEP_API.UseVisualStyleBackColor = true;
            buscarCEP_API.Click += buscarCEP_API_Click;
            // 
            // FormCadastroFamilia
            // 
            ClientSize = new Size(384, 381);
            Controls.Add(btnSalvar);
            Controls.Add(groupBox1);
            Controls.Add(txtNomeFamilia);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastroFamilia";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registo de Família";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeFamilia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSalvar;
        private Button buscarCEP_API;
    }
}