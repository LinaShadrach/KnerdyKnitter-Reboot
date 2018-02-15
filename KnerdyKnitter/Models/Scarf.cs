using System;
namespace KnerdyKnitter.Models
{
    public class Scarf : IGarment
    {
        public int Id { get; set; }
        public int[] ChosenRule { get; set; }
        public int[,] Creation { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }

        public Scarf(int chosenRule, int width, int length)
        {
            ChosenRule = Rule.ConvertRuleToIntArray(chosenRule);
            Length = length;
            Width = width;
            CreateGarment();
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
                    Creation[rowIndex, column] = GetCell(new int[] { Creation[rowIndex - 1, Width - 1], Creation[rowIndex - 1, column], Creation[rowIndex - 1, column + 1] });
                }
                else if (column == Width-1)
                {
                    Creation[rowIndex, column] = GetCell(new int[] { Creation[rowIndex - 1, column - 1], Creation[rowIndex - 1, column], Creation[rowIndex - 1, 0] });
                }
                else
                {
                    Creation[rowIndex, column] = GetCell(new int[] { Creation[rowIndex - 1, column - 1], Creation[rowIndex - 1, column], Creation[rowIndex - 1, column + 1] });
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
            int[] baseRow = new int[] { 0, 0, 0, 1, 1, 1, 1, 0 };
            for (int columnIndex = 1; columnIndex < Width; columnIndex++)
            {
                Creation[0, columnIndex] = baseRow[columnIndex];
            }
        }

    }
}
