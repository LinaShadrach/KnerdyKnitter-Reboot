using System;
using KnerdyKnitter.Models;

namespace KnerdyKnitter.ViewModels
{
    public class ScarfViewModel : Scarf
    {
        public static int[] StarterRule = new int[8]{ 0, 0, 0, 1, 1, 1, 1, 0 };
        public static int[,] BaseCombos { get; set; }
        public string PrimaryColor { get; set; }
        public string SecondaryColor { get; set; }
        public int XCoor { get; set; }
        public int YCoor { get; set; }
        public int SvgWidth { get; set; }
        public int SvgLength { get; set; }
        public string[,] CreationClassesAndIds { get; set; }
        public ScarfViewModel(int chosenRule, int width, int length, string primaryColor, string secondaryColor) : 
            base(chosenRule,  width,  length)
        {
            PrimaryColor = primaryColor;
            SecondaryColor = secondaryColor;
            BaseCombos = Rule.BaseCombos;
        }
        public void CreateClassesAndIds()
        {
            
        }
        public string GetHtmlId()
        {
            return "";
        }

       
    }
}
