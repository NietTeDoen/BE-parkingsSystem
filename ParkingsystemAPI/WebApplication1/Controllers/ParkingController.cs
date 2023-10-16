using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParkingController : ControllerBase
    {
        public List<ParkingPlace> GetParkingPlaces()
        {
            List<ParkingPlace> ParkingPlaces = new List<ParkingPlace>
            {

            };

            return ParkingPlaces;
        }
    }
}
