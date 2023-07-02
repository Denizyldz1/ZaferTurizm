using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ZaferTurizm.Business.Services;
using ZaferTurizm.Dtos;

namespace ZaferTurizm.WebApp.Controllers
{
    public class VehicleDefinitionController : Controller
    {
        private readonly IVehicleDefinitionService _vehicleDefinitionService;
        private readonly IVehicleMakeService _vehicleMakeService;
        private readonly IVehicleModelService _vehicleModelService;

        public VehicleDefinitionController(
            IVehicleDefinitionService vehicleDefinitionService,
            IVehicleMakeService vehicleMakeService,
            IVehicleModelService vehicleModelService)
        {
            _vehicleDefinitionService = vehicleDefinitionService;
            _vehicleMakeService = vehicleMakeService;
            _vehicleModelService = vehicleModelService;
        }

        public IActionResult Index()
        {
            var summaries = _vehicleDefinitionService.GetSummaries();

            return View(summaries);
        }

        public IActionResult Create()
        {
            GetVehicleMakeAll();

            return View();
        }

        private void GetVehicleMakeAll()
        {
            var vehicleMakes = _vehicleMakeService.GetAll();
            ViewBag.VehicleMakeSelectList = new SelectList(vehicleMakes, "Id", "Name");
        }

        [HttpPost]
        public IActionResult Create(VehicleDefinitionDto vehicleDefinitionDto) 
        { 
            if (vehicleDefinitionDto == null)
            {
                GetVehicleMakeAll();
                return View(vehicleDefinitionDto);
            }
            else
            {
                var result = _vehicleDefinitionService.Create(vehicleDefinitionDto);
                if(result.IsSuccess)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    GetVehicleMakeAll();
                    return View(vehicleDefinitionDto);
                }
            }
        }

        public IActionResult Update(int id)
        {
            var vehicleDefinition = _vehicleDefinitionService.GetById(id);

            if (vehicleDefinition == null)
            {
                return NotFound();
            }

            GetVehicleMakeAll();

            GetVehicleModelsOfMake(vehicleDefinition);

            //var allVehicleModels = _vehicleModelService.GetAll();
            //ViewBag.VehicleModelsSelectList = new SelectList(allVehicleModels, "Id", "Name");

            return View(vehicleDefinition);
        }

        private void GetVehicleModelsOfMake(VehicleDefinitionDto? vehicleDefinition)
        {
            var vehicleModelsOfMake = _vehicleModelService.GetByMakeId(vehicleDefinition.VehicleMakeId);
            ViewBag.VehicleModelSelectList =
                new SelectList(vehicleModelsOfMake, "Id", "Name");
        }

        [HttpPost]
        public IActionResult Update(VehicleDefinitionDto vehicleDefinitionDto)
        {
            if (vehicleDefinitionDto == null)
            {
                var vehicleDefinition = _vehicleDefinitionService.GetById(vehicleDefinitionDto.Id);
                if (vehicleDefinition == null)
                {
                    return NotFound();
                }

                GetVehicleMakeAll();
                GetVehicleModelsOfMake(vehicleDefinition);
                return View(vehicleDefinition);
            }
            else
            {
                var result = _vehicleDefinitionService.Update(vehicleDefinitionDto);
                if (result != null)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    var vehicleDefinition = _vehicleDefinitionService.GetById(vehicleDefinitionDto.Id);
                    if (vehicleDefinition == null)
                    {
                        return NotFound();
                    }

                    GetVehicleMakeAll();
                    GetVehicleModelsOfMake(vehicleDefinition);
                    return View(vehicleDefinitionDto);
                }
            }
        }
        public IActionResult Delete(int id)
        {
            var result = _vehicleDefinitionService.Delete(id);
            if (result.IsSuccess)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return NotFound();
            }
        }
    }
}
