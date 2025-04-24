using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryMolly
{
    public partial class Home : Form
    {
private FormLeitura formLeitura;

        public Home()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (formLeitura == null || formLeitura.IsDisposed)
            {
                formLeitura = new FormLeitura();
                formLeitura.Show();
            }
            else
            {
                formLeitura.Focus();
            }
        }
    }
}
