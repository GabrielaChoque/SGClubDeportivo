using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGClubDeportivo.Vista
{
    public partial class frmPrincipalSecretario : frmPrincipal
    {
        public frmPrincipalSecretario()
        {
            InitializeComponent();
        }
        public frmPrincipalSecretario(string carnet, string cargo)
        {
            InitializeComponent();
            //    _Cargo = cargo;
            //    _Carnet = carnet;
            //    AbrirFormInPanel(new Vista.frmInicio(_Carnet, _Cargo));
        }
    }
}
