using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcGettingStarte.Controllers
{

    public class TabuadaController : Controller
    {
        public IActionResult Calcular([FromQuery] int numero){
            int[] resultado = new int [10];
            for(int i = 1; i <= 10; i ++)
             resultado[i-1] = numero * i;
             ViewData["numero"] = numero;
             return View (resultado);
        }

    }


}