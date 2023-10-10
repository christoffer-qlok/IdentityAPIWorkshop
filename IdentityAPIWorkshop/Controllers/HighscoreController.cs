using IdentityAPIWorkshop.Data;
using IdentityAPIWorkshop.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IdentityAPIWorkshop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HighscoreController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public HighscoreController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<HighscoreController>
        [HttpGet]
        public IEnumerable<HighscoreViewmodel> Get()
        {
            var result = _context
                .Highscores
                .Join(_context.Users,
                    h => h.UserId,
                    u => u.Id,
                    (h, u) => new HighscoreViewmodel()
                    {
                        Name = u.Nick,
                        Score = h.Score
                    }
                )
                .OrderByDescending(h => h.Score)
                .ToList();

            return result;
        }
    }
}
