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
            InvAmnt_Label.Text = "IP Amount: " + getPercAmnt()[0];
            stkName_label.Text = "Stock: " + stkPortfolio.StockName();
            initStkVal_Lbl.Text = "Initial Stock Value: " + stkPortfolio.stkVal();
            TtlAmnt_Label.Text = "Total Amount: "+ getPercAmnt()[0];
            ttlStkVal_Lbl.Text = "Total Stock: "+ stkPortfolio.stkVal();
            double yearlyCont = getPercAmnt()[2];
            SavDept_Label.Text = "Savings Deposit Annually: " + yearlyCont;
            double AnnualCont = getPercAmnt()[1];
            AnnCont_Label.Text = "Annual Contribution: " + AnnualCont;
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
            double SavDeptAnn = getPercAmnt()[2];
            int years = Convert.ToInt32(Years_TB.Text);
            years = int.Parse(Years_TB.Text);
            double percReturn = Convert.ToDouble(PercRet_TB.Text);
            percReturn = double.Parse(PercRet_TB.Text);
            double CmpndInt = SavDeptAnn * Math.Pow((1 + percReturn), years);
            CmpndInt = Math.Round(CmpndInt, 2);
            double AnnDepVal = SavDeptAnn * (Math.Pow((1 + percReturn), years) - 1) / percReturn;
            double finalAmnt = CmpndInt + AnnDepVal;
            finalAmnt = Math.Round(finalAmnt, 2);
            TtlLISA_Label.Text = "Total Amount: " + finalAmnt;
        }
        
        private void CalcSavs_Btn_Click(object sender, EventArgs e)
        {
            LISA();
        }
        private void _401k()
        {
            double currBalance = Convert.ToDouble(CurrBall401k_TB.Text);
            currBalance = double.Parse(CurrBall401k_TB.Text);
            double AnnualCont = getPercAmnt()[1];
            double EmployerCont = Convert.ToDouble(EmpMatch_TB.Text);
            EmployerCont = double.Parse(EmpMatch_TB.Text);
            int years = Convert.ToInt32(Years401k_TB.Text);
            years = int.Parse(Years401k_TB.Text);
            double annContEmp = AnnualCont + (AnnualCont * EmployerCont);
            double RetRate = Convert.ToDouble(RetRate401k_TB.Text);
            RetRate = double.Parse(RetRate401k_TB.Text);
            double CmpndInt = (currBalance) * Math.Pow((1 + RetRate), years);
            CmpndInt = Math.Round(CmpndInt, 2);
            double AnnDepVal = AnnualCont * (Math.Pow((1 + RetRate), years) - 1) / RetRate;
            double finalAmntNoEmp = CmpndInt + AnnDepVal;
            double AnnDepValEmp = annContEmp * (Math.Pow((1 + RetRate), years) - 1) / RetRate;
            double finalAmntEmp = CmpndInt + AnnDepValEmp;
            finalAmntEmp = Math.Round(finalAmntEmp, 2);
            finalAmntNoEmp = Math.Round(finalAmntNoEmp, 2);
            FinNoEmp401k_Label.Text = "Final w/out Employer: " + finalAmntNoEmp;
            FinEmp401k_Label.Text = "Final w/ Employer: " + finalAmntEmp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _401k();
        }
    }
}
