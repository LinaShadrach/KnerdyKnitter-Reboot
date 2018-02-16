using System;
namespace KnerdyKnitter.Models
{
    public class Scarf : Garment
    {
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
                Console.WriteLine("rowIndex: "+rowIndex);
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
            int[] baseRow = new int[] { 1, 1, 0, 0, 0, 1, 1, 1, 1, 0 };
            Console.Write(baseRow.Length);
            for (int columnIndex = 0; columnIndex < Width; columnIndex++)
            {
                Creation[columnIndex, 0] = baseRow[columnIndex];
            }
        }

    }
}
