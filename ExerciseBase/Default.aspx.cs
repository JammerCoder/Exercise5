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
                this.lblResult.Text = Convert.ToInt32(this.txtNumber.Text) + this.txtString.Text;
            }
            catch (Exception ex)
            {
                this.lblResult.Text = ex.Message;
            }
            
        }

        //b.Create Another Function
        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int sum = 0;
                sum += Int32.Parse(this.txtFirstNumber.Text) + Int32.Parse(this.txtSecondNumber.Text) + Int32.Parse(this.txtThirdNumber.Text);
                if (sum < 0)
                    this.lblTotal.Text = "<font color='red'> " + sum.ToString() + "</font>";
                if (sum >= 0)
                    this.lblTotal.Text = "<font color='black'> " + sum.ToString() + "</font>";
            }
            catch (Exception ex)
            {
                this.lblTotal.Text = ex.Message;
            }
            
        }

        protected void btnCalc2_Click(object sender, EventArgs e)
        {
            try
            {
                int sum = 0;
                sum += Int32.Parse(this.txtNum1.Text) + Int32.Parse(this.txtNum2.Text) + Int32.Parse(this.txtNum3.Text);
                if (sum < 0)
                    this.lblTotal2.Text = "<font size='300'> " + sum.ToString() + "</font>";
                if (sum >= 0)
                    this.lblTotal2.Text = "<font color='green'> " + sum.ToString() + "</font>";
            }
            catch (Exception ex)
            {
                this.lblTotal2.Text = ex.Message;
            }
        }

        protected void btnProceed_Click(object sender, EventArgs e)
        {
            try
            {
                decimal sum = 0;            
                
                switch(this.txtBool.Text.ToUpper())
                {
                    case "F":
                        sum += Decimal.Parse(this.txtNumber2.Text) + Decimal.Parse(this.txtNumber3.Text);
                        this.lblOutPut.Text = "<font color='brown'> $ " + sum.ToString() + "</font>";
                        break;

                    case "T":
                        sum += Decimal.Parse(this.txtNumber2.Text) + Decimal.Parse(this.txtNumber3.Text);
                        sum = (sum / 100)*100;
                        
                        this.lblOutPut.Text = "<font color='blue'> " + sum.ToString() + "%</font>";
                        break;

                }
                
            }
            catch (Exception ex)
            {
                this.lblOutPut.Text = ex.Message;
            }
        }
    }
}