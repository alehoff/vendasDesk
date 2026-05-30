using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.model.dao;

namespace WinFormsApp1.view.fornecedor
{
    public partial class FormListagem : Form
    {
        private readonly FornecedorDao fornecedorDao;
        public FormListagem()
        {
            InitializeComponent();
            fornecedorDao = new FornecedorDao();
            MessageBox.Show($"total de fornecedores {fornecedorDao.ListaFornecedores().Count}");
        }
    }
}
