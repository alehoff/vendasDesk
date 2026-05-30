
using System.Windows.Forms;

namespace WinFormsApp1.util
{
    public class FormService
    {
        public void OpenPanel(Panel panel1, object obj)
        {
            if (panel1.Controls.Count > 0)
            {
                panel1.Controls.RemoveAt(0);
            }
            Form f = obj as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panel1.Controls.Add(f);
            panel1.Tag = f;
            f.Show();
        }
    }
}
