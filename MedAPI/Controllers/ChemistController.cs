using MedEntity.ContextModel;
using MedInterface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChemistController : ControllerBase
    {
        private readonly IMed _medicineservice = null;
        public ChemistController(IMed _med)
        {
            _medicineservice = _med;
        }
        [HttpPost("AddMedicine")]
        public IActionResult AddMedicine(Medicine data)
        {
            string issuccess = _medicineservice.AddMedicine(data);
            if (issuccess == "OK")
            {
                return Ok("Medicine Added Successfully");
            }
            else
            {
                return BadRequest(issuccess);
            }
        }

        [HttpGet("GetMedicine/{MedId}")]
        public Medicine GetMedicineDetail(int MedId)
        {
            return _medicineservice.GetMedicineDetails(MedId);
        }
        [HttpGet("ShowAllMedicine")]
        public IActionResult ShowAllMedicine()
        {
            return _medicineservice.ShowMedicineList();
        }

    }
}
