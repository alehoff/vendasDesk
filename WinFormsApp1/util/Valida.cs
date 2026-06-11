using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WinFormsApp1.util
{
    public class Valida
    {
        public static bool Validar<T>(T t)
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

                MessageBox.Show(sb.ToString());
                return false;
            }
            return true;
        }

    }
}
