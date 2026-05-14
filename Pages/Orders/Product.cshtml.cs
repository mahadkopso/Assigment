using Azure;
using Microsoft.AspNetCore.Mvc.RazorPages;
public class ProductModel : PageModel
{
// Connect to Database
private readonly AppDbContext _context;
public ProductModel(AppDbContext context)
{
_context=context;
}
public List<Order> Orders {get; set;}
public void OnGet()
{
Orders=_context.Orders.ToList();
}
}