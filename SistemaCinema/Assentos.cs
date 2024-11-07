using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SistemaCinema.Descrição;

namespace SistemaCinema {
    public partial class Assentos : Form {
        public Assentos() {
            InitializeComponent();
        }
        public static void Mano() {
            GlobalAssent.Fechar = false;
            GlobalAssent.Assent = false;
        }

        public static class GlobalAssent {
            public static bool Fechar { get; set; }
            public static bool Assent { get; set; }
        }
        private void customButton22_Click(object sender, EventArgs e) {
            GlobalAssent.Fechar = true;
            this.Close();
        }

        private void customButton21_Click(object sender, EventArgs e) {
            GlobalAssent.Assent = true;
            this.Close();
        }
    }
}
