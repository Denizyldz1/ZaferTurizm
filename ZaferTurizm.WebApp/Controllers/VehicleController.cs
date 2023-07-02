using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ZaferTurizm.Business.Services;
using ZaferTurizm.Domain;
using ZaferTurizm.Dtos;

namespace ZaferTurizm.WebApp.Controllers
{
    public class VehicleController : Controller
    {
        private readonly IVehicleService _vehicleService;
        private readonly IVehicleDefinitionService _vehicleDefinitionService;
        private readonly IVehicleMakeService _vehicleMakeService;
        private readonly IVehicleModelService _vehicleModelService;

        public VehicleController(IVehicleService vehicleService,
                                 IVehicleDefinitionService vehicleDefinitionService,
                                 IVehicleMakeService vehicleMakeService,
                                 IVehicleModelService vehicleModelService)
        {
            _vehicleService = vehicleService;
            _vehicleDefinitionService = vehicleDefinitionService;
            _vehicleMakeService = vehicleMakeService;
            _vehicleModelService = vehicleModelService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var values = _vehicleService.GetSummaries();
            return View(values);
        }
        public IActionResult Create()
        {
            GetAllVehicleViewBag();
            return View();
        }

        private void GetAllVehicleViewBag()
        {
            var vehicleMakes = _vehicleMakeService.GetAll();
            ViewBag.VehicleMakeSelectList = new SelectList(vehicleMakes, "Id", "Name");

            var vehicleModels = _vehicleModelService.GetAll();
            ViewBag.VehicleModelSelectList = new SelectList(vehicleModels, "Id", "Name");

            var vehicleDefinition = _vehicleDefinitionService.GetSummaries();
            ViewBag.VehicleDefinitionSelectList = new SelectList(vehicleDefinition, "Id", "Description");
        }
        [HttpPost]
        public IActionResult Create(VehicleDto vehicleDto)
        {
            if (vehicleDto == null)
            {
                GetAllVehicleViewBag();
                return View(vehicleDto);
            }
            var result = _vehicleService.Create(vehicleDto);
            if(result.IsSuccess)
            {
                return RedirectToAction("Index");
            }
            else
            {
                GetAllVehicleViewBag();
                return View(vehicleDto);
            }
        }
    }
}
