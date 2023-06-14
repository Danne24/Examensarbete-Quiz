using Examensarbete_Quiz.Data;
using Microsoft.AspNetCore.Mvc;

namespace Examensarbete_Quiz.Controllers
{
    public class QuestionController : Controller
    {
        ApplicationDbContext _applicationDbContext;

        public QuestionController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public IActionResult Index()
        {
            var results = _applicationDbContext.Questions.ToList();
            return View(results);
        }
    }
}
