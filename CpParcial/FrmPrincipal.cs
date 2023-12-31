﻿using CadParcial2;
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
            dgvListaSeries.Columns["duracion"].HeaderText = "Duración (cantidad de episodios)";
            dgvListaSeries.Columns["fechaEstreno"].HeaderText = "Fecha de Estreno";
            dgvListaSeries.Columns["usuarioRegistro"].HeaderText = "Usuario";
            btnEditar.Enabled = series.Count > 0;
            btnEliminar.Enabled = series.Count > 0;
            if (series.Count > 0) dgvListaSeries.Rows[0].Cells["titulo"].Selected = true;
        }

        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Size = new Size(949, 410);
            listar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            Size = new Size(949, 558);
            txtTitulo.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            Size = new Size(949, 558);

            int index = dgvListaSeries.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvListaSeries.Rows[index].Cells["id"].Value);
            var serie = SerieCln.get(id);
            txtTitulo.Text = serie.titulo;
            txtSinopsis.Text = serie.sinopsis;
            txtDirector.Text = serie.director;
            nudDuracion.Value = serie.duracion;
            dtpFechaEstreno.Value = serie.fechaEstreno;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Size = new Size(949, 410);
            limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void limpiar()
        {
            txtTitulo.Text = string.Empty;
            txtSinopsis.Text = string.Empty;
            txtDirector.Text = string.Empty;
            nudDuracion.Value = 0;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvListaSeries.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvListaSeries.Rows[index].Cells["id"].Value);
            string titulo = dgvListaSeries.Rows[index].Cells["titulo"].Value.ToString();
            DialogResult dialog = MessageBox.Show($"¿Está seguro que desea dar de baja la serie {titulo}?",
                "::: Parcial2 Juan José Rodas Paco - Mensaje :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                SerieCln.eliminar(id, "SIS457");
                listar();
                MessageBox.Show("Serie dada de baja correctamente", "::: Parcial2 Juan José Rodas Paco - Mensaje :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var serie = new Serie();
                serie.titulo = txtTitulo.Text.Trim();
                serie.sinopsis = txtSinopsis.Text.Trim();
                serie.director = txtDirector.Text.Trim();
                serie.duracion = (int)nudDuracion.Value;
                serie.fechaEstreno = dtpFechaEstreno.Value;
                serie.usuarioRegistro = "Parcial2JJRP";

                if (esNuevo)
                {
                    serie.estado = 1;
                    SerieCln.insertar(serie);
                }
                else
                {
                    int index = dgvListaSeries.CurrentCell.RowIndex;
                    serie.id = Convert.ToInt32(dgvListaSeries.Rows[index].Cells["id"].Value);
                    SerieCln.actualizar(serie);
                }
                listar();
                btnCancelar.PerformClick();
                MessageBox.Show("Serie guardada correctamente", "::: Parcial2 Juan José Rodas Paco - Mensaje :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool validar()
        {
            bool esValido = true;
            erpTitulo.SetError(txtTitulo, "");
            erpSinopsis.SetError(txtSinopsis, "");
            erpDirector.SetError(txtDirector, "");
            erpDuracion.SetError(nudDuracion, "");
            erpFechaEstreno.SetError(dtpFechaEstreno, "");
            if (string.IsNullOrEmpty(txtTitulo.Text))
            {
                esValido = false;
                erpTitulo.SetError(txtTitulo, "El campo título es obligatorio.");
            }
            if (string.IsNullOrEmpty(txtSinopsis.Text))
            {
                esValido = false;
                erpSinopsis.SetError(txtSinopsis, "El campo sinopsis es obligatorio.");
            }
            if (string.IsNullOrEmpty(txtDirector.Text))
            {
                esValido = false;
                erpDirector.SetError(txtDirector, "El campo director es obligatorio.");
            }
            if (string.IsNullOrEmpty(nudDuracion.Text))
            {
                esValido = false;
                erpDuracion.SetError(nudDuracion, "El campo duración es obligatorio.");
            }
            if (nudDuracion.Value < 0)
            {
                esValido = false;
                erpDuracion.SetError(nudDuracion, "El número de episodios o capítulos debe ser mayor a 0.");
            }
            if (string.IsNullOrEmpty(dtpFechaEstreno.Text))
            {
                esValido = false;
                erpFechaEstreno.SetError(dtpFechaEstreno, "El campo fecha de estreno es obligatorio.");
            }
            if (dtpFechaEstreno.Value > DateTime.Now)
            {
                esValido = false;
                erpFechaEstreno.SetError(dtpFechaEstreno, "La fecha de estreno no debe ser mayor que la fecha actual.");
            }
            return esValido;
        }
    }
}
