using System.Data;

namespace AplicacionPersonasRemotoBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            if (ClaseFunciones.Funcion_Conectar())
            {
                MessageBox.Show("Conextado a SQL SERVER Remoto", "FELICIDADES!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ERROR Excepcion: " + ClaseFunciones.excepcion);
            }
        }

        private void TxtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ClaseFunciones.Func_TraerDatos();
            //muestro los datos
            DgvPersonas.DataSource = dt;


        }
    }
}
