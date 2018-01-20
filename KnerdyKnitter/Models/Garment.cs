using System;
namespace KnerdyKnitter.Models
{
    public interface IGarment
    {
        int Id { get; set; }
        int[] ChosenRule { get; set; }
    }
}
