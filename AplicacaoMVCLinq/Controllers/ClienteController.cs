
using AplicacaoMVCLinq.Models;
using Microsoft.AspNetCore.Mvc;

namespace AplicacaoMVCLinq.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult index()
        {
            return View();
        }


        public IActionResult GetCliente()
        {
            Cliente c1 = new Cliente(123456, "Beatriz silva", "beatriz080407@gmail.com", "14991328382", new DateOnly(2007, 04, 08));
            Cliente c2 = new Cliente(987543, "Livia solla", "livia.linda@gmail.com", "14988381891", new DateOnly(2006, 07, 12));
            Cliente c3 = new Cliente(976564, "Ana julia", "anageremiias@gmail.com", "14988078439", new DateOnly(2007, 01, 03));
            Cliente c4 = new Cliente(888888, "Ana Clara", "ana.chiaramonte@gmail.com", "14991623389", new DateOnly(2007, 05, 20));
            Cliente c5 = new Cliente(645902, "Flaviana", "flaviana16nasc@gmail.com", "14997445210", new DateOnly(1982, 11, 16));

            List<Cliente> listClientes = new List<Cliente>();
            //Adicionar os objetos alunos na lista alunos 
            listClientes.Add(c1);
            listClientes.Add(c2);
            listClientes.Add(c3);
            listClientes.Add(c4);
            listClientes.Add(c5);
            return View(listClientes);
        }
    }
}
