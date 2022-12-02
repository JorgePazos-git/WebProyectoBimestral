using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebProyectoBimestral.Models;
using WebProyectoBimestral.Code;

namespace WebProyectoBimestral.Controllers
{
    public class Ocr : Controller
    {
        string apiUrl = "https://localhost:7001/api";

        // GET: Imagen
        public ActionResult Imagen()
        {
            return View();
        }

        // POST: Imagen
        [HttpPost]
        public ActionResult Imagen(Imagen imagen, string ruta)
        {
            var resp = ApiConsumer.CrearImagen(apiUrl, ruta);
            imagen.url = ruta;

            ViewBag.text = resp;
            ViewBag.url = ruta;
            return View();
        }
    }
}
