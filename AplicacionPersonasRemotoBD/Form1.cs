using ClosedXML.Excel;
using System.Data;
using System.Diagnostics;
using System.Drawing.Text;

namespace AplicacionPersonasRemotoBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtID.Enabled = true;
            TxtNombre.Enabled = true;
            TxtTelefono.Enabled = true;

            //limpiar contenido
            TxtID.Clear();
            TxtNombre.Clear();
            TxtTelefono.Clear();

            //habilito el guardar y cancelar
            BtnGuardar.Enabled = true;
            BtnCancelar.Enabled = true;

            //desahilito los demas
            BtnNuevo.Enabled = false;
            BtnEditar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnSalir.Enabled = false;

            //mando el foco al txtID
            TxtID.Focus();


        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {

            TxtID.Enabled = false;
            TxtNombre.Enabled = false;
            TxtTelefono.Enabled = false;

            //limpiar contenido
            TxtID.Clear();
            TxtNombre.Clear();
            TxtTelefono.Clear();

            //desabilito el guardar y cancelar
            BtnGuardar.Enabled = false;
            BtnCancelar.Enabled = false;

            //habilito los demas
            BtnNuevo.Enabled = true;
            BtnEditar.Enabled = true;
            BtnEliminar.Enabled = true;
            BtnSalir.Enabled = true;

            //mando el foco al Nuevo
            BtnNuevo.Focus();


        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            //creo un DialogResult
            DialogResult Respuesta = new DialogResult();
            Respuesta = MessageBox.Show("Desea Salir de la Aplicacion ?", "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (Respuesta == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //valido que el usuario llene los datos
            if (TxtID.Text.Length > 0 && TxtNombre.Text.Length > 0 && TxtTelefono.Text.Length > 0)
            {
                //inserta cuando el ID esta HABILITADO
                if (TxtID.Enabled == true)
                {
                    if (ClaseFunciones.Func_Insertar(Convert.ToInt64(TxtID.Text), TxtNombre.Text, TxtTelefono.Text))
                    {
                        MessageBox.Show("Persona Agregada", "Felicitaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        DataTable dt = new DataTable();
                        dt = ClaseFunciones.Func_TraerDatos();
                        //muestro los datos
                        DgvPersonas.DataSource = dt;

                        BtnCancelar_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Hubo una excepcion " + ClaseFunciones.excepcion, "Excepcion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //editar
                    if (ClaseFunciones.Func_Editar(Convert.ToInt64(TxtID.Text), TxtNombre.Text, TxtTelefono.Text))
                    {
                        MessageBox.Show("Persona Editada", "Felicitaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        DataTable dt = new DataTable();
                        dt = ClaseFunciones.Func_TraerDatos();
                        //muestro los datos
                        DgvPersonas.DataSource = dt;

                        BtnCancelar_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Hubo una excepcion " + ClaseFunciones.excepcion, "Excepcion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            else
            {
                MessageBox.Show("Falta ingresar Datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //capturo el ID del DataGrid
            long idEliminar = Convert.ToInt64(DgvPersonas.CurrentRow.Cells["ID"].Value.ToString());
            //pregunto si quiere eliminar
            DialogResult Respuesta = new DialogResult();
            Respuesta = MessageBox.Show($"Desea eliminar el ID {idEliminar}?", "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Respuesta == DialogResult.OK)
            {
                if (ClaseFunciones.Func_Eliminar(idEliminar))
                {
                    MessageBox.Show("Persona Eliminada", "Felicitaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataTable dt = new DataTable();
                    dt = ClaseFunciones.Func_TraerDatos();
                    //muestro los datos
                    DgvPersonas.DataSource = dt;

                    BtnCancelar_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Hubo una excepcion " + ClaseFunciones.excepcion, "Excepcion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            //habilito los texbox menos el ID
            TxtID.Enabled = false;
            TxtNombre.Enabled = true;
            TxtTelefono.Enabled = true;

            //capturar datos del DataGridView
            TxtID.Text = DgvPersonas.CurrentRow.Cells["ID"].Value.ToString();
            TxtNombre.Text = DgvPersonas.CurrentRow.Cells["Nombre"].Value.ToString();
            TxtTelefono.Text = DgvPersonas.CurrentRow.Cells["Telefono"].Value.ToString();

            //habilito el guardar y cancelar
            BtnGuardar.Enabled = true;
            BtnCancelar.Enabled = true;

            //desahilito los demas
            BtnNuevo.Enabled = false;
            BtnEditar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnSalir.Enabled = false;

            //mando el foco al txtNombre
            TxtNombre.Focus();

        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font fuente = new Font("Courier New", 13, FontStyle.Bold);
            DataTable dt = new DataTable();
            dt = ClaseFunciones.Func_TraerDatos();
            e.Graphics.DrawString("Listado Personas", fuente, new SolidBrush(Color.Black), new PointF(300, 10));
            e.Graphics.DrawString("ID", fuente, new SolidBrush(Color.Black), new PointF(50, 50));

            int fila = 80;
            //recorro la tabla
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                long id = Convert.ToInt64(dt.Rows[i]["ID"].ToString());
                string name = dt.Rows[i]["Nombre"].ToString();
                string tel = dt.Rows[i]["Telefono"].ToString();
                e.Graphics.DrawString(id.ToString(), fuente, new SolidBrush(Color.Black), new PointF(50, fila));
                fila += 20;
            }

            //Final de linea
            e.HasMorePages = false;

        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {
            bool resultado = ClaseFunciones.Func_ExportalExcel(); 

            if (resultado)
            {
                Process p = new Process()
                {
                    StartInfo = new ProcessStartInfo(@"C:\PruebaExcel.xlsx")
                    { UseShellExecute = true }
                };
                p.Start();
            }
            else
            {
                MessageBox.Show("Excepcion:" + ClaseFunciones.excepcion);
            }
                
        }
    }
}
