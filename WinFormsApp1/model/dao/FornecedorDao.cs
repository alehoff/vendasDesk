using Microsoft.EntityFrameworkCore;
using WinFormsApp1.database;
using WinFormsApp1.model.entidade;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace WinFormsApp1.model.dao
{
    public class FornecedorDao
    {
        public List<Fornecedor> ListaFornecedores()
        {
            using (var contexto = new AppDbContext())
            {
                var itens = contexto
                 .Fornecedores
                 .Include(f => f.Contato)
                 .Include(f => f.Endereco)
                 .OrderBy(f => f.NomeFantasia)
                 .ThenBy(f => f.Endereco.Bairro);

                Console.WriteLine(itens.ToQueryString()); // Prints raw SQL

                return itens.ToList();
            }

        }

    }
}
