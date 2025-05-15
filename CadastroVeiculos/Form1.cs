using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroVeiculos
{
    public partial class CadastroVeiculo : Form

    {
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
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Todas as alterações foram feitas com sucesso!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            // Veículo
            string modelo = textBoxModelo.Text;
            string ano = comboBoxAno.SelectedItem.ToString();
            string placa = textBoxPlaca.Text;
            string fabricante = comboBoxFabricante.SelectedItem.ToString();
            string cor = textBoxCor.Text;
            string estadoVeiculo = comboBoxEstadoVeiculo.SelectedItem.ToString();
            string cidadeVeiculo = textBoxCidadeVeiculo.Text;

            // Proprietário
            string nome = textBoxNome.Text;
            string endereco = textBoxEndereco.Text;
            string bairro = textBoxBairro.Text;
            string complemento = textBoxComplemento.Text;
            string cidadeProprietario = textBoxCidadeProprietario.Text;
            string rg = textBoxRG.Text;
            string estadoProprietario = comboBoxEstadoProprietario.SelectedItem.ToString();
            string cpf = textBoxCPF.Text;
            string dataNascimento = dateTimePickerDataNasc.Value.ToString("dd/MM/yyyy");
            string sexo = radioButtonMasculino.Checked ? "Masculino" : "Feminino";

            MessageBox.Show($"-- Dados do Veículo --\n" +
                $"Modelo: {modelo}\n" +
                $"Ano: {ano}\n" +
                $"Placa: {placa}\n" +
                $"Fabricante: {fabricante}\n" +
                $"Cor: {cor}\n" +
                $"Estado: {estadoVeiculo}\n" +
                $"Cidade: {cidadeVeiculo}\n" +
                $"\n" +
                $"-- Dados do Proprietário --\n" +
                $"Nome: {nome}\n" +
                $"Endereço: {endereco}\n" +
                $"Bairro: {bairro}\n" +
                $"Complemento: {complemento}\n" +
                $"Estado: {estadoProprietario}\n" +
                $"Cidade: {cidadeProprietario}\n" +
                $"RG: {rg}\n" +
                $"CPF: {cpf}\n" +
                $"Data de Nascimento: {dataNascimento}\n" +
                $"Sexo: {sexo}", "Consulta");
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resultadoExcluir = MessageBox.Show("Tem certeza que deseja excluir todas as informações?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resultadoExcluir == DialogResult.Yes)
            {
                // Dados do veículo

                // textBox
                textBoxModelo.Clear();
                textBoxPlaca.Clear();
                textBoxCor.Clear();
                textBoxCidadeVeiculo.Clear();
                //comboBox
                comboBoxFabricante.SelectedIndex = -1;
                comboBoxAno.SelectedIndex = -1;
                comboBoxEstadoVeiculo.SelectedIndex = -1;

                // Dados do proprietário

                // textBox
                textBoxNome.Clear();
                textBoxEndereco.Clear();
                textBoxBairro.Clear();
                textBoxCidadeProprietario.Clear();
                textBoxComplemento.Clear();
                textBoxRG.Clear();
                textBoxCPF.Clear();
                // comboBox
                comboBoxEstadoProprietario.SelectedIndex = -1;
                // dateTimePicker
                dateTimePickerDataNasc.Value = DateTime.Now;
                // checkBox
                checkBox1Veiculo.Checked = false;
                // radioButton
                radioButtonMasculino.Checked = false;
                radioButtonFeminino.Checked = false;
                // pictureBox
                pictureBoxProprietario.Image = null;
                pictureBoxVeiculo.Image = null;

                MessageBox.Show("Todos os itens foram excluídos com sucesso", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            // Dados do veículo

            // textBox
            textBoxModelo.Clear();
            textBoxPlaca.Clear();
            textBoxCor.Clear();
            textBoxCidadeVeiculo.Clear();
            //comboBox
            comboBoxFabricante.SelectedIndex = -1;
            comboBoxAno.SelectedIndex = -1;
            comboBoxEstadoVeiculo.SelectedIndex = -1;

            // Dados do proprietário

            // textBox
            textBoxNome.Clear();
            textBoxEndereco.Clear();
            textBoxBairro.Clear();
            textBoxCidadeProprietario.Clear();
            textBoxComplemento.Clear();
            textBoxRG.Clear();
            textBoxCPF.Clear();
            // comboBox
            comboBoxEstadoProprietario.SelectedIndex = -1;
            // dateTimePicker
            dateTimePickerDataNasc.Value = DateTime.Now;
            // checkBox
            checkBox1Veiculo.Checked = false;
            // radioButton
            radioButtonMasculino.Checked = false;
            radioButtonFeminino.Checked = false;
            // pictureBox
            pictureBoxProprietario.Image = null;
            pictureBoxVeiculo.Image = null;
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
