using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCinema.Login_Cadastro {
    public partial class Cadastro : Form {
        public Cadastro() {
            InitializeComponent();
        }

        private void cb_Senha_CheckedChanged(object sender, EventArgs e) {
            if (cb_Senha.CheckState == CheckState.Checked) {
                txt_Senha.UseSystemPasswordChar = true;
                cb_Senha.BackgroundImage = Properties.Resources.eye;

            } else {
                txt_Senha.UseSystemPasswordChar = false;
                cb_Senha.BackgroundImage = Properties.Resources.view;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            if (cb_Senha2.CheckState == CheckState.Checked) {
                txt_Senha2.UseSystemPasswordChar = true;
                cb_Senha2.BackgroundImage = Properties.Resources.eye;

            } else {
                txt_Senha2.UseSystemPasswordChar = false;
                cb_Senha2.BackgroundImage = Properties.Resources.view;
            }
        }

        private void txt_Senha_TextChanged(object sender, EventArgs e) {
            if (cb_Senha.CheckState == CheckState.Checked) {
                txt_Senha.UseSystemPasswordChar = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            if (cb_Senha2.CheckState == CheckState.Checked) {
                txt_Senha2.UseSystemPasswordChar = true;
            }
        }

        private void Cadastro_Load(object sender, EventArgs e) {

        }

        private void customButton2_Click(object sender, EventArgs e) {
            this.Hide();
            Login log = new Login();
            log.ShowDialog();
            this.Show();
            if (Login.ActiveForm != null) Cadastro.ActiveForm.Close();
        }

        private void txt_Email_TextChanged(object sender, EventArgs e) {

        }
    }
}
