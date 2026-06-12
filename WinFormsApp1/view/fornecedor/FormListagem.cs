using WinFormsApp1.model.dao;
using WinFormsApp1.model.entidade;

namespace WinFormsApp1.view.fornecedor
{
    public partial class FormListagem : Form
    {
        private readonly FornecedorDao fornecedorDao;
        private List<Fornecedor>? fornecedorList;
        public FormListagem()
        {
            InitializeComponent();
            fornecedorDao = new FornecedorDao();
            AtualizaDataGridView(true);
        }

        private void AtualizaDataGridView(bool atualiza)
        {
            DgvFornecedor.Rows.Clear();

           fornecedorList = atualiza ? fornecedorDao.ListaFornecedores() : fornecedorList;

            foreach (var fornecedor in fornecedorList.Where(f => f.NomeFantasia.ToUpper().Contains(TxtFiltro.Text.ToUpper().Trim())))
            {
                DgvFornecedor.Rows.Add(
                    fornecedor.Id,
                    fornecedor.NomeFantasia,
                    fornecedor.RazaoSocial,
                    fornecedor.Contato.WhatsApp);
            }

        }

        private void AddFornecedor(Fornecedor fornecedor)
        {
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

                    AtualizaDataGridView(true);
                }
            }
        }

        private void ButonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                AddFornecedor(new Fornecedor());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DgvFornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                try
                {
                    int idFornecedor = Convert.ToInt32(DgvFornecedor.SelectedCells[0].Value);
                    Fornecedor fornecedor = fornecedorDao.LocalizaPeloId(idFornecedor);
                    AddFornecedor(fornecedor);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void TxtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            AtualizaDataGridView(false);
        }
    }
}
