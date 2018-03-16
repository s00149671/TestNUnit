using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestingAssign1;

namespace PremiumInterface
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string gender = TextBox1.Text;
            int age = Convert.ToInt32(TextBox2);
            Premium prem = new Premium();
            double g = prem.CalcPremium(age, gender);
            Label3.Text = Convert.ToString(g);
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Premium c1 = new Premium();
            int age = int.Parse(TextBox1.Text);
            string gender = TextBox2.Text;

            Gender.Text += gender;
            Age.Text += age.ToString();
            Premium.Text += "$" + c1.CalcPremium(age, gender).ToString();
        }
    }
}