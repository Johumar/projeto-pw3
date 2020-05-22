using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcGettingStarte.Controllers
{

    public class TabuadaController : Controller
    {
        public IActionResult Calcular(){
            int[] resultado = new int [10];
            for(int i = 1; i <= 10; i ++)
             resultado[i-1] = 5 * i;
             return View (resultado);
        }

    }


}