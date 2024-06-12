using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coffee.Data;
using Coffee.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Coffee.Pages
{
        public class IndexModel : PageModel
{
    private readonly CoffeeContext db ;
    public IndexModel (CoffeeContext db) => this.db = db;
    public List<Product> Products { get; set; } = new List<Product>(); 
    public Product FeaturedProduct { get; set; } 
    
    public async Task OnGetAsync()
    {
        Products = await db.Products.ToListAsync();
        FeaturedProduct = Products.ElementAt(new 
        Random().Next(Products.Count));

     }
    
    } 
}
    





