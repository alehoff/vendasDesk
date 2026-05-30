using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.util;

namespace WinFormsApp1.view.fornecedor
{
    public partial class FormMenuFornecedor : Form
    {

        private readonly FormService _formService;
        public FormMenuFornecedor()
        {
            InitializeComponent();
            _formService = new FormService();
            _formService.OpenPanel(PanelListagem, new FormListagem());
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 0:
                    _formService.OpenPanel(PanelListagem, new FormListagem());
                    break;

                case 1:
                    //a definir
                    break;
            }
        }
    }
}
