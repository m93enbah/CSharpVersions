using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp9API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FruitsController : ControllerBase
    {
        [HttpGet]
        public ActionResult CheckUser()
        {
            var ps1 = new Person("Ali Ahmad", 12);
            var ps2 = new Person("Ali Isam", 12);

            var ps3 = ps1 with { fullName = "Ali Ahmad" };
            var isEqual01 = ps1 == ps3;


            var isEqual = ps1.Equals(ps2);
            var details = ps1.GetDetails();

            var dev1 = new Developer("Ali Ahmad", 12, 1200);
            var isEqual02 = ps1 == dev1;


            var shape = new Shape("Shape01");

            var rect = new Rectangle("Shape01");

            var shapeEqual = shape == rect;



            return Ok(new { Result = isEqual, Details = details, IsEqual01 = isEqual01, IsEqualType02 = isEqual02, ps1Result = ps1.ToString(), ps2Result = ps2.ToString(), shapeEqual = shapeEqual });
        }
    }


    public class Fruits 
    {
        public string Color { get; set;  }

        public bool HasSeeds { get; set; }

        public bool IsEatable { get; set;    }

        public void Deconstruct(out string color, out bool hasSeeds, out bool isEatable)
        {
            color = Color;
            hasSeeds = HasSeeds;
            isEatable = IsEatable;
        }
    }
}
