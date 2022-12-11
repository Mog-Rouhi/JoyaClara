using JoyaClara.Models;
using Microsoft.AspNetCore.Mvc;

namespace JoyaClara.Controllers
{
    public class JoyaController : Controller
    {
        private readonly IJoyaRepository _joyaRepository;
        private readonly ICategoryRepository _categoryRepository;

        public JoyaController(IJoyaRepository joyaRepository, ICategoryRepository categoryRepository)
        {
            _joyaRepository = joyaRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List() 
        {
            ViewBag.CurrentCategory = "Rings";
            return View(_joyaRepository.AllJoyas);  
        }
    }
}
