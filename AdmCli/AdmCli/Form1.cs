using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdmCli
{
    public partial class FormAdmCli : Form
    {
        public FormAdmCli()
        {
            InitializeComponent();
        }

        string strNombre, strApellido, strFechaNacimiento, strDireccion;
        int IDCliente = 0;

        private void tsbtnGuardar_Click(object sender, EventArgs e)
        {
            strNombre = textBoxNom.Text;
            strApellido = textBoxAp.Text;
            strFechaNacimiento = dateTimePickerFechNac.Value.Year.ToString() + '/' + dateTimePickerFechNac.Value.Month.ToString() + '/' + dateTimePickerFechNac.Value.Day.ToString();
            strDireccion = textBoxDir.Text;

            SqlConnection conectar = new SqlConnection("Data Source=LAPTOP-QHC355DF\\SQLEXPRESS;Initial Catalog=Taller;Integrated Security=true;");
            
            if (IDCliente == 0)
            {
                string consultaN = string.Format("Insert into clientes (Nombre, Apellido, Fecha_Nacimiento, Direccion) values ('{0}','{1}','{2}','{3}')",
                    strNombre, strApellido, strFechaNacimiento, strDireccion);

                SqlCommand comandoN = new SqlCommand(consultaN, conectar);

                conectar.Open();
                comandoN.ExecuteNonQuery();
                conectar.Close();

                IDCliente = 0;

                System.Windows.Forms.MessageBox.Show(" Nuevo registro guardado con éxito.");

                refrescar.RefrescarCampos(groupBoxDatos);
                dgvBuscar.Columns.Clear();
            }

            else
            {
                string consultaU = string.Format("Update clientes set Nombre= '{0}', Apellido= '{1}', Fecha_Nacimiento= '{2}', Direccion= '{3}' where IDCliente = {4}",
                    strNombre, strApellido, strFechaNacimiento, strDireccion, IDCliente);

                SqlCommand comandoU = new SqlCommand(consultaU, conectar);

                conectar.Open();
                comandoU.ExecuteNonQuery();
                conectar.Close();

                IDCliente = 0;

                System.Windows.Forms.MessageBox.Show("Registro actualizado con éxito.");

                refrescar.RefrescarCampos(groupBoxDatos);
                dgvBuscar.Columns.Clear();
            }

        }

        class Refrescar
        {
            public void RefrescarCampos(GroupBox gb)
            {
                foreach (var campo in gb.Controls)
                {
                    if (campo is TextBox)
                    {
                        ((TextBox)campo).Clear();
                    }
                    else if (campo is DateTimePicker)
                    {
                        ((DateTimePicker)campo).ResetText();
                    }
                }
            }
            
        }

        Refrescar refrescar = new Refrescar();

        private void tsbtnCancelar_Click(object sender, EventArgs e)
        {
            refrescar.RefrescarCampos(groupBoxDatos);
            dgvBuscar.Columns.Clear();
            IDCliente = 0;
        }

        private void dgvBuscar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDCliente = Convert.ToInt32(dgvBuscar.CurrentRow.Cells[0].Value);
            textBoxNom.Text = Convert.ToString(dgvBuscar.CurrentRow.Cells[1].Value);
            textBoxAp.Text = Convert.ToString(dgvBuscar.CurrentRow.Cells[2].Value);
            dateTimePickerFechNac.Value = Convert.ToDateTime(dgvBuscar.CurrentRow.Cells[3].Value);
            textBoxDir.Text = Convert.ToString(dgvBuscar.CurrentRow.Cells[4].Value);
        }

        private void tsbtnBuscar_Click(object sender, EventArgs e)
        {
            strNombre = textBoxNom.Text;
            strApellido = textBoxAp.Text;
            strFechaNacimiento = dateTimePickerFechNac.Value.Year.ToString() + '/' + dateTimePickerFechNac.Value.Month.ToString() + '/' + dateTimePickerFechNac.Value.Day.ToString();
            strDireccion = textBoxDir.Text;
            
            List<Cliente> lista = new List<Cliente>();

            SqlConnection conectar = new SqlConnection("Data Source=LAPTOP-QHC355DF\\SQLEXPRESS;Initial Catalog=Taller;Integrated Security=true;");
            String consulta = string.Format("SELECT IdCliente, Nombre, Apellido, Fecha_Nacimiento, Direccion FROM clientes",
                    strNombre, strApellido, strFechaNacimiento, strDireccion);
            SqlCommand comando = new SqlCommand(consulta, conectar);

            conectar.Open();
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Cliente pCliente = new Cliente();
                pCliente.Id = reader.GetInt32(0);
                pCliente.Nombre = reader.GetString(1);
                pCliente.Apellido = reader.GetString(2);
                pCliente.Fecha_Nac = reader.GetString(3);
                pCliente.Direccion = reader.GetString(4);


                lista.Add(pCliente);

            }

            conectar.Close();
            dgvBuscar.DataSource = lista;

            refrescar.RefrescarCampos(groupBoxDatos);

        }

        private class Cliente
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Fecha_Nac { get; set; }
            public string Direccion { get; set; }
        }

    }
}
