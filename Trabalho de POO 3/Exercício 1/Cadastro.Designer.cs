namespace POO_LAB_03
{
    partial class AlunoMateria
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPages = new System.Windows.Forms.TabControl();
            this.tabAluno = new System.Windows.Forms.TabPage();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonCadastrarAluno = new System.Windows.Forms.Button();
            this.comboBoxMaterias = new System.Windows.Forms.ComboBox();
            this.comboBoxAluno = new System.Windows.Forms.ComboBox();
            this.textBoxMatricula = new System.Windows.Forms.TextBox();
            this.textBoxPeriodo = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelMaterias = new System.Windows.Forms.Label();
            this.labelAluno = new System.Windows.Forms.Label();
            this.labelMatricula = new System.Windows.Forms.Label();
            this.labelPeriodo = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.tabMateria = new System.Windows.Forms.TabPage();
            this.buttonRegistrarMateria = new System.Windows.Forms.Button();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.textBoxMateria = new System.Windows.Forms.TextBox();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelMateria = new System.Windows.Forms.Label();
            this.tabRelatorio = new System.Windows.Forms.TabPage();
            this.textBoxRelatorio = new System.Windows.Forms.TextBox();
            this.buttonImprimir = new System.Windows.Forms.Button();
            this.comboBoxRelatorio = new System.Windows.Forms.ComboBox();
            this.labelAlunoRel = new System.Windows.Forms.Label();
            this.tabPages.SuspendLayout();
            this.tabAluno.SuspendLayout();
            this.tabMateria.SuspendLayout();
            this.tabRelatorio.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPages
            // 
            this.tabPages.Controls.Add(this.tabAluno);
            this.tabPages.Controls.Add(this.tabMateria);
            this.tabPages.Controls.Add(this.tabRelatorio);
            this.tabPages.Location = new System.Drawing.Point(28, 13);
            this.tabPages.Margin = new System.Windows.Forms.Padding(4);
            this.tabPages.Name = "tabPages";
            this.tabPages.SelectedIndex = 0;
            this.tabPages.Size = new System.Drawing.Size(593, 246);
            this.tabPages.TabIndex = 0;
            // 
            // tabAluno
            // 
            this.tabAluno.Controls.Add(this.buttonAdicionar);
            this.tabAluno.Controls.Add(this.buttonCadastrarAluno);
            this.tabAluno.Controls.Add(this.comboBoxMaterias);
            this.tabAluno.Controls.Add(this.comboBoxAluno);
            this.tabAluno.Controls.Add(this.textBoxMatricula);
            this.tabAluno.Controls.Add(this.textBoxPeriodo);
            this.tabAluno.Controls.Add(this.textBoxNome);
            this.tabAluno.Controls.Add(this.labelMaterias);
            this.tabAluno.Controls.Add(this.labelAluno);
            this.tabAluno.Controls.Add(this.labelMatricula);
            this.tabAluno.Controls.Add(this.labelPeriodo);
            this.tabAluno.Controls.Add(this.labelNome);
            this.tabAluno.Location = new System.Drawing.Point(4, 25);
            this.tabAluno.Margin = new System.Windows.Forms.Padding(4);
            this.tabAluno.Name = "tabAluno";
            this.tabAluno.Padding = new System.Windows.Forms.Padding(4);
            this.tabAluno.Size = new System.Drawing.Size(585, 217);
            this.tabAluno.TabIndex = 0;
            this.tabAluno.Text = "Aluno";
            this.tabAluno.UseVisualStyleBackColor = true;
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(396, 143);
            this.buttonAdicionar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(119, 36);
            this.buttonAdicionar.TabIndex = 11;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.ButtonAdicionar_Click);
            // 
            // buttonCadastrarAluno
            // 
            this.buttonCadastrarAluno.Location = new System.Drawing.Point(131, 143);
            this.buttonCadastrarAluno.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCadastrarAluno.Name = "buttonCadastrarAluno";
            this.buttonCadastrarAluno.Size = new System.Drawing.Size(119, 36);
            this.buttonCadastrarAluno.TabIndex = 10;
            this.buttonCadastrarAluno.Text = "Cadastrar";
            this.buttonCadastrarAluno.UseVisualStyleBackColor = true;
            this.buttonCadastrarAluno.Click += new System.EventHandler(this.ButtonSalvarAluno_Click);
            // 
            // comboBoxMaterias
            // 
            this.comboBoxMaterias.FormattingEnabled = true;
            this.comboBoxMaterias.Location = new System.Drawing.Point(355, 57);
            this.comboBoxMaterias.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxMaterias.Name = "comboBoxMaterias";
            this.comboBoxMaterias.Size = new System.Drawing.Size(160, 24);
            this.comboBoxMaterias.TabIndex = 9;
            // 
            // comboBoxAluno
            // 
            this.comboBoxAluno.FormattingEnabled = true;
            this.comboBoxAluno.Location = new System.Drawing.Point(355, 15);
            this.comboBoxAluno.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxAluno.Name = "comboBoxAluno";
            this.comboBoxAluno.Size = new System.Drawing.Size(160, 24);
            this.comboBoxAluno.TabIndex = 8;
            this.comboBoxAluno.SelectedIndexChanged += new System.EventHandler(this.ComboBoxAluno_SelectedIndexChanged);
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.Location = new System.Drawing.Point(89, 89);
            this.textBoxMatricula.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.Size = new System.Drawing.Size(159, 22);
            this.textBoxMatricula.TabIndex = 7;
            // 
            // textBoxPeriodo
            // 
            this.textBoxPeriodo.Location = new System.Drawing.Point(89, 52);
            this.textBoxPeriodo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPeriodo.Name = "textBoxPeriodo";
            this.textBoxPeriodo.Size = new System.Drawing.Size(159, 22);
            this.textBoxPeriodo.TabIndex = 6;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(89, 15);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(159, 22);
            this.textBoxNome.TabIndex = 5;
            // 
            // labelMaterias
            // 
            this.labelMaterias.AutoSize = true;
            this.labelMaterias.Location = new System.Drawing.Point(269, 60);
            this.labelMaterias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaterias.Name = "labelMaterias";
            this.labelMaterias.Size = new System.Drawing.Size(66, 17);
            this.labelMaterias.TabIndex = 4;
            this.labelMaterias.Text = "Matérias:";
            // 
            // labelAluno
            // 
            this.labelAluno.AutoSize = true;
            this.labelAluno.Location = new System.Drawing.Point(269, 18);
            this.labelAluno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAluno.Name = "labelAluno";
            this.labelAluno.Size = new System.Drawing.Size(48, 17);
            this.labelAluno.TabIndex = 3;
            this.labelAluno.Text = "Aluno:";
            // 
            // labelMatricula
            // 
            this.labelMatricula.AutoSize = true;
            this.labelMatricula.Location = new System.Drawing.Point(8, 92);
            this.labelMatricula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMatricula.Name = "labelMatricula";
            this.labelMatricula.Size = new System.Drawing.Size(69, 17);
            this.labelMatricula.TabIndex = 2;
            this.labelMatricula.Text = "Matrícula:";
            // 
            // labelPeriodo
            // 
            this.labelPeriodo.AutoSize = true;
            this.labelPeriodo.Location = new System.Drawing.Point(8, 55);
            this.labelPeriodo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPeriodo.Name = "labelPeriodo";
            this.labelPeriodo.Size = new System.Drawing.Size(61, 17);
            this.labelPeriodo.TabIndex = 1;
            this.labelPeriodo.Text = "Período:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(8, 18);
            this.labelNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(49, 17);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome:";
            // 
            // tabMateria
            // 
            this.tabMateria.Controls.Add(this.buttonRegistrarMateria);
            this.tabMateria.Controls.Add(this.textBoxCodigo);
            this.tabMateria.Controls.Add(this.textBoxMateria);
            this.tabMateria.Controls.Add(this.labelCodigo);
            this.tabMateria.Controls.Add(this.labelMateria);
            this.tabMateria.Location = new System.Drawing.Point(4, 25);
            this.tabMateria.Margin = new System.Windows.Forms.Padding(4);
            this.tabMateria.Name = "tabMateria";
            this.tabMateria.Padding = new System.Windows.Forms.Padding(4);
            this.tabMateria.Size = new System.Drawing.Size(585, 217);
            this.tabMateria.TabIndex = 1;
            this.tabMateria.Text = "Matéria";
            this.tabMateria.UseVisualStyleBackColor = true;
            // 
            // buttonRegistrarMateria
            // 
            this.buttonRegistrarMateria.Location = new System.Drawing.Point(215, 101);
            this.buttonRegistrarMateria.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRegistrarMateria.Name = "buttonRegistrarMateria";
            this.buttonRegistrarMateria.Size = new System.Drawing.Size(100, 28);
            this.buttonRegistrarMateria.TabIndex = 4;
            this.buttonRegistrarMateria.Text = "Registrar";
            this.buttonRegistrarMateria.UseVisualStyleBackColor = true;
            this.buttonRegistrarMateria.Click += new System.EventHandler(this.ButtonSalvarMateria_Click);
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(89, 58);
            this.textBoxCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(224, 22);
            this.textBoxCodigo.TabIndex = 3;
            // 
            // textBoxMateria
            // 
            this.textBoxMateria.Location = new System.Drawing.Point(89, 18);
            this.textBoxMateria.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMateria.Name = "textBoxMateria";
            this.textBoxMateria.Size = new System.Drawing.Size(224, 22);
            this.textBoxMateria.TabIndex = 2;
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(11, 62);
            this.labelCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(56, 17);
            this.labelCodigo.TabIndex = 1;
            this.labelCodigo.Text = "Código:";
            // 
            // labelMateria
            // 
            this.labelMateria.AutoSize = true;
            this.labelMateria.Location = new System.Drawing.Point(8, 22);
            this.labelMateria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMateria.Name = "labelMateria";
            this.labelMateria.Size = new System.Drawing.Size(59, 17);
            this.labelMateria.TabIndex = 0;
            this.labelMateria.Text = "Matéria:";
            // 
            // tabRelatorio
            // 
            this.tabRelatorio.Controls.Add(this.textBoxRelatorio);
            this.tabRelatorio.Controls.Add(this.buttonImprimir);
            this.tabRelatorio.Controls.Add(this.comboBoxRelatorio);
            this.tabRelatorio.Controls.Add(this.labelAlunoRel);
            this.tabRelatorio.Location = new System.Drawing.Point(4, 25);
            this.tabRelatorio.Margin = new System.Windows.Forms.Padding(4);
            this.tabRelatorio.Name = "tabRelatorio";
            this.tabRelatorio.Padding = new System.Windows.Forms.Padding(4);
            this.tabRelatorio.Size = new System.Drawing.Size(585, 217);
            this.tabRelatorio.TabIndex = 2;
            this.tabRelatorio.Text = "Relatório";
            this.tabRelatorio.UseVisualStyleBackColor = true;
            // 
            // textBoxRelatorio
            // 
            this.textBoxRelatorio.Location = new System.Drawing.Point(29, 48);
            this.textBoxRelatorio.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRelatorio.Multiline = true;
            this.textBoxRelatorio.Name = "textBoxRelatorio";
            this.textBoxRelatorio.Size = new System.Drawing.Size(524, 158);
            this.textBoxRelatorio.TabIndex = 4;
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.Location = new System.Drawing.Point(444, 12);
            this.buttonImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size(111, 28);
            this.buttonImprimir.TabIndex = 2;
            this.buttonImprimir.Text = "Imprimir";
            this.buttonImprimir.UseVisualStyleBackColor = true;
            this.buttonImprimir.Click += new System.EventHandler(this.ButtonBuscar_Click);
            // 
            // comboBoxRelatorio
            // 
            this.comboBoxRelatorio.FormattingEnabled = true;
            this.comboBoxRelatorio.Location = new System.Drawing.Point(83, 15);
            this.comboBoxRelatorio.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxRelatorio.Name = "comboBoxRelatorio";
            this.comboBoxRelatorio.Size = new System.Drawing.Size(352, 24);
            this.comboBoxRelatorio.TabIndex = 1;
            // 
            // labelAlunoRel
            // 
            this.labelAlunoRel.AutoSize = true;
            this.labelAlunoRel.Location = new System.Drawing.Point(25, 18);
            this.labelAlunoRel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAlunoRel.Name = "labelAlunoRel";
            this.labelAlunoRel.Size = new System.Drawing.Size(48, 17);
            this.labelAlunoRel.TabIndex = 0;
            this.labelAlunoRel.Text = "Aluno:";
            // 
            // wfAlunoMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabPages);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "wfAlunoMateria";
            this.Text = "Cadastro Aluno/Matéria";
            this.tabPages.ResumeLayout(false);
            this.tabAluno.ResumeLayout(false);
            this.tabAluno.PerformLayout();
            this.tabMateria.ResumeLayout(false);
            this.tabMateria.PerformLayout();
            this.tabRelatorio.ResumeLayout(false);
            this.tabRelatorio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabAluno;
        private System.Windows.Forms.TabPage tabMateria;
        private System.Windows.Forms.TabPage tabRelatorio;
        private System.Windows.Forms.TabControl tabPages;
        private System.Windows.Forms.Label labelMaterias;
        private System.Windows.Forms.Label labelAluno;
        private System.Windows.Forms.Label labelMatricula;
        private System.Windows.Forms.Label labelPeriodo;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.ComboBox comboBoxMaterias;
        private System.Windows.Forms.ComboBox comboBoxAluno;
        private System.Windows.Forms.TextBox textBoxMatricula;
        private System.Windows.Forms.TextBox textBoxPeriodo;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonCadastrarAluno;
        private System.Windows.Forms.Button buttonRegistrarMateria;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.TextBox textBoxMateria;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelMateria;
        private System.Windows.Forms.ComboBox comboBoxRelatorio;
        private System.Windows.Forms.Label labelAlunoRel;
        private System.Windows.Forms.Button buttonImprimir;
        private System.Windows.Forms.TextBox textBoxRelatorio;
    }
}

