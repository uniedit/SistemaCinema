using SistemaCinema.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SistemaCinema {
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
        }

        private void customButton1_Click(object sender, EventArgs e) {

        }

        private void lbl_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            this.Hide();
            Acesso acss = new Acesso();
            acss.ShowDialog();
            this.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e) {
            if (cb_Senha.CheckState == CheckState.Checked) {
                txt_Senha.UseSystemPasswordChar = true;
            }
        }



        private void lbl_Email_Click(object sender, EventArgs e) {

        }



        private void label1_Click(object sender, EventArgs e) {

        }

        private void Login_Load(object sender, EventArgs e) {

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

        private void customButton1_Click_1(object sender, EventArgs e) {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.ShowDialog();
            this.Show();
            if (MainMenu.ActiveForm != null) Login.ActiveForm.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            this.Hide();
            Acesso acss = new Acesso();
            acss.ShowDialog();
            this.Show();
        }
    }
}
