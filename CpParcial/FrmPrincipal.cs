using ClnParcial2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpParcial
{
    public partial class FrmPrincipal : Form
    {
        bool esNuevo = false;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void listar()
        {
            var series = SerieCln.listarPa(txtParametro.Text.Trim());
            dgvListaSeries.DataSource = series;
            dgvListaSeries.Columns["id"].Visible = false;
            dgvListaSeries.Columns["estado"].Visible = false;
            dgvListaSeries.Columns["titulo"].HeaderText = "Título";
            dgvListaSeries.Columns["sinopsis"].HeaderText = "Sinopsis";
            dgvListaSeries.Columns["director"].HeaderText = "Director";
            dgvListaSeries.Columns["duracion"].HeaderText = "Duración";
            dgvListaSeries.Columns["fechaEstreno"].HeaderText = "Fecha de Estreno";
            dgvListaSeries.Columns["usuarioRegistro"].HeaderText = "Usuario";
            btnEditar.Enabled = series.Count > 0;
            btnEliminar.Enabled = series.Count > 0;
            if (series.Count > 0) dgvListaSeries.Rows[0].Cells["titulo "].Selected = true;
        }

        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }
    }
}
