using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class EditModel : PageModel
{
    private readonly AppDbContext _context;
    public EditModel(AppDbContext context)
    {
        _context = context;
    }

[BindProperty]
    public Order Order {get;set;}

    public void OnGet(int id)
    {
        Order = _context.Orders.Find(id);
    }

    public IActionResult OnPost()
    {


        _context.Orders.Update(Order);
        _context.SaveChanges();
        // Redirect to Page
        return RedirectToPage("Product");
    }

}