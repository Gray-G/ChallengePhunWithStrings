using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePhunWithStrings
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 1.  Reverse your name
            string name = "Grayson Golden";
            // In my case, the result would be:
            // robaT boB

            /* // SOLUTION 1
            char[] charArray = new char[14];
            int j = 0;

            for (int i = name.Length - 1; i >= 0; i--)
            {
                charArray[j] = name[i];
                j++;
            }

            string nameReversed = "";

            for (int i = 0; i < charArray.Length; i++)
            {
                nameReversed += charArray[i];
            }

            resultLabel.Text = nameReversed;
            */

            // 2.  Reverse this sequence:
            string names = "Luke,Leia,Han,Chewbacca";
            // When you're finished it should look like this:
            // Chewbacca,Han,Leia,Luke

            /* // SOLUTION 2
            string[] namesArray = names.Split(',');
            string namesReversed = "";

            for (int i = namesArray.Length - 1; i >= 0; i--)
            {
                if (i != 0)
                {
                    namesReversed += namesArray[i] + ",";
                }
                else namesReversed += namesArray[i];
            }

            resultLabel.Text = namesReversed;
            */

            // 3. Use the sequence to create ascii art:
            // *****luke*****
            // *****leia*****
            // *****han******
            // **Chewbacca***

            /* // SOLUTION 3
            string[] namesArray2 = new string[4];
            namesArray2 = names.Split(',');
            string result = "";

            for (int i = 0; i < namesArray2.Length; i++)
            {
                int padLeft = (14 - namesArray2[i].Length) / 2;
                string temp = namesArray2[i].PadLeft(namesArray2[i].Length + padLeft, '*');
                result += temp.PadRight(14, '*');
                result += "<br />";
            }

            resultLabel.Text = result;
            */


            // 4. Solve this puzzle:

     
            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";

            // Once you fix it with string helper methods, it should read:
            // Now is the time for all good men to come to the aid of their country.

            /* // SOLUTION 4
            string removeMe = "remove-me";
            int index = puzzle.IndexOf(removeMe);
            puzzle = puzzle.Remove(index, removeMe.Length);
            puzzle = puzzle.Replace('Z', 'T');
            puzzle = puzzle.ToLower();
            puzzle = puzzle.Substring(0, 1).ToUpper() + puzzle.Substring(1);
            resultLabel.Text = puzzle;
            */

        }
    }
}