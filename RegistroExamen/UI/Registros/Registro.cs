using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroExamen.Entidades;

namespace RegistroExamen.UI.Registros
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private Grupos LlenarClase()
        {
            Grupos grupos = new Grupos();
            grupos.GrupoId = Convert.ToInt32(GrupoIdUpDown.Value);
            grupos.Descripcion = Descripcion_textBox.Text;
            grupos.Cantidad = Convert.ToInt32(CantidadUpDown.Value);
            grupos.Grupo = Convert.ToInt32(GrupoUpDown.Value);
        //    grupos.Fecha = fechaDateTimePicker.Value;
            grupos.Integrantes = Convert.ToInt32(IntegranteUpDown.Value);
            return grupos;
        }

        private void ClearAll()
        {
            GrupoUpDown.Value = 0;
            Descripcion_textBox.Clear();
            CantidadUpDown.Value = 0;
            GrupoUpDown.Value = 0;
            IntegranteUpDown.Value = 0;

        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(GrupoIdUpDown.Value);
            Grupos grupos = BLL.GruposBLL.Buscar(id);

            if (grupos != null)
            {
                GrupoIdUpDown.Value = grupos.GrupoId;
                Descripcion_textBox.Text = grupos.Descripcion;
                CantidadUpDown.Value = grupos.Cantidad;
                GrupoUpDown.Value = grupos.Grupo;
                IntegranteUpDown.Value = grupos.Integrantes;

            }
            else
                MessageBox.Show("No se encontro!", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (GrupoIdUpDown.Value == 0)
            {
                if (BLL.GruposBLL.Guardar(LlenarClase()))
                {

                    ClearAll();
                    MessageBox.Show("Guardado!", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (BLL.GruposBLL.Modificar(LlenarClase()))
                {
                    MessageBox.Show("Guardado!", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAll();

                }
                else
                    MessageBox.Show("No se pudo guardar!!", "Fallo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(GrupoIdUpDown.Value);

            if (BLL.GruposBLL.Eliminar(id))
                MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
                MessageBox.Show("No se pudo eliminar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
