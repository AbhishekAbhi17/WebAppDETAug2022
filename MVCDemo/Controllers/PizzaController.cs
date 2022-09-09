using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;
using MVCDemo.Service;

namespace MVCDemo.Controllers
{
    public class PizzaController : Controller
    {
        private int id;
        private object pizzaService;

        public IActionResult Index()
        {
            List<Pizza> pizzas = PizzaService.GetAll();
            return View(pizzas);
        }
        public IActionResult List()
        {
            List<Pizza> pizzas = PizzaService.GetAll();
            return View(pizzas);
        }
        public IActionResult Details()
        {
            Pizza p = PizzaService.Get(id);
            return View(p);
        }

       public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Pizza p)
        {
            PizzaService.Add(p);
            return RedirectToAction("List");
        }
        public IActionResult Delete(int id)
        {
            Pizza p = PizzaService.Get(id);
            if (p != null)
                return View(p);
            else
                return RedirectToAction("List");
        }
        [HttpPost]
        public IActionResult Delete(Pizza p)
        {
            PizzaService.Delete(p.Id);
                return RedirectToAction("List");
        }

        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(int ID, string Name, PizzaSize Size, bool IsGlutenFree, decimal Price)
        {
            Pizza p = new Pizza { Id = ID, Name = Name, Size = Size, Price = Price, IsGlutenFree = IsGlutenFree };
            PizzaService.Update(p);
            return RedirectToAction("List");

        }
    }
}
