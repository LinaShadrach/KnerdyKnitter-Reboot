using System;
namespace KnerdyKnitter.Models
{
    public class Scarf : IGarment
    {
        public int Id { get; set; }
        public int[] ChosenRule { get; set; }
        public int[,] Creation { get; set; }

        public Scarf(int chosenRule, int length, int width)
        {
            ChosenRule = Rule.ConvertRuleToIntArray(chosenRule);
            //CreateGarment(length, width);
        }
        public void CreateGarment(int length, int width)
        {
			Creation = new int[width, length];
            CreateBaseRow();
            for (int rowIndex = 1; rowIndex < length; rowIndex++ )
            {
                BuildRow(rowIndex);
            }
        }
        public void BuildRow(int rowIndex)
        {
            int width = Creation.GetLength(0);
            for (int column = 0; column < width; column++)
            {
                if (column == 0)
                {
                    Creation[rowIndex, column] = GetCell(new int[] { Creation[rowIndex - 1, width - 1], Creation[rowIndex - 1, column], Creation[rowIndex - 1, column + 1] });
                }
                else if (column == width-1)
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
            int width = Creation.GetLength(0);
            int[] baseRow = new int[] { 0, 0, 0, 1, 1, 1, 1, 0 };
            for (int columnIndex = 1; columnIndex < width; columnIndex++)
            {
                Creation[0, columnIndex] = baseRow[columnIndex];
            }
        }

    }
}
