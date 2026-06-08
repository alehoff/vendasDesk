

using System.Text.RegularExpressions;
using ViaCep;
using WinFormsApp1.model.entidade;
using WinFormsApp1.model.@enum;

namespace WinFormsApp1.view.fornecedor
{
    public partial class FormCadastroFornecedor : Form
    {
        #region Inicialização tela

        public Fornecedor? Fornecedor { get; set; } = null!;

        public FormCadastroFornecedor(Fornecedor? fornecedor)
        {
            InitializeComponent();
            Fornecedor = fornecedor;
            AtualizaComboStatus();
        }

        #endregion

        #region Métodos Auxiliares
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

        #region Ação Usuario
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
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

    }
}
