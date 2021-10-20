using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria3._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblSabores_Click(object sender, EventArgs e)
        {

        }

        private void cboSabores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Preenche o comboBox com os sabores das pizzas
            cboSabor.Items.Add("Mussarela");
            cboSabor.Items.Add("Palmito");
            cboSabor.Items.Add("Atum");
            cboSabor.Items.Add("Calabresa");

            //Seleciona o item da lista que tem indice = 0, o primeiro da lista

            cboSabor.SelectedIndex = 0;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Seleciono o item da lista que tem indece 0, que vai ser o primeiro Lugar.
            cboSabor.SelectedIndex = 0;
            // Coloca o cursor no ComboBox
            cboSabor.Focus();

            // Deixar o checkBom sem seleção
            chkAzeitona.Checked = false;
            chkCebola.Checked = false;

            // Marco o RadioButton sem borda Selecionado
            rdbSemBorda.Checked = true;
        }

         private void btnImprimir_Click(object sender, EventArgs e)
    {
        string strSabor;
        //variável para concatenar os textos
        string strPedido = null;
        //variável que recebe o texto do ComboBox
        strSabor = cboSabor.Text;
        //verifica se tem algum item do ComboBox selecionado
        //por meio da propriedade Text
        //Se o texto for Nulo ou Vazio emite mensagem ao user
        //e coloca o foco no cursor do cboSabor
        if (string.IsNullOrEmpty(cboSabor.Text))
        {
            MessageBox.Show("Selecione um sabor de pizza!", "Pizzaria", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cboSabor.Focus();
            return;
        }
            //Estrutura swith

            switch (strSabor)
            {
                case "Mussarela":
                    strPedido = "Mussarela";
                    break;
                case "Palmito":
                    strPedido = "Palmito";
                    break;
                case "Atum":
                    strPedido = "Atum";
                    break;
                case "Calabresa":
                    strPedido = "Calabresa";
                    break;
            }

            //Neste caso podemos ter 2 selecionados, ou nenhum
            //Concatenar o texto dostrPedido com a String definida.
            //Verificar se o checkBox esta selecionado

            if (chkAzeitona.Checked)
            {
                //Concatenar o teto do strPedido com a String definida
                strPedido = strPedido + " com Azeitonas";
            }
            if (chkCebola.Checked)
            {
                //Concatenar o teto do strPedido com a String definida
                strPedido = strPedido + " com Cebola";
            }


            if (rdbComBorda.Checked)
            {
                //Concatenar o teto do strPedido com a String definida
                strPedido = strPedido + " com Borda Recheada";
            }
            else {
                strPedido = strPedido + " sem Borda";
            }

            MessageBox.Show(strPedido, "Pizzaria", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
