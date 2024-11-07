using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCinema {
    public partial class Pagamento : Form {
        public Pagamento() {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void customButton2_Click(object sender, EventArgs e) {
            var resp = MessageBox.Show("Caramba meu que doideira.", "Info Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resp == DialogResult.Yes) {
                Environment.Exit(0);
            }
        }

        private void customButton1_Click(object sender, EventArgs e) {
            var resp = MessageBox.Show("Caramba meu que doideira.", "Info Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resp == DialogResult.Yes) {
                Environment.Exit(0);
            }
        }
    }
}
