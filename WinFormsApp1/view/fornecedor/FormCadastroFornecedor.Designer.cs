namespace WinFormsApp1.view.fornecedor
{
    partial class FormCadastroFornecedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label1 = new Label();
            TxtNomeFantasia = new TextBox();
            TxtRazaoSocial = new TextBox();
            label2 = new Label();
            TxtCnpj = new TextBox();
            label3 = new Label();
            TxtInscricaoEstadual = new TextBox();
            label4 = new Label();
            CboStatus = new ComboBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(CboStatus);
            groupBox1.Controls.Add(TxtInscricaoEstadual);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(TxtCnpj);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TxtRazaoSocial);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TxtNomeFantasia);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1109, 186);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Fornecedor";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(26, 38);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome Fantasia";
            // 
            // TxtNomeFantasia
            // 
            TxtNomeFantasia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtNomeFantasia.Location = new Point(26, 61);
            TxtNomeFantasia.Name = "TxtNomeFantasia";
            TxtNomeFantasia.Size = new Size(429, 27);
            TxtNomeFantasia.TabIndex = 1;
            // 
            // TxtRazaoSocial
            // 
            TxtRazaoSocial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtRazaoSocial.Location = new Point(485, 61);
            TxtRazaoSocial.Name = "TxtRazaoSocial";
            TxtRazaoSocial.Size = new Size(429, 27);
            TxtRazaoSocial.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(485, 38);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 2;
            label2.Text = "Razão Social";
            // 
            // TxtCnpj
            // 
            TxtCnpj.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtCnpj.Location = new Point(26, 128);
            TxtCnpj.Name = "TxtCnpj";
            TxtCnpj.Size = new Size(429, 27);
            TxtCnpj.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(26, 105);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 4;
            label3.Text = "Cnpj";
            // 
            // TxtInscricaoEstadual
            // 
            TxtInscricaoEstadual.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtInscricaoEstadual.Location = new Point(485, 128);
            TxtInscricaoEstadual.Name = "TxtInscricaoEstadual";
            TxtInscricaoEstadual.Size = new Size(429, 27);
            TxtInscricaoEstadual.TabIndex = 7;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(485, 105);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 6;
            label4.Text = "Inscrição Estadual";
            // 
            // CboStatus
            // 
            CboStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CboStatus.FormattingEnabled = true;
            CboStatus.Location = new Point(932, 128);
            CboStatus.Name = "CboStatus";
            CboStatus.Size = new Size(162, 28);
            CboStatus.TabIndex = 8;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(932, 105);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 9;
            label5.Text = "Status";
            // 
            // FormCadastroFornecedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1133, 723);
            Controls.Add(groupBox1);
            Name = "FormCadastroFornecedor";
            Text = "FormCadastroFornecedor";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private ComboBox CboStatus;
        private TextBox TxtInscricaoEstadual;
        private Label label4;
        private TextBox TxtCnpj;
        private Label label3;
        private TextBox TxtRazaoSocial;
        private Label label2;
        private TextBox TxtNomeFantasia;
        private Label label1;
    }
}