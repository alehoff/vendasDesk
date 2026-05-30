using WinFormsApp1.util;
using WinFormsApp1.view.fornecedor;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        private readonly FormService _formService;

        public Form1()
        {
            InitializeComponent();
            _formService = new FormService();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _formService.OpenPanel(PanelMenu, new FormMenuFornecedor());
        }
    }
}
