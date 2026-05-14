using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
public class CreateModel: PageModel
{
private readonly AppDbContext _context;
public CreateModel(AppDbContext context)
{
_context=context;
}
[BindProperty]
public string CustomerName { get; set; }
[BindProperty]
public string ProductName { get; set; }
[BindProperty]
public int Quantity { get; set; }
[BindProperty]
    public decimal Price { get; set; }
[BindProperty]
public DateTime OrderDate { get; set; }
public IActionResult OnPost()
{
var Order = new Order
{
    CustomerName = CustomerName,
    ProductName = ProductName,
    Quantity = Quantity,
    Price = Price,
OrderDate=OrderDate,
};
_context.Orders.Add(Order);
_context.SaveChanges();
return RedirectToPage("Product");
}
}