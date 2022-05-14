using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using  DEVTRACK.API.Models;
using Entities.Api;




namespace DEVTRACK.API
{
    [Route("api/package")]
    public class PackageController : ControllerBase
    {
        //Get api/packages
        [HttpGet]
        public  IActionResult GetAll()
        {
            var package = new List<Package> () {
                new Package("Tirtulo 01", 1.32),
                new Package("Tirtulo 02", 1.62),
                new Package("Tirtulo 03", 1.22),
                new Package("Tirtulo 04", 1.52)
            };

            return Ok(package);
        }
           

        // Get api/package/jbujbunhulk
        [HttpGet("{code}")]
        public IActionResult GetByCode(string code)
        {
            var package = new Package("PAcote 2", 0.34);
            return Ok(package);
        }
        [HttpPost]
        public IActionResult Post(AddPackageInputModels model)        
        {
            var package = new Package(model.Title, model.Weight);
            return Ok();
        }
        // //PUT/API/PACKAGE
        // public IActionResult Put(String code)
        // {
        //     return Ok ();
        // }

        [HttpPost("{code}")]
        public IActionResult PostUpdate(string code, AddPackageInputModels model)
        {
            var package = new Package("Pacote 01", 1.25);


            return Ok ();
        }
    }
}