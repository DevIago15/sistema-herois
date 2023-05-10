using System;
using HeroisViloes.View;
using HeroisViloes.Model.Entities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroisViloes
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) // nome
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) // ano nascimento
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btHeroi_Click(object sender, EventArgs e)
        {
            SuperHeroi formHeroi = new SuperHeroi();
            formHeroi.ShowDialog();
        }

        private void btAmigoHeroi_Click(object sender, EventArgs e)
        {
            AmigoHeroi formAmigoHeroi = new AmigoHeroi();
            formAmigoHeroi.ShowDialog();
        }

        private void btVilao_Click(object sender, EventArgs e)
        {
            Vilao formVilao = new Vilao();
            formVilao.ShowDialog();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
