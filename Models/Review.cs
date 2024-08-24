using System.ComponentModel.DataAnnotations;

namespace lab10_solution.Models;

public class Review
{
    public int ReviewID {get; set;}

    [Range(1,5)]
    public int Score {get; set;}
    public string ReviewText {get; set;} = string.Empty;
    public int ProductID {get; set;} // Foreign Key
    public Product Product {get; set;} = default!; // Navigation Property back to Product
}