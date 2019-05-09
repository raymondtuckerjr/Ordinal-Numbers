using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    if (Page.IsPostBack)
        {
            Page.Validate();
            if (Page.IsValid)
            {
                int lastCharacters = 0;
                if (cardinalNumber.Text.Length>1)
                {
                    lastCharacters = Convert.ToInt16(
                        cardinalNumber.Text.Substring(
                        cardinalNumber.Text.Length - 2));
                    if (lastCharacters > 10 && lastCharacters < 14)
                        ordinalNumber.Text = cardinalNumber.Text + "th";
                    else
                    {
                        lastCharacters = Convert.ToInt16(
                            cardinalNumber.Text.Substring(
                             cardinalNumber.Text.Length - 1));
                        if (lastCharacters == 1)
                            ordinalNumber.Text = cardinalNumber.Text + "st";
                        else if (lastCharacters == 2)
                            ordinalNumber.Text = cardinalNumber.Text + "nd";
                        else if (lastCharacters == 3)
                            ordinalNumber.Text = cardinalNumber.Text + "rd";
                        else
                            ordinalNumber.Text = cardinalNumber.Text + "th";

                    }
                }
                else if (cardinalNumber.Text.Length ==1)
                {
                    if (Convert.ToInt16(cardinalNumber.Text) == 1)
                        ordinalNumber.Text = cardinalNumber.Text + "st";
                    else if (Convert.ToInt16(cardinalNumber.Text) == 2)
                        ordinalNumber.Text = cardinalNumber.Text + "nd";
                    else if (Convert.ToInt16(
                        cardinalNumber.Text) == 3)
                        ordinalNumber.Text = cardinalNumber.Text + "rd";
                    else
                        ordinalNumber.Text = cardinalNumber.Text + "th";
                }
            }
        }
    }
}