using FullStackFun.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FullStackFun.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarriottFoodController : ControllerBase
    {
        private FoodDbContext _foodcontext;

        public MarriottFoodController(FoodDbContext temp)
        {
            _foodcontext = temp;
        }

        [HttpGet(Name = "GetMarriottFood")]
        public IEnumerable<MarriottFood> Get()
        {
            var foodList = _foodcontext.Foods.ToList();

            return foodList;
        }
    }
}
