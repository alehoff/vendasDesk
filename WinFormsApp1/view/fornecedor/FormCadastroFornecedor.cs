using WinFormsApp1.model.entidade;

namespace WinFormsApp1.view.fornecedor
{
    public partial class FormCadastroFornecedor : Form
    {

        public Fornecedor? Fornecedor { get; set; } = null!;

        public FormCadastroFornecedor()
        {
            InitializeComponent();
        }

       
    }
}
