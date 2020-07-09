using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace ferramentas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            Ping p = new Ping();
            PingReply r;
            string s;
            s = txtUrl.Text;
            r = p.Send(s);
            if (r.Status == IPStatus.Success)
            {
                lblResultado1.Text = "Ping para" + s.ToString() + "[" + r.Address.ToString() + "]" + "Sucesso";
                lblResultado2.Text = "Delay da resposta" + r.RoundtripTime.ToString() + "milisegungos" + "\n";
            }
            else
            {
                MessageBox.Show("Não foi possivel encontrar esse endereço" , "Ping" , MessageBoxButtons.OK , MessageBoxIcon.Information);
            }

        }

        private void txtUrl_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUrl.Text) || txtUrl.Text == "")
            {
                MessageBox.Show("Digite um IP ou URL valida", "Ping", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
