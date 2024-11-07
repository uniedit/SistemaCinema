using Npgsql;
using SistemaCinema.Login_Cadastro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SistemaCinema.Sessões;

namespace SistemaCinema {
    public partial class Descrição : Form {
        public Descrição() {
            InitializeComponent();
            if (Global.VenonAtv == true) {
                picBox.BackgroundImage = Properties.Resources.VENOOOOOOOOON;
            }
            if (Global.RoboAtv == true) {
                picBox.BackgroundImage = Properties.Resources.cc85122f8c6571afb0102ec2e27daae51;
            }
            if (Global.YoNameAtv == true) {
                picBox.BackgroundImage = Properties.Resources.your_name__01_Capa_p;
            }
            if (Global.MommyAtv == true) {
                picBox.BackgroundImage = Properties.Resources._100_cartaz;
            }
        }

        public NpgsqlConnection conectar;
        public NpgsqlCommand ComandoSQL;
        public NpgsqlDataReader LerCadastro;
        public string strCon = "Server=localhost;Port=5432;Username=postgres;password=byteblaze;Database=byteblaze";
        public string strSQL = "";

        private void label2_Click(object sender, EventArgs e) {

        }

        private void customButton6_Click(object sender, EventArgs e) {

        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void Descrição_Load(object sender, EventArgs e) {

        }

        private void pictureBox2_Click(object sender, EventArgs e) {
        }

        public static void Mano() {
            Globals.Fechar = false;
            Globals.Assentos = false;
        }

        public static class Globals {
            public static bool Fechar { get; set; }
            public static bool Assentos { get; set; }
        }
        private void customButton1_Click(object sender, EventArgs e) {
            Globals.Fechar = true;
            this.Close();
        }

        private void customButton3_Click(object sender, EventArgs e) {
            Globals.Assentos = true;
            this.Close();
        }

        private void customButton2_Click(object sender, EventArgs e) {
            Globals.Assentos = true;
            this.Close();
        }
        private void customButton6_Click_1(object sender, EventArgs e) {
            Globals.Assentos = true;
            this.Close();
        }

        private void customButton4_Click(object sender, EventArgs e) {
            Globals.Assentos = true;
            this.Close();
        }
    }
}
