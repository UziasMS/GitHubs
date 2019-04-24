using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsForms_BancoTuiuiu
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void lbl_saldo_Click(object sender, EventArgs e)
        {

        }

        private void frm_principal_Load(object sender, EventArgs e)
        {
            public void HabilitarCampos(); 



            //Lista
            List<string> cartaoRemovivel = new List<string>();

            //Acesso a todos os drivers da maquinas
            DriveInfo[] alldrives = DriveInfo.GetDrives();

            foreach (DriveInfo item in alldrives)
            {
                if (item.Ready == true && item.DriveType.ToString() == "Removable")
                    HabilitarCampos();
                txtNome.txt = item.VolumeLabel;
                txtConta.txt = item.TotalSize.ToString().Substring(0, 5);
                txtSaldo.txt = item.TotalFreeSpace.ToString();

                return;
            }
            else
            {
                DesabilitarCampos();

            }

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {

        }
    }
}
