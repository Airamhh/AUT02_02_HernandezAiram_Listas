using AUT02_02_HernandezAiram_Listas.Models;
using Microsoft.AspNetCore.Mvc;

namespace AUT02_02_HernandezAiram_Listas.Controllers
{
    // Para cada método una vista
    public class PersonajeController : Controller
    {

        private static List<Personaje> listaPersonaje = new List<Personaje>
        {
            new Personaje { Id = 1, Name = "Airam", Family = "Hernández", NChildren = 0},
            new Personaje { Id = 2, Name = "Jorge", Family = "Pérez", NChildren = 0},
            new Personaje { Id = 3, Name = "Máximo", Family = "Méndez", NChildren = 0}
        };
        public IActionResult Index()
        {
            return View(listaPersonaje);
        }


        public IActionResult Create()
        {
            return View();
            
        }

        public IActionResult Details(int id)
        {
            int posicion = 0;
            bool fin = false;
            int contador = 0;
            while (!fin || contador >= listaPersonaje.Count)
            {
                if (listaPersonaje[contador].Id == id)
                {
                    fin = true;
                    posicion = contador;
                }
                else
                {
                    contador++;
                }
            }

            Personaje personaje = listaPersonaje[posicion];
            return View(personaje);


        }

        [HttpPost]

        public IActionResult Create(Personaje nuevoPersonaje)
        {
            nuevoPersonaje.Id = listaPersonaje[listaPersonaje.Count - 1].Id + 1;
            listaPersonaje.Add(nuevoPersonaje);

            return Redirect("Index");
        }
    }
}
