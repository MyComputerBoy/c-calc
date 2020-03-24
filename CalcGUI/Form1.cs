using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcGUI
{
	public partial class Form1 : Form
	{
		int V1 = 0;
		public Form1()
		{
			InitializeComponent();
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			textBox1.Text = Convert.ToString( V1 );
			this.Controls.Add(textBox1);
			Button b = new Button();
			b.Click += new EventHandler(ShowMessage);
		}

		private void ShowMessage(object sender, EventArgs e)
		{
			MessageBox.Show("General Kenobi");
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			V1 = (10 * V1) + 1;
		}
	}
}
