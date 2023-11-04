using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace StarViewDesing
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaxi_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaxi.Visible = false;
            btnRest.Visible = true;
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaxi.Visible = true;
            btnRest.Visible = false;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /*//Comandos estranhos para estudar
          [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PnlContenedor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x12, 0xf012, 0);
        }*/

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            pnlRelatórios.Visible = true;
        }

        private void btnRVendas_Click_1(object sender, EventArgs e)
        {
            pnlRelatórios.Visible = false;
        }

        private void btnRCompras_Click_1(object sender, EventArgs e)
        {
            pnlRelatórios.Visible = false;
        }

        private void btnRPagos_Click(object sender, EventArgs e)
        {
            pnlRelatórios.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnProdutos_Click(object sender, EventArgs e)
        {
            pnlProdutos.Visible = true;
            BtnProdutos.Enabled = false;
            btnVendas.Enabled = false;
            btnClientes.Enabled = false;
            btnCompras.Enabled = false;
            btnFuncionarios.Enabled = false;
            btnPagos.Enabled = false;
            btnRelatorios.Enabled = false;
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            frmVendas AbrirVendas = new frmVendas();
            AbrirVendas.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            pnlClientes.Visible = true;
            BtnProdutos.Enabled = false;
            btnVendas.Enabled = false;
            btnClientes.Enabled = false;
            btnCompras.Enabled = false;
            btnFuncionarios.Enabled = false;
            btnPagos.Enabled = false;
            btnRelatorios.Enabled = false;
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            frmCompras AbrirCompras = new frmCompras();
            AbrirCompras.ShowDialog();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            frmFuncionarios MostrarFuncionarios = new frmFuncionarios();
            MostrarFuncionarios.ShowDialog();
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            frmPagos MostrarPagos = new frmPagos();
            MostrarPagos.ShowDialog();
        }

        private void btnCloseClientes_Click(object sender, EventArgs e)
        {
            pnlClientes.Visible = false;
            BtnProdutos.Enabled = true;
            btnVendas.Enabled = true;
            btnClientes.Enabled = true;
            btnCompras.Enabled = true;
            btnFuncionarios.Enabled = true;
            btnPagos.Enabled = true;
            btnRelatorios.Enabled = true;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string name = txtNome.Text, tel = txtTel.Text, city = txtCity.Text;
            string district = txtBairro.Text, run = txtRua.Text, number = txtN.Text;
            string products = txtPC.Text, descripition = txtDescricao.Text;
            txtNome.Text = "";
            txtTel.Text = "";
            txtCity.Text = "";
            txtBairro.Text = "";
            txtRua.Text = "";
            txtN.Text = "";
            txtPC.Text = "";
            txtDescricao.Text = "";
            txtCadastrados.Text = txtCadastrados.Text + name + " | " + tel + " | " + city + " | " + district + " | " + run + " | " + number + " | " + products + " | " + descripition + "\n";
        }

        private void btnCloseProdutos_Click(object sender, EventArgs e)
        {
            pnlProdutos.Visible = false;
            BtnProdutos.Enabled = true;
            btnVendas.Enabled = true;
            btnClientes.Enabled = true;
            btnCompras.Enabled = true;
            btnFuncionarios.Enabled = true;
            btnPagos.Enabled = true;
            btnRelatorios.Enabled = true;
        }

        
    }
}
