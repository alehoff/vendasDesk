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
        }

        private void ButonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using(var form = new FormCadastroFornecedor())
                {
                    form.Fornecedor = new Fornecedor();
                    if (form.ShowDialog() == DialogResult.OK)
                    {

                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
