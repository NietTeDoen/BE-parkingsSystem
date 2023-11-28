using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.models;
using static ParkingSystemBE.Controllers.ParkingController;

namespace ParkingSystemBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParkingController : ControllerBase
    {

        public class ParkingInfo
        {
            public User User { get; set; }
            public ParkingPlace ParkingPlace { get; set; }
        }

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
        [HttpGet]
        [Route("get/Users")]
        public List<User> GetUsers()
        {
            List<User> Users = new List<User>
            {
            new User { UserId = 1, UserName = "bert", NummerBord = "NK23EWBF", ParkingPlace = null}
            };


            return Users;
        }
        [HttpPost]
        [Route("get/ReserveerParkeerplaats")]
        public bool ReserveerParkeerplaats(ParkingInfo parkingInfo)
        {
            if (parkingInfo.User == null || parkingInfo.ParkingPlace == null)
                return false;
            /*
             * here needs to go a database connection checking if the parkingplace is free
             * if the parking place is free push the changes and set the parkingplace on reserved
             */
            return true;
        }
        [HttpPost]
        [Route("get/CancelParkeerplaats")]
        public bool CancelParkeerplaats(ParkingInfo parkingInfo)
        {
            if (parkingInfo.User == null || parkingInfo.ParkingPlace == null)
                return false;
            /*
             * here needs to go a database connection checking if the parkingplace is reserved
             * if the parking place is reserved push the changes and set the parkingplace on free
             */
            return true;
        }
        [HttpPost]
        [Route("get/ChangeTime")]
        public bool ChangeTimeParkingplace(ParkingInfo parkingInfo)
        {
            if (parkingInfo.User == null || parkingInfo.ParkingPlace == null)
                return false;
            /*
             * here needs to go a database connection checking if the parkingplace is reserved
             * if the parking place is reserved push the changes and set the time of the parking place.
             */
            return true;
        }
        [HttpPost]
        [Route("get/checkout")]
        public bool Checkout(ParkingInfo parkingInfo)
        {
            if (parkingInfo.User == null || parkingInfo.ParkingPlace == null)
                return false;
            /*
             * here needs to go a database connection checking if the parkingplace was reserved.
             * if it was reserved and the person putted checkout then push the changes and calculate
             * the checkout fee.
             */
            return true;
        }
    }
}
