using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tcctestes.formularios
{
    public partial class FeedBack : Form
    {
        public FeedBack()
        {
            InitializeComponent();
        }

        private void enviarFeedback_Click(object sender, EventArgs e)
        {
            try { } catch (FormatException ex) { MessageBox.Show(ex.Message); }
        }
    }
}
