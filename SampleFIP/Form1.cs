using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleFIP
{
    public partial class Form1 : Form
    {
        Portfolio clientAcct;

        public Form1()
        {
            InitializeComponent();
            clientAcct = new ClientAcct();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int balance = Convert.ToInt32(AvailBal_TB.Text);
                balance = int.Parse(AvailBal_TB.Text);
            clientAcct.AcctBalance(balance);
            int salary = Convert.ToInt32(Salary_TB.Text);
                salary = int.Parse(Salary_TB.Text);
            clientAcct.GetSalary(salary);
            double percIP = Convert.ToDouble(PercIP_TB.Text);
                   percIP = double.Parse(PercIP_TB.Text);
            IPA_label.Text = "IP Amount: " + clientAcct.PercInvest(salary, percIP);
            double perc401k = Convert.ToDouble(Perc401k_TB.Text);
                   perc401k = double.Parse(Perc401k_TB.Text);
            Label_401k.Text = "401k Amount: " + clientAcct.PercInvest(salary, perc401k);
            double percLISA = Convert.ToDouble(PercLISA_TB.Text);
                   percLISA = double.Parse(PercLISA_TB.Text);
            LISA_Label.Text = "L.I.S.A. Amount: " + clientAcct.PercInvest(salary, percLISA);
        }

        private void CrtPtflio_Btn_Click(object sender, EventArgs e)
        {
            Form Invest_Form = new Invest_Form();
            Invest_Form.Show();
        }
    }
}
