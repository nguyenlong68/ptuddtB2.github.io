using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuong1_TongQuanVeLapTrinhGiaoDien_1
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void trang35ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form = new trang35();
			form.ShowDialog();
		}

		private void tsmiTrang35_Click(object sender, EventArgs e)
		{
			var form = new trang35();
			form.ShowDialog();
		}

		private void tsmiTrang42_Click(object sender, EventArgs e)
		{
			var form = new trang42();
			form.ShowDialog();
		}
	}
}
