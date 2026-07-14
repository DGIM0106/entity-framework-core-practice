using EFCorePractice.App.Models;
using Microsoft.Extensions.Configuration;

namespace EFCorePractice.App
{
    internal class main
    {
        static void Main(string[] args)
        {
            var context = new EfcorePracticeDbContext();

            /*var categorias = new Categoria
            {
                NombreCategoria = "Tecnologia"
            };

            context.Add(categorias);
            context.SaveChanges();*/

            foreach (var i in context.Categorias)
            {
                Console.WriteLine(i.NombreCategoria);
            }
        }
    }
}
