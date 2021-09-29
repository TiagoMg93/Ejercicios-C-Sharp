using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;

namespace ExamenParcial
{
    public partial class FMRLavadero : Form
    {
        public FMRLavadero()
        {
            InitializeComponent();
        }
        public int pregunta = 0;
        private void CBEncargado_SelectedIndexChanged(object sender, EventArgs e)
        {
                TBPlaca.Enabled = true;
                TBVeh.Enabled = true;
                TBTipo.Enabled = true;
                TBServicio.Enabled = true;
                TBPrecio.Enabled = true;
                BTNGuardar.Enabled = true;
                BTNLimpiar.Enabled = true;
        }

        private void BTNAddEncargado_Click(object sender, EventArgs e)
        {
            if(CBEncargado.Text != "")
            {
                object add = CBEncargado.Text;
                CBEncargado.Items.Add(add);
                CBEncargado.ResetText();
            }
        }

        private void BTNRemEncargado_Click(object sender, EventArgs e)
        {
            object add = CBEncargado.Text;
            CBEncargado.Items.Remove(add);
            CBEncargado.ResetText();
            TBPlaca.Enabled = false;
            TBVeh.Enabled = false;
            TBTipo.Enabled = false;
            TBServicio.Enabled = false;
            TBPrecio.Enabled = false;
            BTNGuardar.Enabled = false;
            BTNLimpiar.Enabled = false;
        }

        private void BTNLimpiar_Click(object sender, EventArgs e)
        {
            TBPlaca.ResetText();
            TBVeh.ResetText();
            TBTipo.ResetText();
            TBServicio.ResetText();
            TBPrecio.ResetText();
        }

        private void BTNGuardar_Click(object sender, EventArgs e)
        {
            double ingresos = Convert.ToDouble(LBIngresos.Text);
            int clientes = DTGVDatos.Rows.Add();
            DialogResult consulta = MessageBox.Show("¿Está seguro de querer guardar?", "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(consulta == DialogResult.Yes)
            {
                DTGVDatos.Rows[clientes].Cells[0].Value = clientes+1;
                DTGVDatos.Rows[clientes].Cells[1].Value = CBEncargado.Text;
                DTGVDatos.Rows[clientes].Cells[2].Value = TBPlaca.Text;
                DTGVDatos.Rows[clientes].Cells[3].Value = TBVeh.Text;
                DTGVDatos.Rows[clientes].Cells[4].Value = TBTipo.Text;
                DTGVDatos.Rows[clientes].Cells[5].Value = TBServicio.Text;
                bool entrada = false;
                while (entrada == false)
                {
                    entrada = true;
                    try
                    {
                        double numero = Convert.ToDouble(TBPrecio.Text);
                    }
                    catch
                    {
                        entrada = false;
                        TBPrecio.Text = Interaction.InputBox("Error en el ingreso del precio, vuelva a ingresarlo", "PRECAUCION");
                    }
                }
                DTGVDatos.Rows[clientes].Cells[6].Value = TBPrecio.Text;
                clientes += 1;
                LBClientes.Text = Convert.ToString(clientes);
                ingresos += Convert.ToDouble(TBPrecio.Text);
                LBIngresos.Text = Convert.ToString(ingresos);
                TBPlaca.ResetText();
                TBVeh.ResetText();
                TBTipo.ResetText();
                TBServicio.ResetText();
                TBPrecio.ResetText();
                CBEncargado.ResetText();
                TBPlaca.Enabled = false;
                TBVeh.Enabled = false;
                TBTipo.Enabled = false;
                TBServicio.Enabled = false;
                TBPrecio.Enabled = false;
                BTNGuardar.Enabled = false;
                BTNLimpiar.Enabled = false;
                BTNEditar.Enabled = true;
            }
        }

        private void BTNEditar_Click(object sender, EventArgs e)
        {
            pregunta = Convert.ToInt32(Interaction.InputBox("Ingrese el Código del cliente que desea editar", "BUSQUEDA"));
            int cliente = int.Parse(LBClientes.Text);
            while (pregunta > cliente || pregunta < 0)
            {
                pregunta = Convert.ToInt32(Interaction.InputBox("EL Código ingresado no existe, por favor vuelva a ingresar", "ERROR"));
            }
            BTNGuardar.Enabled = false;
            BTNRemEncargado.Enabled = false;
            BTNAddEncargado.Enabled = false;
            BTNLimpiar.Enabled = false;
            BTNSalir.Enabled = true;
            BTNActualizar.Enabled = true;
            BTNBorrar.Enabled = true;
            TBPlaca.Enabled = true;
            TBVeh.Enabled = true;
            TBTipo.Enabled = true;
            TBServicio.Enabled = true;
            TBPrecio.Enabled = true;
            BTNEditar.Enabled = false;
            CBEncargado.Text = Convert.ToString(DTGVDatos.Rows[pregunta - 1].Cells[1].Value);
            TBPlaca.Text = Convert.ToString(DTGVDatos.Rows[pregunta - 1].Cells[2].Value);
            TBVeh.Text = Convert.ToString(DTGVDatos.Rows[pregunta - 1].Cells[3].Value);
            TBTipo.Text = Convert.ToString(DTGVDatos.Rows[pregunta - 1].Cells[4].Value);
            TBServicio.Text = Convert.ToString(DTGVDatos.Rows[pregunta - 1].Cells[5].Value);
            TBPrecio.Text = Convert.ToString(DTGVDatos.Rows[pregunta - 1].Cells[6].Value);
        }

        private void BTNSalir_Click(object sender, EventArgs e)
        {
            DialogResult consulta = MessageBox.Show("¿Está seguro de querer salir?", "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (consulta == DialogResult.Yes)
            {
                TBPlaca.ResetText();
                TBVeh.ResetText();
                TBTipo.ResetText();
                TBServicio.ResetText();
                TBPrecio.ResetText();
                CBEncargado.ResetText();
                BTNRemEncargado.Enabled = true;
                BTNAddEncargado.Enabled = true;
                TBPlaca.Enabled = false;
                TBVeh.Enabled = false;
                TBTipo.Enabled = false;
                TBServicio.Enabled = false;
                TBPrecio.Enabled = false;
                BTNBorrar.Enabled = false;
                BTNActualizar.Enabled = false;
                BTNLimpiar.Enabled = false;
            }
        }

        private void BTNActualizar_Click(object sender, EventArgs e)
        {
            DialogResult consulta = MessageBox.Show("¿Está seguro que desea MODIFICAR esta información?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (consulta == DialogResult.Yes)
            {
                double ingresos = Convert.ToDouble(LBIngresos.Text);
                ingresos -= Convert.ToDouble(DTGVDatos.Rows[pregunta - 1].Cells[6].Value);
                DTGVDatos.Rows[pregunta - 1].Cells[1].Value = CBEncargado.Text;
                DTGVDatos.Rows[pregunta - 1].Cells[2].Value = TBPlaca.Text;
                DTGVDatos.Rows[pregunta - 1].Cells[3].Value = TBVeh.Text;
                DTGVDatos.Rows[pregunta - 1].Cells[4].Value = TBTipo.Text;
                DTGVDatos.Rows[pregunta - 1].Cells[5].Value = TBServicio.Text;
                bool entrada = false;
                while (entrada == false)
                {
                    entrada = true;
                    try
                    {
                        double numero = Convert.ToDouble(TBPrecio.Text);
                    }
                    catch
                    {
                        entrada = false;
                        TBPrecio.Text = Interaction.InputBox("Error en el ingreso del precio, vuelva a ingresarlo", "PRECAUCION");
                    }
                }
                DTGVDatos.Rows[pregunta - 1].Cells[6].Value = TBPrecio.Text;
                ingresos += Convert.ToDouble(TBPrecio.Text);
                LBIngresos.Text = Convert.ToString(ingresos);
                TBPlaca.ResetText();
                TBVeh.ResetText();
                TBTipo.ResetText();
                TBServicio.ResetText();
                TBPrecio.ResetText();
                CBEncargado.ResetText();
                BTNRemEncargado.Enabled = true;
                BTNAddEncargado.Enabled = true;
                TBPlaca.Enabled = false;
                TBVeh.Enabled = false;
                TBTipo.Enabled = false;
                TBServicio.Enabled = false;
                TBPrecio.Enabled = false;
                BTNBorrar.Enabled = false;
                BTNActualizar.Enabled = false;
                BTNLimpiar.Enabled = false;
                BTNSalir.Enabled = false;
                BTNEditar.Enabled = false;
            }
        }

        private void BTNBorrar_Click(object sender, EventArgs e)
        {
            DialogResult consulta = MessageBox.Show("¿Está seguro que desea BORRAR esta información?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (consulta == DialogResult.Yes)
            {
                double ingresos = Convert.ToDouble(LBIngresos.Text);
                ingresos -= Convert.ToDouble(DTGVDatos.Rows[pregunta - 1].Cells[6].Value);
                int cliente = int.Parse(LBClientes.Text);
                cliente -= 1;
                LBClientes.Text = Convert.ToString(cliente);
                LBIngresos.Text = Convert.ToString(ingresos);
                DTGVDatos.Rows.RemoveAt(pregunta - 1);
                for(int  i = 0;i < int.Parse(LBClientes.Text); i++)
                {
                    DTGVDatos.Rows[i].Cells[0].Value = i + 1;
                }
                TBPlaca.ResetText();
                TBVeh.ResetText();
                TBTipo.ResetText();
                TBServicio.ResetText();
                TBPrecio.ResetText();
                CBEncargado.ResetText();
                BTNRemEncargado.Enabled = true;
                BTNAddEncargado.Enabled = true;
                TBPlaca.Enabled = false;
                TBVeh.Enabled = false;
                TBTipo.Enabled = false;
                TBServicio.Enabled = false;
                TBPrecio.Enabled = false;
                BTNBorrar.Enabled = false;
                BTNActualizar.Enabled = false;
                BTNLimpiar.Enabled = false;
                BTNSalir.Enabled = false;
                BTNEditar.Enabled = false;
            }
        }

        private void BTNCargar_Click(object sender, EventArgs e)
        {
            DialogResult consulta = MessageBox.Show("¿Desea cargar un archivo?", "STOP", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (consulta == DialogResult.Yes)
            {
                
            }
        }

        private void BTNCerrar_Click(object sender, EventArgs e)
        {
            DialogResult consulta = MessageBox.Show("¿Está seguro de querer cerrar la APP?", "STOP", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (consulta == DialogResult.Yes)
            {
                 bool salir = true;
                 try
                 {
                     GuardarDatos();
                 }
                 catch
                 {
                     salir = false;
                     DialogResult salida = MessageBox.Show("Los datos NO fueron guardados ¿Seguro que desea CERRAR?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                     if (salida == DialogResult.Yes)
                     {
                         this.Close();
                     }
                 }
                 if(salir == true)
                 {
                     MessageBox.Show("Los datos se han guardado exitosamente", "MENSAJE");
                     this.Close();
                 }
                this.Close();
            }
        }

        private void FMRLavadero_Load(object sender, EventArgs e)
        {

        }
        private void GuardarDatos()
        {
            string ruta = AppDomain.CurrentDomain.BaseDirectory + "/datoss.txt";
            using (var WriteText = new StreamWriter(ruta))
            {
                foreach (DataGridViewRow row in DTGVDatos.Rows)
                {
                    WriteText.WriteLine($"{row.Cells[0].Value},{row.Cells[1].Value},{row.Cells[2].Value},{row.Cells[3].Value},{row.Cells[4].Value},{row.Cells[5].Value},{row.Cells[6].Value}");
                }
            }
        }
    }
}
