using Microsoft.EntityFrameworkCore;
using WinFormsApp1.database;
using WinFormsApp1.model.entidade;

namespace WinFormsApp1.model.dao
{
    public class FornecedorDao
    {
        public List<Fornecedor> ListaFornecedores()
        {
            try
            {
                using (var contexto = new AppDbContext())
                {
                    return contexto
                      .Fornecedores
                      .Include(f => f.Contato)
                      .OrderBy(f => f.NomeFantasia)
                      .ThenBy(f => f.Endereco.Bairro)
                      .ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        public Fornecedor LocalizaPeloId(int id)
        {
            using (var contexto = new AppDbContext())
            {
                return contexto.Fornecedores
                    .Include(f => f.Contato)
                    .Include(f => f.Endereco)
                    .Where(f => f.Id == id)
                    .Single();
            }
        }

        public void Salvar(Fornecedor fornecedor)
        {
            try
            {
                using (var contexto = new AppDbContext())
                {
                    contexto.Fornecedores.Add(fornecedor);
                    contexto.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Editar(Fornecedor fornecedor)
        {
            try
            {
                using (var contexto = new AppDbContext())
                {
                    contexto.Fornecedores.Update(fornecedor);//contexto.Entry(LocalizaPeloId(fornecedor.Id)).CurrentValues.SetValues(fornecedor);
                    contexto.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
