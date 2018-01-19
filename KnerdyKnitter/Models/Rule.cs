using System;
namespace KnerdyKnitter.Models
{
    public static class Rule
    {
        public static int[,] BaseCombos =
        {   { 1, 1, 1 },
            { 1, 1, 0 },
            { 1, 0, 1 },
            { 1, 0, 0 },
            { 0, 1, 1 },
            { 0, 1, 0 },
            { 0, 0 ,1 },
            { 0, 0, 0 }
        };
        public static int[] GetRuleAsIntArray(int ruleAsDecimal){
            int[] ruleAsIntArray = new int[8];
            int count = 0;
            foreach(char bit in (Convert.ToString(ruleAsDecimal, 2)))
            {
                ruleAsIntArray[count] = bit;
                count++;
            }
            return ruleAsIntArray;
        }
    }
}
