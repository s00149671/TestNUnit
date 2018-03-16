using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestingAssign1;

namespace PremiumWeb
{
    public partial class premiumweb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            Premium c1 = new Premium();
            int age = int.Parse(TextboxAge.Text);
            string gender = TextboxGender.Text;

            Gender.Text += gender;
            Age.Text += age.ToString();
            Premium.Text += "$" + c1.CalcPremium(age, gender).ToString();
        }
    }
}