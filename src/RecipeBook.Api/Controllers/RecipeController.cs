using Microsoft.AspNetCore.Mvc;
using RecipeBook.ServiceLibrary.Domains;
using RecipeBook.ServiceLibrary.Entities;

namespace RecipeBook.Api.Controllers
{
	// [Route("api/[controller]")]
	[Route("api/recipe")]
	[ApiController]
	public class RecipeController : ControllerBase
	{
		[HttpGet] // api/recipes?pageSize=10&pageNumber=1
		public async Task<IActionResult> GetListAsync(
			[FromQuery]int pageSize,
			[FromQuery]int pageNumber)
		{
			return Ok(pageSize + " " + pageNumber);
		}

	}
}