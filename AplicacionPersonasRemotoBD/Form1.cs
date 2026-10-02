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
                MessageBox.Show("ERROR Excepcion: "+ClaseFunciones.excepcion);
            }
        }
    }
}
