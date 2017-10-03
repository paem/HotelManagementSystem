
using System.Web.Mvc;
using HotelManagement.ViewModels;
using HMS.Data.Repositories;
using HMS.Models;
using HotelManagementService;

namespace HotelManagement.Controllers
{
    public class RoomController : Controller
    {

        private readonly HMSService _roomWCFClient = new HMSService();


        public ActionResult Index()
        {
            var rooms = _roomWCFClient.GetRooms();
            var categoryTypes = _roomWCFClient.GetRoomCategoryTypes();
            var capacity = _roomWCFClient.GetRoomCapacity();
            var viewModel = new RoomViewModel
            {
                Rooms = rooms,
                CategoryTypes = categoryTypes,
                RoomCapacity = capacity,
                

        
                
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
