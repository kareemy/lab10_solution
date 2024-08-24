using System.ComponentModel.DataAnnotations;

namespace lab10_solution.Models;

public class Product
{
    public int ProductID {get; set;}
    public string Name {get; set;} = string.Empty;
    public string Description {get; set;} = string.Empty;
    
    [Display(Name = "Product Image")]
    public string ImageURL {get; set;} = string.Empty;
    public List<Review> Reviews {get; set;} = default!; // Navigation Property to Reviews
}