using WinFormsApp1.database;
using WinFormsApp1.model.entidade;

namespace WinFormsApp1.model.dao
{
    internal class FornecedorDao
    {
        
        public List<Fornecedor> ListaFornecedores()
        {
            using(var contexto = new AppDbContext())
            {
                return contexto.Fornecedores.OrderBy(f=>f.NomeFantasia).ToList();
            }
        }
       
    }
}
