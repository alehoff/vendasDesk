

using System.Text.RegularExpressions;
using ViaCep;
using WinFormsApp1.model.dao;
using WinFormsApp1.model.entidade;
using WinFormsApp1.model.@enum;
using WinFormsApp1.util;

namespace WinFormsApp1.view.fornecedor
{
    public partial class FormCadastroFornecedor : Form
    {
        #region Inicialização tela

        public Fornecedor Fornecedor { get; set; } = null!;
        public readonly FornecedorDao fornecedorDao = new FornecedorDao();

        public FormCadastroFornecedor(Fornecedor fornecedor)
        {
            InitializeComponent();
            Fornecedor = fornecedor;
            AtualizaComboStatus();
            AtualizaAtributosTela();
        }
        #endregion

        #region Ação Usuario

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                SalvarObjetoFornecedor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = DialogResult.Cancel;
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtCep_Leave(object sender, EventArgs e)
        {
            try
            {
                ConsultaCep();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Métodos Auxiliares

        private void SalvarObjetoFornecedor()
        {
            AtualizaAtributosObjeto();

            if (Valida.Validar(Fornecedor))
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void AtualizaAtributosObjeto()
        {
            Fornecedor.NomeFantasia = TxtNomeFantasia.Text;
            Fornecedor.RazaoSocial = TxtRazaoSocial.Text;
            Fornecedor.Cnpj = TxtCnpj.Text;
            Fornecedor.InscricaoEstadual = TxtInscricaoEstadual.Text;
            Fornecedor.Status = (Status)CboStatus.SelectedItem!;
            Fornecedor.Endereco.Cep = TxtCep.Text;
            Fornecedor.Endereco.Numero = TxtNumero.Text;
            Fornecedor.Endereco.Localizacao = TxtLocalizacao.Text;
            Fornecedor.Contato.WhatsApp = TxtWhatsApp.Text;
            Fornecedor.Contato.Email = TxtEmail.Text;
            Fornecedor.Contato.FoneComercial = TxtFoneComercial.Text;
            Fornecedor.Endereco.Logradouro = TxtLogradouro.Text;
            Fornecedor.Endereco.Bairro = TxtBairro.Text;
            Fornecedor.Endereco.Municipio = TxtMunicipio.Text;
            Fornecedor.Endereco.Uf = TxtUF.Text;
        }

        private void AtualizaAtributosTela()
        {
            TxtNomeFantasia.Text = Fornecedor.NomeFantasia;
            TxtRazaoSocial.Text = Fornecedor.RazaoSocial;
            TxtCnpj.Text = Fornecedor.Cnpj;
            TxtInscricaoEstadual.Text = Fornecedor.InscricaoEstadual;
            CboStatus.SelectedItem = Fornecedor.Status;
            TxtCep.Text = Fornecedor.Endereco.Cep;
            TxtNumero.Text = Fornecedor.Endereco.Numero;
            TxtLocalizacao.Text = Fornecedor.Endereco.Localizacao;
            TxtWhatsApp.Text = Fornecedor.Contato.WhatsApp;
            TxtEmail.Text = Fornecedor.Contato.Email;
            TxtFoneComercial.Text = Fornecedor.Contato.FoneComercial;
            TxtLogradouro.Text = Fornecedor.Endereco.Logradouro;
            TxtBairro.Text = Fornecedor.Endereco.Bairro;
            TxtMunicipio.Text = Fornecedor.Endereco.Municipio;
            TxtUF.Text = Fornecedor.Endereco.Uf;

            TxtNomeFantasia.Focus();
        }
        private void AtualizaComboStatus()
        {
            CboStatus.Items.Clear();
            CboStatus.DataSource = Enum.GetValues(typeof(Status));
            CboStatus.SelectedItem = Status.Ativo;

        }
        private void ConsultaCep()
        {

            if (TxtCep.Text.Count() == 8)
            {
                if (Regex.IsMatch(TxtCep.Text, "^[0-9]"))
                {
                    try
                    {
                        ViaCepResult Consulta = new ViaCepClient().Search(TxtCep.Text);
                        if (Consulta.City != null)
                        {
                            TxtBairro.Text = Consulta.Neighborhood;
                            TxtLogradouro.Text = Consulta.Street;
                            TxtMunicipio.Text = Consulta.City;
                            TxtUF.Text = Consulta.StateInitials;
                        }
                        else
                        {
                            TxtBairro.Clear();
                            TxtLogradouro.Clear();
                            TxtMunicipio.Clear();
                            TxtUF.Clear();
                            MessageBox.Show("Não foi possível realiza sua consulta");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("informe apenas valores numéricos");
                }
            }
        }

        #endregion



    }
}
