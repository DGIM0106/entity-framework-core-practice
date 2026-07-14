using EFCorePractice.App.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace EFCorePractice.App
{
    internal class main
    {
        static void Main(string[] args)
        {
            var context = new EfcorePracticeDbContext();

            /*var categorias = new Categoria()
            {
                NombreCategoria = "Tecnologia"
            };

            context.Add(categorias);
            context.SaveChanges();*/

            /*var newProducto = new Producto()
            {
                NombreProducto = "Telefono",
                Precio = 1500,
                Categoria = new Categoria()
                {
                    NombreCategoria = "Tecnologia"
                }
            };

            context.Add(newProducto);
            context.SaveChanges();

            var newProducto2 = new Producto()
            {
                NombreProducto = "Computadora",
                Precio = 2500,
                CategoriaId = 1
            };
            context.Add(newProducto2);
            context.SaveChanges();*/

            var nombre = "Tecnologia";

            var filtro = context.Categorias.Where(item => item.NombreCategoria == nombre).GroupBy(item => item.NombreCategoria).ToList();

            Console.WriteLine(filtro.FirstOrDefault().Key);

            //var filtro = context.Categorias.Where(item => item.NombreCategoria == nombre);
            /*foreach (var i in filtro)
            {
                Console.WriteLine(i.NombreCategoria);
            }*/


            Console.WriteLine("*********");

            var filtro2 = context.Productos.Where(item => item.Categoria.NombreCategoria == nombre).Select(item =>item.NombreProducto);
            foreach (var i in filtro2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("*********");

            var innerjoin = context.Productos.Include(obj=>obj.Categoria).ToList();
            
            foreach (var i in innerjoin)
            {
                Console.WriteLine(i.NombreProducto + " - " + (i.Categoria?.NombreCategoria ?? "Sin categoria"));
            }
            

            Console.WriteLine("*********");
        }
    }
}
