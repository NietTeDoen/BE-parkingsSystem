using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.models;

namespace ParkingSystemBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParkingController : ControllerBase
    {
        [HttpGet]
        [Route("test")]
        public string APITester()
        {
            string successmessage = "your call was successful";
            return successmessage;
        }
        [HttpGet]
        [Route("get/parkingplaces")]
        public List<ParkingPlace> GetParkingPlaces()
        {
            List<ParkingPlace> ParkingPlaces = new List<ParkingPlace>
            {
            new ParkingPlace { Id = 1, ParkeerPlaats = "A1", Price = 10.00, MaxCarSize = 2, Available = true, Disability = false, Location = "Lot A" },
            new ParkingPlace { Id = 2, ParkeerPlaats = "B1", Price = 8.50, MaxCarSize = 2, Available = true, Disability = true, Location = "Lot B" },
            new ParkingPlace { Id = 3, ParkeerPlaats = "C1", Price = 12.00, MaxCarSize = 3, Available = false, Disability = false, Location = "Lot C" },
            new ParkingPlace { Id = 4, ParkeerPlaats = "D1", Price = 7.50, MaxCarSize = 2, Available = true, Disability = false, Location = "Lot D" }
            };


            return ParkingPlaces;
        }
    }
}
