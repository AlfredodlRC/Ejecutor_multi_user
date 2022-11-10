using System.Diagnostics;

namespace Ejecutor_multi_user
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void BtnEjecucion_Click(object sender, EventArgs e)
        {
            Process proceso = new Process();
            ProcessStartInfo inicializador = new ProcessStartInfo();
            proceso.Close();
        }
    }
}