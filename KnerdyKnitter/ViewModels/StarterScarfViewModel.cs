﻿using System;
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
        public string[,] CreationClasses { get; set; }
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
  
        }

        private string GetCellIds(int row, int col)
        {
            throw new NotImplementedException();
        }

        private string GetCellClasses(int row, int col)
        {
            throw new NotImplementedException();
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
