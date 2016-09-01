using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Gari.Controllers
{
    public class NewJobController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            try
            {
                throw new Exception("Testing the waters");
            }
            catch(Exception err)
            {
                // Need to log this.
            }
            return View();
        }
    }
}
