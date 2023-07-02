using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ZaferTurizm.Business.Services;
using ZaferTurizm.Domain;
using ZaferTurizm.Dtos;

namespace ZaferTurizm.WebApp.Controllers
{
    public class RouteController : Controller
    {
        private readonly IRouteService _routeService;
        public RouteController(IRouteService routeService)
        {
            _routeService = routeService;
        }

        public IActionResult Index()
        {
            var values = _routeService.GetSummaries();
            return View(values);
        }
        public IActionResult Create()
        {
            GetCityViewBag();
            return View();
        }

        private void GetCityViewBag()
        {
            var values = _routeService.GetCityAll();
            ViewBag.CitySelectList = new SelectList(values, "Id", "Name");
        }

        [HttpPost]
        public IActionResult Create(RouteDto routeDto) 
        {

            if (routeDto == null || routeDto.DepartureId == routeDto.ArrivalId)
            {
                GetCityViewBag();
                return View(routeDto);
            }
            else
            {
               var values = _routeService.Create(routeDto);
                if(values != null)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    GetCityViewBag();
                    return View(routeDto);
                }
            }
        }
        public IActionResult Delete(int id)
        {
            if(id == 0)
            {
                return NotFound();
            }
            var result = _routeService.Delete(id);
            if (result.IsSuccess)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        public IActionResult Update(int id)
        {
            var values = _routeService.GetById(id);
            if (values == null)
            {
                return NotFound();
            }

            GetCityViewBag();
            return View(values);

        }
        [HttpPost]
        public IActionResult Update(RouteDto routeDto)
        {
            if (routeDto == null || routeDto.DepartureId == routeDto.ArrivalId)
            {
                GetCityViewBag();
                return View(routeDto);
            }
            else
            {
                var values = _routeService.Create(routeDto);
                if (values != null)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    GetCityViewBag();
                    return View(routeDto);
                }
            }

        }
        //[HttpGet]
        //public IActionResult GetArrivalCitiesByDepartureCityId(int departureCityId)
        //{
        //    var routes = _routeService.GetSummaries();
        //    var departureOfArrival =
        //        routes.Where(model => model.DepartureId == departureCityId);

        //    return Json(departureOfArrival);
        //}
        //[HttpGet]
        //public IActionResult GetDepartureCities()
        //{
        //    var routes = _routeService.GetSummaries();
        //    var newRoutes = routes.GroupBy(r=>r.DepartureId).Where(g=>g.First().DepartureName!=null);

        //    return Json(newRoutes);
        //}
    }
}
