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

            var filtro = context.Categorias.Where(item => item.NombreCategoria == "Tecnologia").ToList();

            foreach (var i in filtro)
            {
                Console.WriteLine(i.NombreCategoria);
            }
        }
    }
}
