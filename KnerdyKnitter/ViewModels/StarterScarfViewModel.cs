using System;
using KnerdyKnitter.Models;

namespace KnerdyKnitter.ViewModels
{
    public class StarterScarfViewModel : Scarf
    {
        public static int[,] BaseCombos { get; set; }
        public string PrimaryColor { get; set; }
        public string SecondaryColor { get; set; }
        public int XCoor { get; set; }
        public int YCoor { get; set; }
        public string[,] CreationIds { get; set; }
        public StarterScarfViewModel() : 
         base(30, 10,  100)
        {
            PrimaryColor = GetRandomLightColor();
            SecondaryColor = GetRandomDarkColor();
            BaseCombos = Rule.BaseCombos;
        }

        private string GetRandomDarkColor()
        {
            return "#775382";
        }

        private string GetRandomLightColor()
        {
            return "#f2ffb2";
        }

        public void CreateClassesAndIds()
        {
            for (int row = 0; row < Creation.GetLength(0); row++)
            {
                for (int col = 0; col < Creation.Length / Creation.GetLength(0); col++)
                {
                    CreationIds[row, col] = GetCellIds(row, col);
                }
            }
        }
        public string GetCellIds(int row, int col)
        {
            return "cell" + row + col;
        }

        public string GetHtmlId()
        {
            return "";
        }
        public int GetSvgWidth()
        {
            return Width * 10;
        }
        public int GetSvgLength()
        {
            return Length * 10;
        }

       
    }
}
