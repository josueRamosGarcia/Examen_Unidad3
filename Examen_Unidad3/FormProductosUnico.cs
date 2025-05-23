using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Unidad3
{
    public partial class FormProductosUnico : Form
    {

        int id = 0;
        bool bandera;

        public FormProductosUnico() // INSERTAR
        {
            InitializeComponent();
            txtID.Enabled =false;
            bandera = false;
        }

        public FormProductosUnico( // ACTUALIZAR
            int id, string nombre, string descripcion, string precio,
            string stock, string categoria, string fecha
        )
        {
            InitializeComponent();
            this.id = id;
            txtNombre.Text = nombre;
            txtDescripcion.Text = descripcion;
            txtPrecio.Text = precio;
            txtStock.Text = stock;
            txtCategoria.Text = categoria;
            dtpFecha.Value = DateTime.Parse(fecha);
            bandera = true;
            txtID.Text = id.ToString();
            txtID.Enabled = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (bandera)
            {
                txtID.Enabled = false;
                string sql = "UPDATE productos SET " +
                    $"nombre='{txtNombre.Text}'," +
                    $"descripcion='{txtDescripcion.Text}'," +
                    $"precio='{txtPrecio.Text}'," +
                    $"stock='{txtStock.Text}'," +
                    $"categoria='{txtCategoria.Text}'," +
                    $"fecha_ingreso='{dtpFecha.Value.ToString("yyyy-MM-dd")}' " +
                    $"where id_producto='{id}'";
                Data datos = new Data();
                datos.ejecutar(sql);
                MessageBox.Show("Datos actualizados");  
            }
            else
            {
                string sql = "INSERT INTO productos(nombre,descripcion,precio,stock,categoria,fecha_ingreso) " +
                "VALUES (" +
                $"'{txtNombre.Text}','{txtDescripcion.Text}','{txtPrecio.Text}'," +
                $"'{txtStock.Text}','{txtCategoria.Text}'," +
                $"'{dtpFecha.Value.ToString("yyyy-MM-dd")}');";
                Data datos = new Data();
                datos.ejecutar(sql);
                MessageBox.Show("Datos insertados");
            }
            this.Close();
        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();// Cancelar
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            FormCR fr = new FormCR();
            fr.Show();
        }
    }
}
