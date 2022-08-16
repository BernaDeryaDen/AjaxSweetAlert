using AjaxSweetAlert.Context;
using AjaxSweetAlert.Models;
using Microsoft.AspNetCore.Mvc;

namespace AjaxSweetAlert.Controllers
{
    public class SectorController : Controller
    {
        private readonly DataContext _context;

        public SectorController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Sector model )
        {
           //??? model.remove(id);
            if(ModelState.IsValid)
            {
                _context.Sectors.Add(model);
                var result = _context.SaveChangesAsync();    

                return Json("ok");    
            }
            return Json("nok");
        }
    }
}
