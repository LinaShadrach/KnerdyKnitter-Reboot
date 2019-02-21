using System;
using System.Collections.Generic;
namespace KnerdyKnitter.Models
{
    public class Scarf : Garment
    {
        public int[,] Creation { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public string Primary { get; set; }
        public string Secondary { get; set; }
        public DateTime CreationDate { get; set; }
        public static List<Scarf> instances  = new List<Scarf>{};
        private int _rule;
        public Scarf(int chosenRule, int width, int length)
        {
            ChosenRule = Rule.ConvertRuleToIntArray(chosenRule);
            Length = length;
            Width = width;
            CreateGarment();
        }
        public Scarf(int chosenRule, int width, int length, string primary, string secondary, DateTime creationDate)
        {
            _rule = chosenRule;
            ChosenRule = Rule.ConvertRuleToIntArray(chosenRule);
            Length = length;
            Width = width;
            Primary = primary;
            Secondary = secondary;
            CreationDate = creationDate;
            CreateGarment();
            instances.Add(this);

        }
        public int GetRuleAsNumber()
        {
          return _rule;
        }
        public void CreateGarment()
        {
			      Creation = new int[Width, Length];
            CreateBaseRow();
            for (int rowIndex = 1; rowIndex < Length; rowIndex++ )
            {
                BuildRow(rowIndex);
            }
        }
        public void BuildRow(int rowIndex)
        {
            for (int column = 0; column < Width; column++)
            {
                if (column == 0)
                {
                    Creation[column, rowIndex] = GetCell(new int[] { Creation[Width - 1, rowIndex - 1], Creation[column, rowIndex - 1], Creation[column + 1, rowIndex - 1] });
                }
                else if (column == Width-1)
                {
                    Creation[column, rowIndex] = GetCell(new int[] { Creation[column - 1, rowIndex - 1], Creation[column, rowIndex - 1], Creation[0, rowIndex - 1] });
                }
                else
                {
                    Creation[column, rowIndex] = GetCell(new int[] { Creation[column - 1, rowIndex - 1], Creation[column, rowIndex - 1], Creation[column + 1, rowIndex - 1] });
                }
            }
        }
        public int GetCell(int[] tripletArray)
        {
            int newCell=0;
            string triplet = string.Join("", tripletArray);
            int position = Convert.ToInt32(triplet, 2);
            newCell = ChosenRule[position];
            return newCell;
        }
        public void CreateBaseRow()
        {
            for (int columnIndex = 0; columnIndex < Width; columnIndex++)
            {
              if(columnIndex == Width/2)
              {
                Creation[columnIndex, 0] = 1;
              }
              else
              {
                Creation[columnIndex, 0] = 0;
              }
            }
        }

    }
}
