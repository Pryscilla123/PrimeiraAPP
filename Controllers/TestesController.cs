using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PrimeiraApp.Controllers
{
    [Route("minha-conta", Order = 1)]
    [Route("gestao-da-conta", Order = 0)]
    public class TestesController : Controller
    {
        // GET: TestesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TestesController/Details/5
        [HttpGet("detalhes/{id:int}")]
        public ActionResult Details(int id, string teste, string teste2)
        {
            return View();
        }

        // GET: TestesController/Create
        [HttpGet("novo")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: TestesController/Create
        [HttpPost("novo")]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TestesController/Edit/5
        [HttpGet("editar/{id:int}")]
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TestesController/Edit/5
        [HttpPost("editar/{id:int}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TestesController/Delete/5
        [HttpGet("excluir/{id:int}")]
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TestesController/Delete/5
        [HttpPost("excluir/{id:int}")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
