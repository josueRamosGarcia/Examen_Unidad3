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
    public partial class FormProductos : Form
    {

        Data dt = new Data();

        public FormProductos()
        {
            InitializeComponent();
        }

        public void actualizar()
        {
            DataSet ds;
            ds = dt.comandoOS(
                "SELECT id_producto, nombre, descripcion, precio, stock, categoria, fecha_ingreso "+
                "FROM productos"
            );
            if ( ds != null)
            {
                dgvProductos.DataSource = ds.Tables[0];
            }
            
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            this.actualizar();
        }

        private void FormProductos_Activated(object sender, EventArgs e)
        {
            this.actualizar();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aCTUALIZARToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int i = dgvProductos.CurrentRow.Index;
            FormProductosUnico fr = new FormProductosUnico(
                Convert.ToInt32(dgvProductos.Rows[i].Cells[0].Value),
                dgvProductos.Rows[i].Cells[1].Value.ToString(),
                dgvProductos.Rows[i].Cells[2].Value.ToString(),
                dgvProductos.Rows[i].Cells[3].Value.ToString(),
                dgvProductos.Rows[i].Cells[4].Value.ToString(),
                dgvProductos.Rows[i].Cells[5].Value.ToString(),
                dgvProductos.Rows[i].Cells[6].Value.ToString()
                );

            fr.Show();
        }

        private void eLIMINARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = dgvProductos.CurrentRow.Index;
            int id = Convert.ToInt32(dgvProductos.Rows[i].Cells[0].Value);

            DialogResult res = MessageBox.Show("Seguiro de eliminar", "ALERTA", MessageBoxButtons.OKCancel);

            if (res == DialogResult.OK)
            {
                dt.ejecutar("DELETE FROM productos WHERE id_producto=" + id + "");
                MessageBox.Show("Eliminado");
                this.actualizar();
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            FormProductosUnico insertar = new FormProductosUnico();
            insertar.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataSet ds;
            ds = dt.comandoOS("SELECT id_producto, nombre, descripcion, precio, stock, categoria, fecha_ingreso " +
                $"FROM productos where nombre LIKE '{textBox1.Text}%'"
             );
            if (ds != null)
            {
                dgvProductos.DataSource = ds.Tables[0];
            }
        }
    }
}
