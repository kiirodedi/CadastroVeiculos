using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroVeiculos
{
    public partial class CadastroVeiculo : Form

    {

        private bool cadastroRealizado = false;
        public CadastroVeiculo()
        {
            InitializeComponent();
        }

        public bool ValidarCPF(string cpf)
        {
            cpf = cpf.Trim();

            return cpf.Length == 11 && cpf.All(char.IsDigit);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelCPF_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCPF_TextChanged(object sender, EventArgs e)
        {

        }

        // Imagem do Veículo

        private void buttonCarregarVeiculo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de imagem (*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxVeiculo.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void buttonLimparVeiculo_Click(object sender, EventArgs e)
        {
            pictureBoxVeiculo.Image = null;
        }

        // Imagem do Proprietário
        private void buttonCarregarProprietario_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de imagem (*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxProprietario.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void buttonLimparProprietario_Click(object sender, EventArgs e)
        {
            pictureBoxProprietario.Image = null;
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            // VEÍCULO

            // Modelo
            if (string.IsNullOrWhiteSpace(textBoxModelo.Text))
            {
                MessageBox.Show("Preencha o campo MODELO do veículo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxModelo.Focus();

                return;
            }

            // Ano
            if (comboBoxAno.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o ANO do veículo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxAno.Focus();
                return;
            }

            // Placa
            if (string.IsNullOrWhiteSpace(textBoxPlaca.Text))
            {
                MessageBox.Show("Preencha o campo PLACA do veículo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPlaca.Focus();
                return;
            }

            // Fabricante
            if (comboBoxFabricante.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o FABRICANTE do veículo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxFabricante.Focus();
                return;
            }

            // Cor
            if (string.IsNullOrWhiteSpace(textBoxCor.Text))
            {
                MessageBox.Show("Preencha o campo COR do veículo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCor.Focus();
                return;
            }

            // Estado
            if (comboBoxEstadoVeiculo.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o ESTADO do veículo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxEstadoVeiculo.Focus();
                return;
            }

            // Cidade
            if (string.IsNullOrWhiteSpace(textBoxCidadeVeiculo.Text))
            {
                MessageBox.Show("Preencha o campo CIDADE do veículo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCidadeVeiculo.Focus();
                return;
            }

            // Imagem
            if (pictureBoxVeiculo.Image == null)
            {
                MessageBox.Show("Carregue uma imagem do veículo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonCarregarVeiculo.Focus();
                return;
            }

            // PROPRIETÁRIO

            // Nome
            if (string.IsNullOrWhiteSpace(textBoxNome.Text))
            {
                MessageBox.Show("Preencha o campo NOME do proprietário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNome.Focus();
                return;
            }

            // Endereço
            if (string.IsNullOrWhiteSpace(textBoxEndereco.Text))
            {
                MessageBox.Show("Preencha o campo ENDEREÇO do proprietário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEndereco.Focus();
                return;
            }

            // Bairro
            if (string.IsNullOrWhiteSpace(textBoxBairro.Text))
            {
                MessageBox.Show("Preencha o campo BAIRRO do proprietário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxBairro.Focus();
                return;
            }

            // Complemento
            if (string.IsNullOrWhiteSpace(textBoxComplemento.Text))
            {
                MessageBox.Show("Preencha o campo COMPLEMENTO do proprietário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxComplemento.Focus();
                return;
            }

            // Cidade
            if (string.IsNullOrWhiteSpace(textBoxCidadeProprietario.Text))
            {
                MessageBox.Show("Preencha o campo CIDADE do proprietário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCidadeProprietario.Focus();
                return;
            }

            // RG
            if (string.IsNullOrWhiteSpace(textBoxRG.Text))
            {
                MessageBox.Show("Preencha o campo RG do proprietário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxRG.Focus();
                return;
            }

            // Estado
            if (comboBoxEstadoProprietario.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o ESTADO do proprietário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxEstadoProprietario.Focus();
                return;
            }

            // CPF
            if (string.IsNullOrWhiteSpace(textBoxCPF.Text))
            {
                MessageBox.Show("Preencha o campo CPF do proprietário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCPF.Focus();
                return;
            }
            else if (!ValidarCPF(textBoxCPF.Text))
            {
                MessageBox.Show("O CPF deve conter 11 dígitos numéricos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCPF.Focus();
                return;
            }

            // Data de nascimento
            if (dateTimePickerDataNasc.Value == DateTime.Now)
            {
                MessageBox.Show("A data de nascimento deve ser anterior à data atual.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePickerDataNasc.Focus();
                return;
            }

            // Sexo
            if (!radioButtonMasculino.Checked && !radioButtonFeminino.Checked)
            {
                MessageBox.Show("Selecione o SEXO do proprietário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                radioButtonMasculino.Focus();
                return;
            }

            // Imagem
            if (pictureBoxProprietario.Image == null)
            {
                MessageBox.Show("Carregue uma imagem do proprietário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonCarregarProprietario.Focus();
                return;
            }

            MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cadastroRealizado = true;
        }
    }
}
