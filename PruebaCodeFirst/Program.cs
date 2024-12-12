// See https://aka.ms/new-console-template for more information
using DataCodeFirst.Contexts;
using DataCodeFirst.Models;

using (var context = new ComidaContexts())
{
    /*List<Comida> comidas = new List<Comida>();

    comidas.Add(new Comida { Nombre = "Salchipapa", Categoria = "Papas Fritas", Precio = 3.5, TiempoPreparacionMin = 10, EsVegetariano=false});
    comidas.Add(new Comida { Nombre = "Pizza Hawaiana", Categoria = "Pizza", Precio = 8, TiempoPreparacionMin = 15, EsVegetariano = true });
    comidas.Add(new Comida { Nombre = "Hamburguesa Clasica", Categoria = "Hamburguesa", Precio = 5, TiempoPreparacionMin = 12, EsVegetariano = false });
    comidas.Add(new Comida { Nombre = "Empanada Mixta", Categoria = "Empanadas", Precio = 4, TiempoPreparacionMin = 8, EsVegetariano = false });
    comidas.Add(new Comida { Nombre = "Tacos al vapor", Categoria = "Taco", Precio = 3, TiempoPreparacionMin = 7, EsVegetariano = false });
    
    context.Comida.AddRange(comidas);
    context.SaveChanges();*/
    var comida = context.Comida.ToList();
    foreach( var com in comida)
    {
        Console.WriteLine(com.ID + " - " + com.Nombre + " - " + com.Categoria + " - " + com.Precio + " - " + com.TiempoPreparacionMin+" - "+com.EsVegetariano);
    }
}