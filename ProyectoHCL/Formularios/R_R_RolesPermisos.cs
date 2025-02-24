﻿using MySql.Data.MySqlClient;
using ProyectoHCL.clases;
using ProyectoHCL.RolesPermisos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static iText.Kernel.Pdf.Colorspace.PdfDeviceCs;

namespace ProyectoHCL.Formularios
{
    public partial class R_R_RolesPermisos : Form
    {
        public R_R_RolesPermisos()
        {
            InitializeComponent();
            cargarRoles();
        }

        RolUsuario rolUs = new RolUsuario();
        PermisoRol permiso = new PermisoRol();
        CDatos cDatos = new CDatos();
        Objetos obj = new Objetos();
        DataSet ds = new DataSet();
        MsgB msgB = new MsgB();
        Modelo modelo = new Modelo();
        int IdRol;

        private void ListarObjetos()
        {
            dgvRolPermiso.DataSource = cDatos.listarObjetos();
        }

        private void cargarRoles()
        {
            MySqlConnection conn;
            MySqlCommand cmd;

            cmbRol.DataSource = null;
            cmbRol.Items.Clear();
            string sql = "SELECT ID_ROL, ROL FROM TBL_ROL;";

            conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
            conn.Open();

            try
            {
                cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter data = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                data.Fill(dt);

                cmbRol.ValueMember = "ID_ROL";
                cmbRol.DisplayMember = "ROL";
                cmbRol.DataSource = dt;

            }
            catch (MySqlException e)
            {
                MsgB m = new MsgB("Error", "Se produjo un error " + e.Message);
                DialogResult dR = m.ShowDialog();
            }
            finally { conn.Close(); }

        }

        private void CargarDG()
        {
            DataGridViewCheckBoxColumn chkVer = new DataGridViewCheckBoxColumn();
            chkVer.Name = "VER";
            chkVer.Tag = 1;
            dgvRolPermiso.Columns.Add(chkVer);

            DataGridViewCheckBoxColumn chkCrear = new DataGridViewCheckBoxColumn();
            chkCrear.Name = "CREAR";
            chkCrear.Tag = 2;
            dgvRolPermiso.Columns.Add(chkCrear);

            DataGridViewCheckBoxColumn chkEditar = new DataGridViewCheckBoxColumn();
            chkEditar.Name = "EDITAR";
            chkEditar.Tag = 3;
            dgvRolPermiso.Columns.Add(chkEditar);

            DataGridViewCheckBoxColumn chkEliminar = new DataGridViewCheckBoxColumn();
            chkEliminar.Name = "ELIMINAR";
            chkEliminar.Tag = 4;
            dgvRolPermiso.Columns.Add(chkEliminar);
        }

        public void limpiarCampos()
        {
            cmbRol.SelectedIndex = -1;

            foreach (DataGridViewRow row in dgvRolPermiso.Rows)
            {
                if (Convert.ToBoolean(row.Cells["VER"].Value))
                {
                    row.Cells["VER"].Value = false;
                }
                if (Convert.ToBoolean(row.Cells["CREAR"].Value))
                {
                    row.Cells["CREAR"].Value = false;
                }
                if (Convert.ToBoolean(row.Cells["EDITAR"].Value))
                {
                    row.Cells["EDITAR"].Value = false;
                }
                if (Convert.ToBoolean(row.Cells["ELIMINAR"].Value))
                {
                    row.Cells["ELIMINAR"].Value = false;
                }
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            limpiarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            limpiarCampos();
        }

        int posY = 0;
        int posX = 0;

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        private void btnAntR_Click(object sender, EventArgs e)
        {
        }

        private void btnSigR_Click(object sender, EventArgs e)
        {
        }

        private void cmbPagR_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        private void RolesPermisos_Load(object sender, EventArgs e)
        {
            ListarObjetos();
            cmbRol.SelectedIndex = -1;
            CargarDG();
            //pictureBox1.Image = Image.FromFile(@"C:\Users\jmont\OneDrive\Documentos\HM\reloj-de-arena.gif");
            //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void GuardarPermisoRol()
        {
            panel6.Visible = true;

            foreach (DataGridViewRow row in dgvRolPermiso.Rows)
            {
                permiso.IdRol = cmbRol.Text;
                permiso.IdObjeto = row.Cells["PANTALLA"].Value.ToString();

                if (Convert.ToBoolean(row.Cells["VER"].Value))
                {
                    permiso.IdPermiso = Convert.ToInt32(dgvRolPermiso.Columns["VER"].Tag);
                    permiso.Permitido = true;
                    cDatos.GuardarPermiso(permiso);
                }
                else if (!Convert.ToBoolean(row.Cells["VER"].Value))
                {
                    permiso.IdPermiso = Convert.ToInt32(dgvRolPermiso.Columns["VER"].Tag);
                    permiso.Permitido = false;
                    cDatos.GuardarPermiso(permiso);
                }

                if (Convert.ToBoolean(row.Cells["CREAR"].Value))
                {
                    permiso.IdPermiso = Convert.ToInt32(dgvRolPermiso.Columns["CREAR"].Tag);
                    permiso.Permitido = true;
                    cDatos.GuardarPermiso(permiso);
                }
                else if (!Convert.ToBoolean(row.Cells["CREAR"].Value))
                {
                    permiso.IdPermiso = Convert.ToInt32(dgvRolPermiso.Columns["CREAR"].Tag);
                    permiso.Permitido = false;
                    cDatos.GuardarPermiso(permiso);
                }

                if (Convert.ToBoolean(row.Cells["EDITAR"].Value))
                {
                    permiso.IdPermiso = Convert.ToInt32(dgvRolPermiso.Columns["EDITAR"].Tag);
                    permiso.Permitido = true;
                    cDatos.GuardarPermiso(permiso);
                }
                else if (!Convert.ToBoolean(row.Cells["EDITAR"].Value))
                {
                    permiso.IdPermiso = Convert.ToInt32(dgvRolPermiso.Columns["EDITAR"].Tag);
                    permiso.Permitido = false;
                    cDatos.GuardarPermiso(permiso);
                }

                if (Convert.ToBoolean(row.Cells["ELIMINAR"].Value))
                {
                    permiso.IdPermiso = Convert.ToInt32(dgvRolPermiso.Columns["ELIMINAR"].Tag);
                    permiso.Permitido = true;
                    cDatos.GuardarPermiso(permiso);
                }
                else if (!Convert.ToBoolean(row.Cells["ELIMINAR"].Value))
                {
                    permiso.IdPermiso = Convert.ToInt32(dgvRolPermiso.Columns["ELIMINAR"].Tag);
                    permiso.Permitido = false;
                    cDatos.GuardarPermiso(permiso);
                }
            }

            panel6.Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (cmbRol.Text == "")
            {
                MsgB Mbox = new MsgB("advertencia", "Seleccione un rol");
                DialogResult DR = Mbox.ShowDialog();
            }
            else
            {
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                GuardarPermisoRol();
                MsgB Mbox = new MsgB("informacion", "Permisos registrados");
                DialogResult DR = Mbox.ShowDialog();
                limpiarCampos();
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        private void txtRol_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            cargarPermisos();
            //if (cmbRol.Text == "")
            //{
            //    MsgB mbox = new MsgB("informacion", "Seleccione el rol a editar permisos");
            //    DialogResult dR = mbox.ShowDialog();
            //}
            //else
            //{

            //}
        }

        private void cargarPermisos()
        {
            CDatos cDatos = new CDatos();

            var LsObj = cDatos.SelectObjeto(3); //***********

            foreach (var obj in LsObj)
            {
                foreach (DataGridViewRow row in dgvRolPermiso.Rows)
                {
                    if (obj.IdPermiso == 1 && obj.Permitido)
                    {
                        row.Cells["VER"].Value = true;
                    }
                    else
                    {
                        row.Cells["VER"].Value = false;
                    }

                    if (obj.IdPermiso == 2 && obj.Permitido)
                    {
                        row.Cells["CREAR"].Value = true;
                    }
                    else
                    {
                        row.Cells["CREAR"].Value = false;
                    }

                    if (obj.IdPermiso == 3 && obj.Permitido)
                    {
                        row.Cells["EDITAR"].Value = true;
                    }
                    else
                    {
                        row.Cells["EDITAR"].Value = false;
                    }

                    if (obj.IdPermiso == 4 && obj.Permitido)
                    {
                        row.Cells["ELIMINAR"].Value = true;
                    }
                    else
                    {
                        row.Cells["ELIMINAR"].Value = false;
                    }
                }
            }
        }
    }
}
