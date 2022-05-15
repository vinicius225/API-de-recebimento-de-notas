using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DEVTRACK.API.Models;
using Entities.Api;
using DEVTRACK.API.Persistence;



namespace DEVTRACK.API
{
    [Route("api/package")]
    public class PackageController : ControllerBase
    {
        private readonly DevTrackContext _context;
        public PackageController(DevTrackContext context)
        {
            _context = context;
        }
        //Get api/packages
        [HttpGet]
        public IActionResult GetAll()
        {
           // var package = _context.Packages;
            return Ok();
        }

        // Get api/package/jbujbunhulk
        [HttpGet("{code}")]
        public IActionResult GetByCode(string code)
        {
        //    ;; var package = _context.Packages.SingleOrDefault(a => a.Code == code);
        //     if (package != null)
        //     {
        //         return Ok(package);
        //     }
        //     else
        //     {
        //         return NotFound();
        //     }
        return Ok();
        }
        [HttpPost]
        public IActionResult Post(AddPackageInputModels model)
        {

            var package = new Package(model.Title, model.Weight);
           // _context.Packages.Add(package);
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


            return Ok(package);
        }
    }
}


