using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/VillaAPI")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<VillaDTO>> GetVillas()
        {
            return Ok(VillaStore.villaList);
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]

        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //[ProducesResponseType(StatusCodes.Status500InternalServerError)]

        //[ProducesResponseType(200, Type = typeof(VillaDTO))]
        //[ProducesResponseType(404)]
        //[ProducesResponseType(500)]
        public ActionResult<VillaDTO> GetVilla(int id)
        {
            if (id <= 0) return BadRequest();

            var villa = VillaStore.villaList.FirstOrDefault(Villa => Villa.Id == id);

            if(villa == null) return NotFound();

            return Ok(villa);
        }
    }
}
