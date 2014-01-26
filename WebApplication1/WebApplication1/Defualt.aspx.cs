using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Model;

namespace WebApplication1
{
    public partial class Defualt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                //beräknar:
                int answer = TextAnalyzer.GetNumberOfCapitalse(TextBox.Text);
                //visar resultat:
                ResultLiteral.Text = String.Format(ResultLiteral.Text, answer);
                ResultPlaceHolder.Visible = true;
                //gråmarkerar:
                TextBox.Enabled = false;
                //ändrar knapp:
                Button.Text = "Rensa";
                Button.ID = "NewButton";
            }

        }
        //ändrar tillbaka, vid klick på nya knappen:
        protected void NewButton_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                Button.Text = "Bestäm antalet versaler";
                Button.ID = "Button";
            }
        }
    }
}