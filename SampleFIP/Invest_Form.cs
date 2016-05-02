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
    public partial class Invest_Form : Form
    {
        Portfolio clientAcct;
        StkPortfolio stkPortfolio;
        public Invest_Form()
        {
            InitializeComponent();
            clientAcct = new ClientAcct();
            stkPortfolio = new Google();
        }

        private void PercAmt_Btn_Click(object sender, EventArgs e)
        {
            IPA_label.Text = "IP Amount: " + getPercAmnt()[0];
            Label_401k.Text = "401k Amount: " + getPercAmnt()[1];
            LISA_Label.Text = "L.I.S.A. Amount: " + getPercAmnt()[2];
        }
        private void CrtPtflio_Btn_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage1);
            InvAmnt_Label.Text = InvAmnt_Label.Text + getPercAmnt()[0];
            stkName_label.Text = stkName_label.Text + stkPortfolio.StockName();
            initStkVal_Lbl.Text = initStkVal_Lbl.Text + stkPortfolio.stkVal();
            TtlAmnt_Label.Text = TtlAmnt_Label.Text + getPercAmnt()[0];
            ttlStkVal_Lbl.Text = ttlStkVal_Lbl.Text + stkPortfolio.stkVal();
            double yearlyCont = getPercAmnt()[2];
            SavDept_Label.Text = SavDept_Label.Text + yearlyCont;
        }

        private double[] getPercAmnt()
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
            double[] percAmnts = new double[3] {clientAcct.PercInvest(salary, percIP), clientAcct.PercInvest(salary, perc401k), clientAcct.PercInvest(salary, percLISA) };
            return percAmnts;
        }
        private void Inv_StkAmnt()
        {
            
            double amntInv = getPercAmnt()[0];
            double baseStk = stkPortfolio.stkVal();
            double[] total = stkPortfolio.ShowTtlChange(baseStk);
            double numShare = amntInv / baseStk;
            double ttlChange = total[0];
            double ttlStk = total[1];
            double ttlAmnt = amntInv + (numShare * ttlChange);
            DayChng_Label.Text = "Daily Change: " + stkPortfolio.ShowDayChange(stkPortfolio.stkVal())[0];
            TtlChng_Label.Text = "Total Change: " + ttlChange;
            ttlStkVal_Lbl.Text = "Total Stock: " + ttlStk;
            TtlAmnt_Label.Text = "Total Amount: " + ttlAmnt;
        }
        private void NxtDay_Btn_Click(object sender, EventArgs e)
        {
            Inv_StkAmnt();
        }
        private void LISA()
        {
            double SavDept = getPercAmnt()[2];
            int years = Convert.ToInt32(Years_TB.Text);
            years = int.Parse(Years_TB.Text);
            double percReturn = Convert.ToDouble(PercRet_TB.Text);
            percReturn = double.Parse(PercRet_TB.Text);
            double finalAmnt = SavDept * Math.Pow((1 + percReturn), years);
            finalAmnt = Math.Round(finalAmnt, 2);
            TtlLISA_Label.Text = "Total Amount: " + finalAmnt;
        }

        private void CalcSavs_Btn_Click(object sender, EventArgs e)
        {
            LISA();
        }
    }
}
