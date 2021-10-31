using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_Dia_da_Semana
{
    public partial class frmDiaSemana : Form
    {
        public frmDiaSemana()
        {
            InitializeComponent();
        }

        int dia;

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            dia = Convert.ToInt32(txtDia.Text);

            switch (dia)
            {
                case 1:
                    lblDiaSemana.Text = "Domingo";
                    break;
                case 2:            
                    lblDiaSemana.Text = "Segunda Feira";
                    break;
                case 3:
                    lblDiaSemana.Text = "Terça Feira";
                    break;
                case 4:
                    lblDiaSemana.Text = "Quarta Feira";
                    break;
                case 5:
                    lblDiaSemana.Text = "Quinta Feira";
                    break;
                case 6:
                    lblDiaSemana.Text = "Sexta Feira";
                    break;
                case 7:
                    lblDiaSemana.Text = "Sábado";
                    break;

                default:
                    lblDiaSemana.Text = "Dia Inválido";
                    break;

            }

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
