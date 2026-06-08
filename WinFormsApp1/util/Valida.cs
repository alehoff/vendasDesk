using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WinFormsApp1.util
{
    public class Valida
    {
        public static void Validar<T>(T t)
        {
            var resultadoValidacao = new List<ValidationResult>();
            var contexto = new ValidationContext(t, null, null);
            StringBuilder sb = new StringBuilder();

            Validator.TryValidateObject(t, contexto, resultadoValidacao, true);

            if (resultadoValidacao.Count > 0)
            {
                foreach (var item in resultadoValidacao)
                {
                    sb.Append(item.ToString()).Append("\n");
                }

                throw new Exception(sb.ToString());
            }
        }

    }
}
