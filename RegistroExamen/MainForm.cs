using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroExamen.UI.Registros;
using RegistroExamen.UI.Consultas;

namespace RegistroExamen
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void registrarGruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro view = new Registro();
            view.Show();
        }

        private void consultarGruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultar view = new Consultar();
            view.Show();
        }
    }
}
