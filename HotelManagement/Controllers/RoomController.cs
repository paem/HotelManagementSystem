
using System.Web.Mvc;
using HotelManagement.ViewModels;
using HMS.Data.Repositories;
using HMS.Models;
using HotelManagement.RoomServiceReference;

namespace HotelManagement.Controllers
{
    public class RoomController : Controller
    {
      

        private readonly HMSServiceClient _roomWCFClient = new HMSServiceClient();


        public ActionResult Index()
        {
            var rooms = _roomWCFClient.GetRooms();
            var viewModel = new RoomViewModel
            {
                Rooms = rooms
            };

            return View(viewModel);    
        }


       /*
        [HttpPost]
        public ActionResult CreateRoom(RoomViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                viewModel.RoomId = 1; // HARD CODED 
                viewModel.RoomDoorNumber = 45; // HARD CODED
                viewModel.RoomCount = 5;
                viewModel.RoomStatus = false;

                var roomObject = new Room
                {
                    RoomId = viewModel.RoomId,
                    
                };
                _roomWCFClient.CreateRoom(roomObject);

    
                return RedirectToAction("Index", "EventList");
            }


            
            //viewModel.EventTypes = eventsTypes;


            return View("Index", viewModel);
        }


    */

    }
}
