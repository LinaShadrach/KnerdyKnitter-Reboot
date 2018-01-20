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
            CreateGarment(length, width);
        }
        public void CreateGarment(int length, int width)
        {
            int[] baseRow = CreateBaseRow(width);
            Creation = new int[width, length];
            for (int row = 0; row < length; row++ )
            {
                for (int column = 0; column < length; column++)
                {
                    if (column == 0)
                    {
                        Creation[row, column] = GetCell(new int[] { baseRow[width], baseRow[column], baseRow[column + 1] });                    
                    }
                    else if (column == width)
                    {
                        Creation[row, column] = GetCell(new int[] { baseRow[column - 1], baseRow[column], baseRow[0] });
                    }
                    else {
						Creation[row, column] = GetCell(new int[] { baseRow[column-1], baseRow[column], baseRow[column + 1]});
                    }
                }
            }
        }
        public int GetCell(int[] currentRow)
        {
            int cell = 0;
            return cell;
        }
        public static int[] CreateBaseRow(int width)
        {
            return new int[] { 1, 0, 1, 0, 1, 0, 1, 0 };
        }

    }
}
