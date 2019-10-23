using System;
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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnMenu_Click(object sender, EventArgs e)
		{
			despliegueMenu();
		}

		private void despliegueMenu()
		{
			if (panelMenu.Width == 49)
			{
				panelMenu.Visible = false;
				panelMenu.Width = 190;
				panelTransicion.ShowSync(panelMenu);
			}
			else
			{
				panelMenu.Visible = false;
				panelMenu.Width = 49;
				panelTransicion.ShowSync(panelMenu);

			}
		}

		private void canvas_MouseClick(object sender, MouseEventArgs e)
		{
			despliegueMenu();
		}
	}
}
