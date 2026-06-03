namespace WinFormsApp1.view.fornecedor
{
    partial class FormListagem
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
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            ColId = new DataGridViewTextBoxColumn();
            ColNomeFantasia = new DataGridViewTextBoxColumn();
            ColRazaoSocial = new DataGridViewTextBoxColumn();
            ColWhatsApp = new DataGridViewTextBoxColumn();
            tableLayoutPanel2 = new TableLayoutPanel();
            ButonAdd = new Button();
            label1 = new Label();
            TxtFiltro = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.72594738F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 92.2740555F));
            tableLayoutPanel1.Size = new Size(1056, 686);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColId, ColNomeFantasia, ColRazaoSocial, ColWhatsApp });
            dataGridView1.Location = new Point(3, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1050, 624);
            dataGridView1.TabIndex = 0;
            // 
            // ColId
            // 
            ColId.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ColId.HeaderText = "Id";
            ColId.MinimumWidth = 6;
            ColId.Name = "ColId";
            ColId.ReadOnly = true;
            ColId.Visible = false;
            ColId.Width = 125;
            // 
            // ColNomeFantasia
            // 
            ColNomeFantasia.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColNomeFantasia.HeaderText = "Nome Fantasia";
            ColNomeFantasia.MinimumWidth = 6;
            ColNomeFantasia.Name = "ColNomeFantasia";
            ColNomeFantasia.ReadOnly = true;
            // 
            // ColRazaoSocial
            // 
            ColRazaoSocial.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ColRazaoSocial.HeaderText = "Razão Social";
            ColRazaoSocial.MinimumWidth = 6;
            ColRazaoSocial.Name = "ColRazaoSocial";
            ColRazaoSocial.ReadOnly = true;
            ColRazaoSocial.Width = 123;
            // 
            // ColWhatsApp
            // 
            ColWhatsApp.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ColWhatsApp.HeaderText = "WhatsApp";
            ColWhatsApp.MinimumWidth = 6;
            ColWhatsApp.Name = "ColWhatsApp";
            ColWhatsApp.ReadOnly = true;
            ColWhatsApp.Width = 107;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.2142868F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.7857132F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 820F));
            tableLayoutPanel2.Controls.Add(ButonAdd, 0, 0);
            tableLayoutPanel2.Controls.Add(label1, 1, 0);
            tableLayoutPanel2.Controls.Add(TxtFiltro, 2, 0);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1050, 39);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // ButonAdd
            // 
            ButonAdd.Location = new Point(3, 3);
            ButonAdd.Name = "ButonAdd";
            ButonAdd.Size = new Size(94, 29);
            ButonAdd.TabIndex = 0;
            ButonAdd.Text = "Add";
            ButonAdd.UseVisualStyleBackColor = true;
            ButonAdd.Click += ButonAdd_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(113, 7);
            label1.Name = "label1";
            label1.Size = new Size(113, 25);
            label1.TabIndex = 2;
            label1.Text = "Filtrar:";
            // 
            // TxtFiltro
            // 
            TxtFiltro.Location = new Point(232, 3);
            TxtFiltro.Name = "TxtFiltro";
            TxtFiltro.Size = new Size(654, 27);
            TxtFiltro.TabIndex = 1;
            // 
            // FormListagem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 710);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormListagem";
            Text = "FormListagem";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button ButonAdd;
        private TextBox TxtFiltro;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColNomeFantasia;
        private DataGridViewTextBoxColumn ColRazaoSocial;
        private DataGridViewTextBoxColumn ColWhatsApp;
        private Label label1;
    }
}