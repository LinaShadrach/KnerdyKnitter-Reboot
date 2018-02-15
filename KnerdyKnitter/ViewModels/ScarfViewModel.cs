﻿using System;
using KnerdyKnitter.Models;

namespace KnerdyKnitter.ViewModels
{
    public class ScarfViewModel : Scarf
    {
        public static int[,] BaseCombos { get; set; }
        public string PrimaryColor { get; set; }
        public string SecondaryColor { get; set; }
        public int XCoor { get; set; }
        public int YCoor { get; set; }
        public string[,] CreationClassesAndIds { get; set; }
        public ScarfViewModel() : 
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
        public string GetHtmlId()
        {
            return "";
        }
        public int GetSvgWidth()
        {
            return width * 10;
        }
        public int GetSvgLength()
        {
            return length * 10;
        }

       
    }
}
