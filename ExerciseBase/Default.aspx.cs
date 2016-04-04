using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExerciseBase
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //a.Create a function
        protected void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                string sConcatVal =  this.ConcatValues(Convert.ToInt32(this.txtNumber.Text), this.txtString.Text);
                this.lblResult.Text = sConcatVal;
            }
            catch (Exception ex)
            {
                this.lblResult.Text = ex.Message;
            }
            
        }

        //Entered Value Concatenator
        public string ConcatValues(int num, string str)
        {
            try
            {
                string sConcatval = "";
                sConcatval += Convert.ToInt32(num) + str;

                return (sConcatval);
            }
            catch (Exception ex)
            {
                return (ex.Message);
            }            
        }

        //b.Create Another Function
        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {                
                string sSumEVal = SumVal(Int32.Parse(this.txtFirstNumber.Text),Int32.Parse(this.txtSecondNumber.Text),Int32.Parse(this.txtThirdNumber.Text));

                this.lblTotal.Text = sSumEVal;
            }
            catch (Exception ex)
            {
                this.lblTotal.Text = ex.Message;
            }
            
        }

        //Entered Value Adder and Evaluator
        public string SumVal(int x, int y, int z)
        {
            try
            {
                string sSumVal = "";

                int iSum = 0;
                iSum += x + y + z;

                if (iSum < 0)
                    sSumVal = "<font color='red'> " + iSum.ToString() + "</font>";
                if (iSum >= 0)
                    sSumVal = "<font color='black'> " + iSum.ToString() + "</font>";

                return (sSumVal);
            }
            catch (Exception ex)
            {
                return (ex.Message);
            }            
        }

        protected void btnCalc2_Click(object sender, EventArgs e)
        {
            try
            {
                string sEmphResult = EmphResult(Int32.Parse(this.txtNum1.Text),Int32.Parse(this.txtNum2.Text),Int32.Parse(this.txtNum3.Text));
                this.lblTotal2.Text = sEmphResult;
            }
            catch (Exception ex)
            {
                this.lblTotal2.Text = ex.Message;
            }
        }

        //Entered Value and Result Emphasizer
        public string EmphResult(int x, int y, int z)
        {
            string sEmphResult = "";
            int sum = x + y + z;
            
            if (sum < 0)
                sEmphResult = "<font size='300'> " + sum.ToString() + "</font>";
            if (sum >= 0)
                sEmphResult = "<font color='green'> " + sum.ToString() + "</font>";

            return (sEmphResult);
        }

        protected void btnProceed_Click(object sender, EventArgs e)
        {
            try
            {
                string sBoolNumE = BoolNumEval(this.txtBool.Text, Decimal.Parse(this.txtNumber2.Text), Decimal.Parse(this.txtNumber3.Text));
                this.lblOutPut.Text = sBoolNumE;
            }
            catch (Exception ex)
            {
                this.lblOutPut.Text = ex.Message;
            }
        }

        //Entered Value Evaluator based on T/F argument
        public string BoolNumEval(string tf, decimal x, decimal y)
        {
            string sBoolNumE = "";
            decimal dsum = 0;

            switch (tf.ToUpper())
            {
                case "F":
                    dsum += x + y;
                    sBoolNumE = "<font color='brown'> $ " + dsum.ToString() + "</font>";
                    break;

                case "T":
                    dsum += x + y;
                    dsum = (dsum / 100) * 100;
                    sBoolNumE = "<font color='blue'> " + dsum.ToString() + "%</font>";
                    break;
            }                
            return sBoolNumE;        }
    }
}