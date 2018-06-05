using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroExamen.Entidades;

namespace RegistroExamen.UI.Consultas
{
    public partial class Consultar : Form
    {
        public Consultar()
        {
            InitializeComponent();
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            Expression<Func<Grupos, bool>> filtro = x => true;
          //

            Consulta_dataGridView.DataSource = BLL.GruposBLL.GetList(filtro);
        }
    }
}
