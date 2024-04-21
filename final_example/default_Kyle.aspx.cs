using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace final_example
{
    public partial class default_Kyle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ConvertButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(NumberTextBox.Text, out int num))
            {
                string romanNumeral = IntToRoman(num);
                ResultLabel.Text = $"Roman numeral representation: {romanNumeral}";
            }
            else
            {
                ResultLabel.Text = "Invalid input. Please enter a valid integer.";
            }
        }

        public static string IntToRoman(int num)
        {
            if (num >= 1000) return "M" + IntToRoman(num - 1000);

            if (num >= 500) return num >= 900 ? ("CM" + IntToRoman(num - 900)) : ("D" + IntToRoman(num - 500));

            if (num >= 100) return num >= 400 ? ("CD" + IntToRoman(num - 400)) : ("C" + IntToRoman(num - 100));

            if (num >= 50) return num >= 90 ? ("XC" + IntToRoman(num - 90)) : ("L" + IntToRoman(num - 50));

            if (num >= 10) return num >= 40 ? ("XL" + IntToRoman(num - 40)) : ("X" + IntToRoman(num - 10));

            if (num >= 5) return num == 9 ? "IX" : "V" + IntToRoman(num - 5);

            if (num > 0) return num == 4 ? "IV" : "I" + IntToRoman(num - 1);

            return "";
        }
    }
}
