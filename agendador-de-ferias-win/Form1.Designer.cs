using System.Globalization;
using System.Text;

namespace agendador_de_ferias_win
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelMatricula;
        private System.Windows.Forms.TextBox textBoxMatricula;
        private System.Windows.Forms.Label labelInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.Label labelFim;
        private System.Windows.Forms.DateTimePicker dateTimePickerFim;
        private System.Windows.Forms.Button buttonSalvar;

        private System.Windows.Forms.Button buttonEscolherArquivo;
        private System.Windows.Forms.TextBox textBoxCaminhoArquivo;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.ComboBox comboBoxTipo;


        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            labelNome = new Label();
            textBoxNome = new TextBox();
            labelMatricula = new Label();
            textBoxMatricula = new TextBox();
            labelInicio = new Label();
            dateTimePickerInicio = new DateTimePicker();
            labelFim = new Label();
            dateTimePickerFim = new DateTimePicker();
            buttonSalvar = new Button();
            buttonEscolherArquivo = new Button();
            textBoxCaminhoArquivo = new TextBox();
            pictureBox1 = new PictureBox();
            labelTipo = new Label();
            comboBoxTipo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(39, 121);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(43, 15);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome:";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(39, 139);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(224, 23);
            textBoxNome.TabIndex = 1;
            // 
            // labelMatricula
            // 
            labelMatricula.AutoSize = true;
            labelMatricula.Location = new Point(269, 121);
            labelMatricula.Name = "labelMatricula";
            labelMatricula.Size = new Size(60, 15);
            labelMatricula.TabIndex = 2;
            labelMatricula.Text = "Matrícula:";
            // 
            // textBoxMatricula
            // 
            textBoxMatricula.Location = new Point(269, 139);
            textBoxMatricula.Name = "textBoxMatricula";
            textBoxMatricula.Size = new Size(133, 23);
            textBoxMatricula.TabIndex = 3;
            // 
            // labelInicio
            // 
            labelInicio.AutoSize = true;
            labelInicio.Location = new Point(39, 175);
            labelInicio.Name = "labelInicio";
            labelInicio.Size = new Size(91, 15);
            labelInicio.TabIndex = 4;
            labelInicio.Text = "Início das férias:";
            // 
            // dateTimePickerInicio
            // 
            dateTimePickerInicio.Format = DateTimePickerFormat.Short;
            dateTimePickerInicio.Location = new Point(39, 193);
            dateTimePickerInicio.Name = "dateTimePickerInicio";
            dateTimePickerInicio.Size = new Size(166, 23);
            dateTimePickerInicio.TabIndex = 5;
            // 
            // labelFim
            // 
            labelFim.AutoSize = true;
            labelFim.Location = new Point(236, 175);
            labelFim.Name = "labelFim";
            labelFim.Size = new Size(82, 15);
            labelFim.TabIndex = 6;
            labelFim.Text = "Fim das férias:";
            // 
            // dateTimePickerFim
            // 
            dateTimePickerFim.Format = DateTimePickerFormat.Short;
            dateTimePickerFim.Location = new Point(236, 193);
            dateTimePickerFim.Name = "dateTimePickerFim";
            dateTimePickerFim.Size = new Size(166, 23);
            dateTimePickerFim.TabIndex = 7;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(147, 306);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(129, 28);
            buttonSalvar.TabIndex = 8;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // buttonEscolherArquivo
            // 
            buttonEscolherArquivo.Location = new Point(327, 83);
            buttonEscolherArquivo.Name = "buttonEscolherArquivo";
            buttonEscolherArquivo.Size = new Size(75, 23);
            buttonEscolherArquivo.TabIndex = 9;
            buttonEscolherArquivo.Text = "Escolher Arquivo";
            buttonEscolherArquivo.Click += buttonEscolherArquivo_Click;
            // 
            // textBoxCaminhoArquivo
            // 
            textBoxCaminhoArquivo.Location = new Point(39, 83);
            textBoxCaminhoArquivo.Name = "textBoxCaminhoArquivo";
            textBoxCaminhoArquivo.ReadOnly = true;
            textBoxCaminhoArquivo.Size = new Size(282, 23);
            textBoxCaminhoArquivo.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(138, -9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 86);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Location = new Point(39, 224);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(33, 15);
            labelTipo.TabIndex = 12;
            labelTipo.Text = "Tipo:";
            labelTipo.Click += labelTipo_Click;
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipo.Items.AddRange(new object[] { "Férias", "APIP", "Compensação" });
            comboBoxTipo.Location = new Point(39, 242);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(200, 23);
            comboBoxTipo.TabIndex = 13;
            // 
            // Form1
            // 
            ClientSize = new Size(458, 361);
            Controls.Add(pictureBox1);
            Controls.Add(labelNome);
            Controls.Add(textBoxNome);
            Controls.Add(labelMatricula);
            Controls.Add(textBoxMatricula);
            Controls.Add(labelInicio);
            Controls.Add(dateTimePickerInicio);
            Controls.Add(labelFim);
            Controls.Add(dateTimePickerFim);
            Controls.Add(buttonSalvar);
            Controls.Add(buttonEscolherArquivo);
            Controls.Add(textBoxCaminhoArquivo);
            Controls.Add(labelTipo);
            Controls.Add(comboBoxTipo);
            Name = "Form1";
            Text = "Agendador de Férias";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        // Lógica para escolher o arquivo Markdown
        private void buttonEscolherArquivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos Markdown|*.md";
            openFileDialog.Title = "Escolha o arquivo Markdown";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxCaminhoArquivo.Text = openFileDialog.FileName;
            }
        }


        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text.Trim();
            string matricula = textBoxMatricula.Text.Trim();
            DateTime inicio = dateTimePickerInicio.Value.Date;
            DateTime fim = dateTimePickerFim.Value.Date;
            string caminhoArquivo = textBoxCaminhoArquivo.Text.Trim();

            if (string.IsNullOrEmpty(caminhoArquivo) || !File.Exists(caminhoArquivo))
            {
                MessageBox.Show("Selecione um arquivo Markdown válido.");
                return;
            }

            if (inicio > fim)
            {
                MessageBox.Show("A data de início não pode ser maior que a data de fim.");
                return;
            }

            string markdown = File.ReadAllText(caminhoArquivo);

            DateTime atual = new DateTime(inicio.Year, inicio.Month, 1);
            while (atual <= fim)
            {
                string mesAno = $"{CultureInfo.GetCultureInfo("pt-BR").DateTimeFormat.GetMonthName(atual.Month)} {atual.Year}";
                string tagCabecalho = $"## {mesAno}";

                if (!markdown.Contains(tagCabecalho))
                {
                    MessageBox.Show($"Tabela para {mesAno} não encontrada.");
                    atual = atual.AddMonths(1);
                    continue;
                }

                string tipoSelecionado = comboBoxTipo.SelectedItem.ToString();
                string caracterePreenchimento = tipoSelecionado switch
                {
                    "Férias" => " █ ",
                    "APIP" => " ■ ",
                    "Compensação" => " ◆ ",
                    _ => " █ "
                };

                markdown = AtualizarTabelaMes(markdown, tagCabecalho, nome, matricula, inicio, fim, atual, caracterePreenchimento);
                atual = atual.AddMonths(1);
            }

            File.WriteAllText(caminhoArquivo, markdown, Encoding.UTF8);
            MessageBox.Show("Férias salvas com sucesso!");
        }

        private string AtualizarTabelaMes(string markdown, string tagCabecalho, string nome, string matricula, DateTime inicio, DateTime fim, DateTime mesAlvo, string caractere)
        {
            int inicioTag = markdown.IndexOf(tagCabecalho);
            int proximoCabecalho = markdown.IndexOf("## ", inicioTag + tagCabecalho.Length);
            if (proximoCabecalho == -1) proximoCabecalho = markdown.Length;

            string bloco = markdown.Substring(inicioTag, proximoCabecalho - inicioTag);
            string[] linhas = bloco.Split('\n');

            int linhaCabecalhoIndex = Array.FindIndex(linhas, l => l.TrimStart().StartsWith("| Nome"));
            int linhaTracoIndex = linhaCabecalhoIndex + 1;
            if (linhaCabecalhoIndex < 0 || linhaTracoIndex >= linhas.Length) return markdown;

            string linhaCabecalho = linhas[linhaCabecalhoIndex];
            string linhaTracos = linhas[linhaTracoIndex];
            int totalDias = linhaCabecalho.Split('|').Count(c => c.Trim().Length == 2);

            List<string> novaTabela = new List<string>();
            novaTabela.Add(""); // garante linha em branco antes
            novaTabela.Add(tagCabecalho);
            novaTabela.Add(linhaCabecalho);
            novaTabela.Add(linhaTracos);

            bool linhaAtualizada = false;
            int ultimaLinhaOcupada = linhaTracoIndex + 1;

            for (int i = linhaTracoIndex + 1; i < linhas.Length; i++)
            {
                if (!linhas[i].StartsWith("|") || string.IsNullOrWhiteSpace(linhas[i])) break;

                if (linhas[i].Contains(matricula))
                {
                    string novaLinha = AtualizarLinha(linhas[i], inicio, fim, mesAlvo, caractere);
                    novaTabela.Add(novaLinha);
                    linhaAtualizada = true;
                }
                else
                {
                    novaTabela.Add(linhas[i]);
                }

                ultimaLinhaOcupada = i;
            }

            if (!linhaAtualizada)
            {
                string novaLinha = CriarLinhaNova(nome, matricula, linhaCabecalho, inicio, fim, mesAlvo, caractere);
                novaTabela.Add(novaLinha);
            }

            string novoBloco = string.Join("\n", novaTabela);
            string markdownNovo = markdown.Substring(0, inicioTag).TrimEnd() + "\n" + novoBloco + "\n" + markdown.Substring(proximoCabecalho).TrimStart();

            return markdownNovo;
        }

        private string AtualizarLinha(string linha, DateTime inicio, DateTime fim, DateTime mesRef, string caractere)
        {
            string[] colunas = linha.Split('|');
            int diasMes = DateTime.DaysInMonth(mesRef.Year, mesRef.Month);

            for (int i = 2; i < colunas.Length; i++)
            {
                if (int.TryParse(colunas[i].Trim(), out _)) continue;

                int diaColuna = i - 2;
                if (diaColuna >= 1 && diaColuna <= diasMes)
                {
                    DateTime diaAtual = new DateTime(mesRef.Year, mesRef.Month, diaColuna);
                    if (diaAtual >= inicio && diaAtual <= fim)
                    {
                        colunas[i] = " 🟩 ";
                    }
                }
            }

            return string.Join("|", colunas).TrimEnd() + "|";
        }

        private string CriarLinhaNova(string nome, string matricula, string linhaCabecalho, DateTime inicio, DateTime fim, DateTime mesRef, string caractere)
        {
            List<string> novaLinha = new List<string>
            {
                $"| {nome.PadRight(10)}",
                matricula.PadRight(7)
            };

            int diasMes = DateTime.DaysInMonth(mesRef.Year, mesRef.Month);

            for (int i = 1; i <= diasMes; i++)
            {
                DateTime diaAtual = new DateTime(mesRef.Year, mesRef.Month, i);
                if (diaAtual >= inicio && diaAtual <= fim)
                    novaLinha.Add(" 🟩 ");
                else
                    novaLinha.Add("    ");
            }

            return string.Join("|", novaLinha) + "|";
        }
        private PictureBox pictureBox1;
    }
}
