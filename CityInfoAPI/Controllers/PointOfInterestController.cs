using CityInfoAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityInfoAPI.Controllers
{
	[Route("api/cities/{cityId}/pointofinterest")]
	[ApiController]
	public class PointOfInterestController : ControllerBase
	{

		[HttpGet]
		public ActionResult<IEnumerable<PointOfInterestDto>> GetPointsOfInterest(int cityId)
		{
			var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);
			if(cityId == null) 
			{
				return NotFound();
			}
			return Ok(city.PointOfInterests);
		}
	}
}
