// See https://aka.ms/new-console-template for more information
using Contexts;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");


string connection = "";

var optionBuilder = new DbContextOptionsBuilder<StoreContext>();

optionBuilder.UseLazyLoadingProxies(true)
    .LogTo(s => Console.WriteLine(s))
    .UseNpgsql(connection);


using (var context = new StoreContext(optionBuilder.Options))
{
    var brands = context.Brands.ToList();
    //Hace más consultas
    Console.WriteLine(brands.FirstOrDefault()?.Products.FirstOrDefault()?.name ?? "");
}