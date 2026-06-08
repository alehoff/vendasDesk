using WinFormsApp1.model.dao;
using WinFormsApp1.model.entidade;

namespace WinFormsApp1.view.fornecedor
{
    public partial class FormListagem : Form
    {
        private readonly FornecedorDao fornecedorDao;
        public FormListagem()
        {
            InitializeComponent();
            fornecedorDao = new FornecedorDao();
            AtualizaDataGridView();
        }

        private void AtualizaDataGridView()
        {
            DgvFornecedor.Rows.Clear();

            var fornecedores = fornecedorDao.ListaFornecedores();

            foreach (var fornecedor in fornecedores.Where(f => f.NomeFantasia.Contains(TxtFiltro.Text.Trim())))
            {
                DgvFornecedor.Rows.Add(
                    fornecedor.Id,
                    fornecedor.NomeFantasia,
                    fornecedor.RazaoSocial,
                    fornecedor.Contato.WhatsApp);
            }

        }

        private void ButonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Fornecedor fornecedor = new();

                using (var form = new FormCadastroFornecedor(fornecedor))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        if (fornecedor.Id > 0)
                        {
                            fornecedorDao.Editar(fornecedor);
                        }
                        else
                        {
                            fornecedorDao.Salvar(fornecedor);
                        }

                        AtualizaDataGridView();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
