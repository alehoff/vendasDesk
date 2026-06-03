namespace WinFormsApp1.view.fornecedor
{
    partial class FormMenuFornecedor
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            PanelListagem = new Panel();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1140, 767);
            tabControl1.TabIndex = 0;
            tabControl1.Selected += tabControl1_Selected;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(PanelListagem);
            tabPage1.Location = new Point(4, 33);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1132, 730);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Listagem";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // PanelListagem
            // 
            PanelListagem.Dock = DockStyle.Fill;
            PanelListagem.Location = new Point(3, 3);
            PanelListagem.Name = "PanelListagem";
            PanelListagem.Size = new Size(1126, 724);
            PanelListagem.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 33);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1108, 706);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // FormMenuFornecedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 767);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMenuFornecedor";
            ShowIcon = false;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel PanelListagem;
    }
}