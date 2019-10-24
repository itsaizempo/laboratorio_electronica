using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlLaboratorioElectronica
{
	public partial class canvasPrincipal : Form
	{
		public canvasPrincipal()
		{
			InitializeComponent();
		}

		private void canvasPrincipal_Load(object sender, EventArgs e)
		{
			update();
		}

		public void update()
		{
			ArrayList row = new ArrayList();
			row.Add("Itsai Zempoatecatl Mejia");
			row.Add("4sa");
			dgvDocentes.Rows.Add(row.ToArray());
		}
	}
}
