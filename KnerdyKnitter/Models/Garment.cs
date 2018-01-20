using System;
namespace KnerdyKnitter.Models
{
    public interface IGarment
    {
        int Id { get; set; }
        string type { get; set; }
        int[] rule { get; set; }
    }
}
