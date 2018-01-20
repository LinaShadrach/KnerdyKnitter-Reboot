using System;
namespace KnerdyKnitter.Models
{
    public static class Rule
    {
        public static int[,] BaseCombos =
        {
			{ 0, 0, 0 },
			{ 0, 0 ,1 },
			{ 0, 1, 0 },
			{ 0, 1, 1 },
			{ 1, 0, 0 },
			{ 1, 0, 1 },
			{ 1, 1, 0 },
			{ 1, 1, 1 }
        };
        public static int[] ConvertRuleToIntArray(int ruleAsDecimal){
            string ruleAsBinaryString = Convert.ToString(ruleAsDecimal, 2);
            if(ruleAsBinaryString.Length != 8)
            {
                ruleAsBinaryString = AddZeroesToBeginnning(ruleAsBinaryString);
            }
            int[] ruleAsIntArray = new int[8];
            int count = 0;
            foreach(char bit in ruleAsBinaryString)
            {
                ruleAsIntArray[count] = Convert.ToInt32(new string(bit, 1));
                count++;
            }
            Array.Reverse(ruleAsIntArray);
            return ruleAsIntArray;
        }
        public static string AddZeroesToBeginnning(string ruleAsString)
        {
            string zeroes = "";
            for (int i = 0; i < (8 - ruleAsString.Length); i++)
            {
                zeroes += "0";
            }
            ruleAsString = zeroes + ruleAsString;
            return ruleAsString;
        }
    }
}
