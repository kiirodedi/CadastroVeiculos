namespace CadastroVeiculos
{
    partial class CadastroVeiculo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelModelo = new System.Windows.Forms.Label();
            this.groupBoxVeiculo = new System.Windows.Forms.GroupBox();
            this.buttonLimparVeiculo = new System.Windows.Forms.Button();
            this.buttonCarregarVeiculo = new System.Windows.Forms.Button();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.comboBoxEstadoVeiculo = new System.Windows.Forms.ComboBox();
            this.comboBoxFabricante = new System.Windows.Forms.ComboBox();
            this.comboBoxAno = new System.Windows.Forms.ComboBox();
            this.textBoxCidadeVeiculo = new System.Windows.Forms.TextBox();
            this.textBoxCor = new System.Windows.Forms.TextBox();
            this.textBoxPlaca = new System.Windows.Forms.TextBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelCidadeVeiculo = new System.Windows.Forms.Label();
            this.labelFabricante = new System.Windows.Forms.Label();
            this.labelCor = new System.Windows.Forms.Label();
            this.labelPlaca = new System.Windows.Forms.Label();
            this.labelAno = new System.Windows.Forms.Label();
            this.groupBoxPropriedade = new System.Windows.Forms.GroupBox();
            this.buttonLimparProprietario = new System.Windows.Forms.Button();
            this.buttonCarregarProprietario = new System.Windows.Forms.Button();
            this.groupBoxSexo = new System.Windows.Forms.GroupBox();
            this.radioButtonFeminino = new System.Windows.Forms.RadioButton();
            this.radioButtonMasculino = new System.Windows.Forms.RadioButton();
            this.checkBox1Veiculo = new System.Windows.Forms.CheckBox();
            this.dateTimePickerDataNasc = new System.Windows.Forms.DateTimePicker();
            this.labelDataNasc = new System.Windows.Forms.Label();
            this.comboBoxEstadoProprietario = new System.Windows.Forms.ComboBox();
            this.textBoxCPF = new System.Windows.Forms.TextBox();
            this.textBoxRG = new System.Windows.Forms.TextBox();
            this.textBoxCidadeProprietario = new System.Windows.Forms.TextBox();
            this.textBoxComplemento = new System.Windows.Forms.TextBox();
            this.textBoxBairro = new System.Windows.Forms.TextBox();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelCPF = new System.Windows.Forms.Label();
            this.labelEstadoProprietario = new System.Windows.Forms.Label();
            this.labelRG = new System.Windows.Forms.Label();
            this.labelCidadeProprietario = new System.Windows.Forms.Label();
            this.labelComplemento = new System.Windows.Forms.Label();
            this.labelBairro = new System.Windows.Forms.Label();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.pictureBoxProprietario = new System.Windows.Forms.PictureBox();
            this.pictureBoxVeiculo = new System.Windows.Forms.PictureBox();
            this.groupBoxVeiculo.SuspendLayout();
            this.groupBoxPropriedade.SuspendLayout();
            this.groupBoxSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProprietario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVeiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(285, 18);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(217, 25);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Cadastro de Veículos";
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Location = new System.Drawing.Point(17, 38);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(49, 15);
            this.labelModelo.TabIndex = 1;
            this.labelModelo.Text = "Modelo";
            // 
            // groupBoxVeiculo
            // 
            this.groupBoxVeiculo.Controls.Add(this.buttonLimparVeiculo);
            this.groupBoxVeiculo.Controls.Add(this.buttonCarregarVeiculo);
            this.groupBoxVeiculo.Controls.Add(this.pictureBoxVeiculo);
            this.groupBoxVeiculo.Controls.Add(this.textBoxModelo);
            this.groupBoxVeiculo.Controls.Add(this.comboBoxEstadoVeiculo);
            this.groupBoxVeiculo.Controls.Add(this.comboBoxFabricante);
            this.groupBoxVeiculo.Controls.Add(this.comboBoxAno);
            this.groupBoxVeiculo.Controls.Add(this.textBoxCidadeVeiculo);
            this.groupBoxVeiculo.Controls.Add(this.textBoxCor);
            this.groupBoxVeiculo.Controls.Add(this.textBoxPlaca);
            this.groupBoxVeiculo.Controls.Add(this.labelEstado);
            this.groupBoxVeiculo.Controls.Add(this.labelCidadeVeiculo);
            this.groupBoxVeiculo.Controls.Add(this.labelFabricante);
            this.groupBoxVeiculo.Controls.Add(this.labelCor);
            this.groupBoxVeiculo.Controls.Add(this.labelPlaca);
            this.groupBoxVeiculo.Controls.Add(this.labelAno);
            this.groupBoxVeiculo.Controls.Add(this.labelModelo);
            this.groupBoxVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxVeiculo.Location = new System.Drawing.Point(12, 60);
            this.groupBoxVeiculo.Name = "groupBoxVeiculo";
            this.groupBoxVeiculo.Size = new System.Drawing.Size(776, 176);
            this.groupBoxVeiculo.TabIndex = 2;
            this.groupBoxVeiculo.TabStop = false;
            this.groupBoxVeiculo.Text = "Dados do veículo";
            // 
            // buttonLimparVeiculo
            // 
            this.buttonLimparVeiculo.Location = new System.Drawing.Point(674, 138);
            this.buttonLimparVeiculo.Name = "buttonLimparVeiculo";
            this.buttonLimparVeiculo.Size = new System.Drawing.Size(75, 23);
            this.buttonLimparVeiculo.TabIndex = 15;
            this.buttonLimparVeiculo.Text = "Limpar";
            this.buttonLimparVeiculo.UseVisualStyleBackColor = true;
            this.buttonLimparVeiculo.Click += new System.EventHandler(this.buttonLimparVeiculo_Click);
            // 
            // buttonCarregarVeiculo
            // 
            this.buttonCarregarVeiculo.Location = new System.Drawing.Point(584, 138);
            this.buttonCarregarVeiculo.Name = "buttonCarregarVeiculo";
            this.buttonCarregarVeiculo.Size = new System.Drawing.Size(75, 23);
            this.buttonCarregarVeiculo.TabIndex = 14;
            this.buttonCarregarVeiculo.Text = "Carregar";
            this.buttonCarregarVeiculo.UseVisualStyleBackColor = true;
            this.buttonCarregarVeiculo.Click += new System.EventHandler(this.buttonCarregarVeiculo_Click);
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(65, 35);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(214, 21);
            this.textBoxModelo.TabIndex = 12;
            // 
            // comboBoxEstadoVeiculo
            // 
            this.comboBoxEstadoVeiculo.FormattingEnabled = true;
            this.comboBoxEstadoVeiculo.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.comboBoxEstadoVeiculo.Location = new System.Drawing.Point(259, 131);
            this.comboBoxEstadoVeiculo.Name = "comboBoxEstadoVeiculo";
            this.comboBoxEstadoVeiculo.Size = new System.Drawing.Size(46, 23);
            this.comboBoxEstadoVeiculo.TabIndex = 11;
            this.comboBoxEstadoVeiculo.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBoxFabricante
            // 
            this.comboBoxFabricante.FormattingEnabled = true;
            this.comboBoxFabricante.Location = new System.Drawing.Point(384, 35);
            this.comboBoxFabricante.Name = "comboBoxFabricante";
            this.comboBoxFabricante.Size = new System.Drawing.Size(173, 23);
            this.comboBoxFabricante.TabIndex = 10;
            // 
            // comboBoxAno
            // 
            this.comboBoxAno.FormattingEnabled = true;
            this.comboBoxAno.Items.AddRange(new object[] {
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014"});
            this.comboBoxAno.Location = new System.Drawing.Point(49, 79);
            this.comboBoxAno.Name = "comboBoxAno";
            this.comboBoxAno.Size = new System.Drawing.Size(84, 23);
            this.comboBoxAno.TabIndex = 9;
            // 
            // textBoxCidadeVeiculo
            // 
            this.textBoxCidadeVeiculo.Location = new System.Drawing.Point(384, 128);
            this.textBoxCidadeVeiculo.Name = "textBoxCidadeVeiculo";
            this.textBoxCidadeVeiculo.Size = new System.Drawing.Size(173, 21);
            this.textBoxCidadeVeiculo.TabIndex = 8;
            // 
            // textBoxCor
            // 
            this.textBoxCor.Location = new System.Drawing.Point(242, 79);
            this.textBoxCor.Name = "textBoxCor";
            this.textBoxCor.Size = new System.Drawing.Size(136, 21);
            this.textBoxCor.TabIndex = 7;
            // 
            // textBoxPlaca
            // 
            this.textBoxPlaca.Location = new System.Drawing.Point(57, 128);
            this.textBoxPlaca.Name = "textBoxPlaca";
            this.textBoxPlaca.Size = new System.Drawing.Size(106, 21);
            this.textBoxPlaca.TabIndex = 6;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(213, 131);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(45, 15);
            this.labelEstado.TabIndex = 3;
            this.labelEstado.Text = "Estado";
            // 
            // labelCidadeVeiculo
            // 
            this.labelCidadeVeiculo.AutoSize = true;
            this.labelCidadeVeiculo.Location = new System.Drawing.Point(338, 131);
            this.labelCidadeVeiculo.Name = "labelCidadeVeiculo";
            this.labelCidadeVeiculo.Size = new System.Drawing.Size(46, 15);
            this.labelCidadeVeiculo.TabIndex = 4;
            this.labelCidadeVeiculo.Text = "Cidade";
            // 
            // labelFabricante
            // 
            this.labelFabricante.AutoSize = true;
            this.labelFabricante.Location = new System.Drawing.Point(313, 38);
            this.labelFabricante.Name = "labelFabricante";
            this.labelFabricante.Size = new System.Drawing.Size(65, 15);
            this.labelFabricante.TabIndex = 3;
            this.labelFabricante.Text = "Fabricante";
            // 
            // labelCor
            // 
            this.labelCor.AutoSize = true;
            this.labelCor.Location = new System.Drawing.Point(213, 82);
            this.labelCor.Name = "labelCor";
            this.labelCor.Size = new System.Drawing.Size(26, 15);
            this.labelCor.TabIndex = 4;
            this.labelCor.Text = "Cor";
            // 
            // labelPlaca
            // 
            this.labelPlaca.AutoSize = true;
            this.labelPlaca.Location = new System.Drawing.Point(17, 131);
            this.labelPlaca.Name = "labelPlaca";
            this.labelPlaca.Size = new System.Drawing.Size(38, 15);
            this.labelPlaca.TabIndex = 3;
            this.labelPlaca.Text = "Placa";
            // 
            // labelAno
            // 
            this.labelAno.AutoSize = true;
            this.labelAno.Location = new System.Drawing.Point(17, 82);
            this.labelAno.Name = "labelAno";
            this.labelAno.Size = new System.Drawing.Size(28, 15);
            this.labelAno.TabIndex = 2;
            this.labelAno.Text = "Ano";
            // 
            // groupBoxPropriedade
            // 
            this.groupBoxPropriedade.Controls.Add(this.buttonLimparProprietario);
            this.groupBoxPropriedade.Controls.Add(this.pictureBoxProprietario);
            this.groupBoxPropriedade.Controls.Add(this.buttonCarregarProprietario);
            this.groupBoxPropriedade.Controls.Add(this.groupBoxSexo);
            this.groupBoxPropriedade.Controls.Add(this.checkBox1Veiculo);
            this.groupBoxPropriedade.Controls.Add(this.dateTimePickerDataNasc);
            this.groupBoxPropriedade.Controls.Add(this.labelDataNasc);
            this.groupBoxPropriedade.Controls.Add(this.comboBoxEstadoProprietario);
            this.groupBoxPropriedade.Controls.Add(this.textBoxCPF);
            this.groupBoxPropriedade.Controls.Add(this.textBoxRG);
            this.groupBoxPropriedade.Controls.Add(this.textBoxCidadeProprietario);
            this.groupBoxPropriedade.Controls.Add(this.textBoxComplemento);
            this.groupBoxPropriedade.Controls.Add(this.textBoxBairro);
            this.groupBoxPropriedade.Controls.Add(this.textBoxEndereco);
            this.groupBoxPropriedade.Controls.Add(this.textBoxNome);
            this.groupBoxPropriedade.Controls.Add(this.labelCPF);
            this.groupBoxPropriedade.Controls.Add(this.labelEstadoProprietario);
            this.groupBoxPropriedade.Controls.Add(this.labelRG);
            this.groupBoxPropriedade.Controls.Add(this.labelCidadeProprietario);
            this.groupBoxPropriedade.Controls.Add(this.labelComplemento);
            this.groupBoxPropriedade.Controls.Add(this.labelBairro);
            this.groupBoxPropriedade.Controls.Add(this.labelEndereco);
            this.groupBoxPropriedade.Controls.Add(this.labelNome);
            this.groupBoxPropriedade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPropriedade.Location = new System.Drawing.Point(12, 263);
            this.groupBoxPropriedade.Name = "groupBoxPropriedade";
            this.groupBoxPropriedade.Size = new System.Drawing.Size(776, 217);
            this.groupBoxPropriedade.TabIndex = 3;
            this.groupBoxPropriedade.TabStop = false;
            this.groupBoxPropriedade.Text = "Cadastro de proprietário";
            // 
            // buttonLimparProprietario
            // 
            this.buttonLimparProprietario.Location = new System.Drawing.Point(674, 176);
            this.buttonLimparProprietario.Name = "buttonLimparProprietario";
            this.buttonLimparProprietario.Size = new System.Drawing.Size(75, 23);
            this.buttonLimparProprietario.TabIndex = 17;
            this.buttonLimparProprietario.Text = "Limpar";
            this.buttonLimparProprietario.UseVisualStyleBackColor = true;
            this.buttonLimparProprietario.Click += new System.EventHandler(this.buttonLimparProprietario_Click);
            // 
            // buttonCarregarProprietario
            // 
            this.buttonCarregarProprietario.Location = new System.Drawing.Point(593, 176);
            this.buttonCarregarProprietario.Name = "buttonCarregarProprietario";
            this.buttonCarregarProprietario.Size = new System.Drawing.Size(75, 23);
            this.buttonCarregarProprietario.TabIndex = 16;
            this.buttonCarregarProprietario.Text = "Carregar";
            this.buttonCarregarProprietario.UseVisualStyleBackColor = true;
            this.buttonCarregarProprietario.Click += new System.EventHandler(this.buttonCarregarProprietario_Click);
            // 
            // groupBoxSexo
            // 
            this.groupBoxSexo.Controls.Add(this.radioButtonFeminino);
            this.groupBoxSexo.Controls.Add(this.radioButtonMasculino);
            this.groupBoxSexo.Location = new System.Drawing.Point(448, 117);
            this.groupBoxSexo.Name = "groupBoxSexo";
            this.groupBoxSexo.Size = new System.Drawing.Size(116, 82);
            this.groupBoxSexo.TabIndex = 32;
            this.groupBoxSexo.TabStop = false;
            this.groupBoxSexo.Text = "Sexo";
            // 
            // radioButtonFeminino
            // 
            this.radioButtonFeminino.AutoSize = true;
            this.radioButtonFeminino.Location = new System.Drawing.Point(18, 45);
            this.radioButtonFeminino.Name = "radioButtonFeminino";
            this.radioButtonFeminino.Size = new System.Drawing.Size(77, 19);
            this.radioButtonFeminino.TabIndex = 1;
            this.radioButtonFeminino.TabStop = true;
            this.radioButtonFeminino.Text = "Feminino";
            this.radioButtonFeminino.UseVisualStyleBackColor = true;
            // 
            // radioButtonMasculino
            // 
            this.radioButtonMasculino.AutoSize = true;
            this.radioButtonMasculino.Location = new System.Drawing.Point(17, 20);
            this.radioButtonMasculino.Name = "radioButtonMasculino";
            this.radioButtonMasculino.Size = new System.Drawing.Size(82, 19);
            this.radioButtonMasculino.TabIndex = 0;
            this.radioButtonMasculino.TabStop = true;
            this.radioButtonMasculino.Text = "Masculino";
            this.radioButtonMasculino.UseVisualStyleBackColor = true;
            // 
            // checkBox1Veiculo
            // 
            this.checkBox1Veiculo.AutoSize = true;
            this.checkBox1Veiculo.Location = new System.Drawing.Point(466, 87);
            this.checkBox1Veiculo.Name = "checkBox1Veiculo";
            this.checkBox1Veiculo.Size = new System.Drawing.Size(81, 19);
            this.checkBox1Veiculo.TabIndex = 31;
            this.checkBox1Veiculo.Text = "1° Veículo";
            this.checkBox1Veiculo.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDataNasc
            // 
            this.dateTimePickerDataNasc.Location = new System.Drawing.Point(448, 50);
            this.dateTimePickerDataNasc.Name = "dateTimePickerDataNasc";
            this.dateTimePickerDataNasc.Size = new System.Drawing.Size(116, 21);
            this.dateTimePickerDataNasc.TabIndex = 30;
            // 
            // labelDataNasc
            // 
            this.labelDataNasc.AutoSize = true;
            this.labelDataNasc.Location = new System.Drawing.Point(445, 32);
            this.labelDataNasc.Name = "labelDataNasc";
            this.labelDataNasc.Size = new System.Drawing.Size(119, 15);
            this.labelDataNasc.TabIndex = 16;
            this.labelDataNasc.Text = "Data de Nascimento";
            // 
            // comboBoxEstadoProprietario
            // 
            this.comboBoxEstadoProprietario.FormattingEnabled = true;
            this.comboBoxEstadoProprietario.Items.AddRange(new object[] {
            "Alfa Romeo",
            "Audi",
            "BMW",
            "Cross Lander",
            "Citroën",
            "DaimlerChrysler",
            "Ferrari",
            "Fiat",
            "Ford",
            "General Motors",
            "Honda",
            "Hyundai",
            "Jaguar",
            "Kia",
            "Land Rover",
            "Mitsubishi",
            "Nissan",
            "Peugeot",
            "Porsche",
            "Renault",
            "Seat",
            "SsangYong",
            "Subaru",
            "Toyota",
            "Troller",
            "Volkswagen",
            "Volvo"});
            this.comboBoxEstadoProprietario.Location = new System.Drawing.Point(386, 153);
            this.comboBoxEstadoProprietario.Name = "comboBoxEstadoProprietario";
            this.comboBoxEstadoProprietario.Size = new System.Drawing.Size(46, 23);
            this.comboBoxEstadoProprietario.TabIndex = 16;
            // 
            // textBoxCPF
            // 
            this.textBoxCPF.Location = new System.Drawing.Point(264, 178);
            this.textBoxCPF.Name = "textBoxCPF";
            this.textBoxCPF.Size = new System.Drawing.Size(168, 21);
            this.textBoxCPF.TabIndex = 29;
            this.textBoxCPF.TextChanged += new System.EventHandler(this.textBoxCPF_TextChanged);
            // 
            // textBoxRG
            // 
            this.textBoxRG.Location = new System.Drawing.Point(48, 178);
            this.textBoxRG.Name = "textBoxRG";
            this.textBoxRG.Size = new System.Drawing.Size(148, 21);
            this.textBoxRG.TabIndex = 28;
            // 
            // textBoxCidadeProprietario
            // 
            this.textBoxCidadeProprietario.Location = new System.Drawing.Point(69, 151);
            this.textBoxCidadeProprietario.Name = "textBoxCidadeProprietario";
            this.textBoxCidadeProprietario.Size = new System.Drawing.Size(236, 21);
            this.textBoxCidadeProprietario.TabIndex = 27;
            // 
            // textBoxComplemento
            // 
            this.textBoxComplemento.Location = new System.Drawing.Point(108, 124);
            this.textBoxComplemento.Name = "textBoxComplemento";
            this.textBoxComplemento.Size = new System.Drawing.Size(324, 21);
            this.textBoxComplemento.TabIndex = 26;
            // 
            // textBoxBairro
            // 
            this.textBoxBairro.Location = new System.Drawing.Point(63, 91);
            this.textBoxBairro.Name = "textBoxBairro";
            this.textBoxBairro.Size = new System.Drawing.Size(369, 21);
            this.textBoxBairro.TabIndex = 25;
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(84, 61);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(348, 21);
            this.textBoxEndereco.TabIndex = 24;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(64, 32);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(368, 21);
            this.textBoxNome.TabIndex = 16;
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Location = new System.Drawing.Point(228, 181);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(30, 15);
            this.labelCPF.TabIndex = 23;
            this.labelCPF.Text = "CPF";
            this.labelCPF.Click += new System.EventHandler(this.labelCPF_Click);
            // 
            // labelEstadoProprietario
            // 
            this.labelEstadoProprietario.AutoSize = true;
            this.labelEstadoProprietario.Location = new System.Drawing.Point(331, 155);
            this.labelEstadoProprietario.Name = "labelEstadoProprietario";
            this.labelEstadoProprietario.Size = new System.Drawing.Size(45, 15);
            this.labelEstadoProprietario.TabIndex = 22;
            this.labelEstadoProprietario.Text = "Estado";
            // 
            // labelRG
            // 
            this.labelRG.AutoSize = true;
            this.labelRG.Location = new System.Drawing.Point(17, 179);
            this.labelRG.Name = "labelRG";
            this.labelRG.Size = new System.Drawing.Size(25, 15);
            this.labelRG.TabIndex = 21;
            this.labelRG.Text = "RG";
            // 
            // labelCidadeProprietario
            // 
            this.labelCidadeProprietario.AutoSize = true;
            this.labelCidadeProprietario.Location = new System.Drawing.Point(17, 151);
            this.labelCidadeProprietario.Name = "labelCidadeProprietario";
            this.labelCidadeProprietario.Size = new System.Drawing.Size(46, 15);
            this.labelCidadeProprietario.TabIndex = 20;
            this.labelCidadeProprietario.Text = "Cidade";
            // 
            // labelComplemento
            // 
            this.labelComplemento.AutoSize = true;
            this.labelComplemento.Location = new System.Drawing.Point(17, 124);
            this.labelComplemento.Name = "labelComplemento";
            this.labelComplemento.Size = new System.Drawing.Size(85, 15);
            this.labelComplemento.TabIndex = 19;
            this.labelComplemento.Text = "Complemento";
            // 
            // labelBairro
            // 
            this.labelBairro.AutoSize = true;
            this.labelBairro.Location = new System.Drawing.Point(17, 91);
            this.labelBairro.Name = "labelBairro";
            this.labelBairro.Size = new System.Drawing.Size(40, 15);
            this.labelBairro.TabIndex = 18;
            this.labelBairro.Text = "Bairro";
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Location = new System.Drawing.Point(18, 61);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(60, 15);
            this.labelEndereco.TabIndex = 17;
            this.labelEndereco.Text = "Endereço";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(17, 32);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(41, 15);
            this.labelNome.TabIndex = 16;
            this.labelNome.Text = "Nome";
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(100, 502);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastrar.TabIndex = 16;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(201, 502);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterar.TabIndex = 17;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Location = new System.Drawing.Point(297, 502);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(75, 23);
            this.buttonConsultar.TabIndex = 18;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(398, 502);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluir.TabIndex = 19;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(501, 502);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpar.TabIndex = 20;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(605, 502);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 23);
            this.buttonSair.TabIndex = 21;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // pictureBoxProprietario
            // 
            this.pictureBoxProprietario.BackColor = System.Drawing.Color.White;
            this.pictureBoxProprietario.BackgroundImage = global::CadastroVeiculos.Properties.Resources.proprietarioNull;
            this.pictureBoxProprietario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxProprietario.Location = new System.Drawing.Point(593, 20);
            this.pictureBoxProprietario.Name = "pictureBoxProprietario";
            this.pictureBoxProprietario.Size = new System.Drawing.Size(156, 150);
            this.pictureBoxProprietario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProprietario.TabIndex = 16;
            this.pictureBoxProprietario.TabStop = false;
            // 
            // pictureBoxVeiculo
            // 
            this.pictureBoxVeiculo.BackColor = System.Drawing.Color.White;
            this.pictureBoxVeiculo.BackgroundImage = global::CadastroVeiculos.Properties.Resources.veiculoNull;
            this.pictureBoxVeiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxVeiculo.Location = new System.Drawing.Point(584, 19);
            this.pictureBoxVeiculo.Name = "pictureBoxVeiculo";
            this.pictureBoxVeiculo.Size = new System.Drawing.Size(165, 113);
            this.pictureBoxVeiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVeiculo.TabIndex = 13;
            this.pictureBoxVeiculo.TabStop = false;
            // 
            // CadastroVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 549);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.groupBoxPropriedade);
            this.Controls.Add(this.groupBoxVeiculo);
            this.Controls.Add(this.labelTitulo);
            this.Name = "CadastroVeiculo";
            this.Text = "Form1";
            this.groupBoxVeiculo.ResumeLayout(false);
            this.groupBoxVeiculo.PerformLayout();
            this.groupBoxPropriedade.ResumeLayout(false);
            this.groupBoxPropriedade.PerformLayout();
            this.groupBoxSexo.ResumeLayout(false);
            this.groupBoxSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProprietario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVeiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.GroupBox groupBoxVeiculo;
        private System.Windows.Forms.Label labelPlaca;
        private System.Windows.Forms.Label labelAno;
        private System.Windows.Forms.ComboBox comboBoxEstadoVeiculo;
        private System.Windows.Forms.ComboBox comboBoxFabricante;
        private System.Windows.Forms.ComboBox comboBoxAno;
        private System.Windows.Forms.TextBox textBoxCidadeVeiculo;
        private System.Windows.Forms.TextBox textBoxCor;
        private System.Windows.Forms.TextBox textBoxPlaca;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelCidadeVeiculo;
        private System.Windows.Forms.Label labelFabricante;
        private System.Windows.Forms.Label labelCor;
        private System.Windows.Forms.Button buttonLimparVeiculo;
        private System.Windows.Forms.Button buttonCarregarVeiculo;
        private System.Windows.Forms.PictureBox pictureBoxVeiculo;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.GroupBox groupBoxPropriedade;
        private System.Windows.Forms.Label labelCidadeProprietario;
        private System.Windows.Forms.Label labelComplemento;
        private System.Windows.Forms.Label labelBairro;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelEstadoProprietario;
        private System.Windows.Forms.Label labelRG;
        private System.Windows.Forms.ComboBox comboBoxEstadoProprietario;
        private System.Windows.Forms.TextBox textBoxCPF;
        private System.Windows.Forms.TextBox textBoxRG;
        private System.Windows.Forms.TextBox textBoxCidadeProprietario;
        private System.Windows.Forms.TextBox textBoxComplemento;
        private System.Windows.Forms.TextBox textBoxBairro;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.Label labelDataNasc;
        private System.Windows.Forms.PictureBox pictureBoxProprietario;
        private System.Windows.Forms.GroupBox groupBoxSexo;
        private System.Windows.Forms.RadioButton radioButtonFeminino;
        private System.Windows.Forms.RadioButton radioButtonMasculino;
        private System.Windows.Forms.CheckBox checkBox1Veiculo;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataNasc;
        private System.Windows.Forms.Button buttonLimparProprietario;
        private System.Windows.Forms.Button buttonCarregarProprietario;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonSair;
    }
}

