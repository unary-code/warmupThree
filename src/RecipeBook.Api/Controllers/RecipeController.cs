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
		[HttpGet]
		public IActionResult AddNewRecipe([FromQuery]RecipeEntity recipeEntity)
		{
			var businessLogic = new Recipe();
			businessLogic.SaveRecipe(recipeEntity);
			// return Ok();
			return Ok("A message that says this GET request went okay");
		}
	}
}