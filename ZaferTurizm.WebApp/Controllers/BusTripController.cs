using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using ZaferTurizm.Business.Services;
using ZaferTurizm.Dtos;

namespace ZaferTurizm.WebApp.Controllers
{
    public class BusTripController : Controller
    {
        private readonly IBusTripService _busTripService;
        private readonly IRouteService _routeService;
        private readonly IVehicleService _vehicleService;

        // Mediatr
        // CQRS
        public BusTripController(
            IBusTripService busTripService,
            IRouteService routeService,
            IVehicleService vehicleService)
        {
            _busTripService = busTripService;
            _routeService = routeService;
            _vehicleService = vehicleService;
        }

        public IActionResult Index()
        {
            if (TempData["SuccessMessage"] != null)
            {
                ViewBag.SuccessMessage = TempData["SuccessMessage"];
            }

            var busTripSummaries = _busTripService.GetSummaries();
            var newSummaries = new List<BusTripInfo>();
            foreach(var item in busTripSummaries) 
            {
                if (item.Date > DateTime.Now)
                {
                    newSummaries.Add(item);
                }
            
            }

            return View(newSummaries);
        }

        public IActionResult Create()
        {
            FillRouteAndVehicleValues();

            // Mediator olaydı böyle yazacaktık
            //var getAllRoutesQuery = new GetAllRoutesQuery();
            //var allRoutes = _mediator.Send(getAllRoutesQuery);

            //var query = new GetBusTripsByRouteQuery()
            //{
            //    RouteId = 10
            //};

            return View();
        }

        private void FillRouteAndVehicleValues()
        {
            var routeSummaries = _routeService.GetSummaries();
            var vehicleSummaries = _vehicleService.GetSummaries();

            ViewBag.RouteSelectList = new SelectList(routeSummaries, "Id", "RouteName");
            ViewBag.VehicleSelectList = new SelectList(vehicleSummaries, "Id", "Description");
        }

        [HttpPost]
        public IActionResult Create(BusTripDto dto)
        {
            var result = _busTripService.Create(dto);

            if (result.IsSuccess)
            {
                //ViewBag.SuccessMessage = result.Message;
                TempData["SuccessMessage"] = result.Message;

                return RedirectToAction(nameof(Index));
            }
            else
            {
                FillRouteAndVehicleValues();

                ViewBag.ErrorMessage = result.Message.Replace("\n", "<br>");

                return View(dto);
            }
        }
        public IActionResult Delete(int id)
        {
            var result = _busTripService.Delete(id);
            if (result.IsSuccess)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return NotFound();
            }
        }
        public IActionResult Update(int id)
        {
            var value = _busTripService.GetById(id);
            if(value == null)
            {
                return NotFound();
            }
            value.Price = decimal.Parse(value.Price.ToString("N2"));
            FillRouteAndVehicleValues();
            return View(value);
        }
        [HttpPost]
        public IActionResult Update(BusTripDto dto)
        {
            if(dto == null)
            {
                FillRouteAndVehicleValues();
                return View(dto);
            }
            var result = _busTripService.Update(dto);
            if (result.IsSuccess)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                FillRouteAndVehicleValues();
                return View(dto);
            }
        }
        [HttpGet]
        public IActionResult BusTripSearch()
        {
            var value = _routeService.GetSummaries().GroupBy(r => r.DepartureId).Select(g => g.FirstOrDefault());
            ViewBag.DepartureCities = new SelectList(value, "DepartureId", "DepartureName");

            return View();

            //if (TempData["BusTripList"] != null)
            //{
            //    var serializedBusTripList = TempData["BusTripList"] as string;
            //    var deserializedBusTripList = JsonConvert.DeserializeObject<List<BusTripInfo>>(serializedBusTripList);
            //    ViewData["BusTripList"] = deserializedBusTripList;
            //    return View(deserializedBusTripList);
            //}

            //else
            //{
                
            //}


        }
        public IActionResult GetArrivalsByDepartureId(int departureId)
        {
            var allArrivalCities = _routeService.GetSummaries();
            var value =
                allArrivalCities.Where(model => model.DepartureId == departureId);



            return Json(value);
        }
        public IActionResult BusTripResult(BusTripInfo dto)
        {
            var busTripId = _routeService.GetSummaries()
                .Where(p => p.DepartureId == dto.DepartureId && p.ArrivalId == dto.ArrivalId)
                .Select(g=>g.Id)
                .ToList();

            var result = _busTripService.GetSummaries()
                .Where(b => busTripId.Contains(b.RouteId))
                .ToList();
            if(result.Count == 0)
            {
                return View();
            }

            return View(result);
        }
    }
}
