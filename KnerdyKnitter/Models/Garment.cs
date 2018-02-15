using System;
namespace KnerdyKnitter.Models
{
    public abstract class Garment
    {
        public int Id { get; set; }
        public int[] ChosenRule { get; set; }
    }
}
