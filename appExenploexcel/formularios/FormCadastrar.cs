using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace appExenploexcel.formularios
{
    public partial class FormCadastrar : Form
    {
        public FormCadastrar()
        {
            InitializeComponent();
        }

        private void FormListar_Load(object sender, EventArgs e)
        {

        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            var pasta = new XLWorkbook("C;\\teste\\Teste");
            var plan1 = pasta.Worksheet(1);

            var linhas = plan1.RowsUsed().Count();//Quantidade de linhas

        }
    }
}
