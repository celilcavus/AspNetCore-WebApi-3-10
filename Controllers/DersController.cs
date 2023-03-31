using CelilCavus.OgrenciKayitSistemi.Entites;
using CelilCavus.OgrenciKayitSistemi.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CelilCavus.OgrenciKayitSistemi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DersController : ControllerBase
    {
        private readonly IRepository<Dersler> _ders;

        public DersController(IRepository<Dersler> ders)
        {
            this._ders = ders;
        }
        [HttpGet]
        public IActionResult GetList()
        {
            var List = _ders.GetAll();
            if (!string.IsNullOrEmpty(List.ToString()))
            {
                return Ok(List);
            }
            else return NotFound();
        }

        [HttpGet("{id}")]
        public IActionResult GetList(int id)
        {
            if (id >= 0)
            {
                var List = _ders.GetById(id);
                if (!string.IsNullOrEmpty(List.ToString()))
                {
                    return Ok(List);
                }
                else return NotFound();
            }
            else return NotFound();

        }


        [HttpPost]
        public IActionResult PostDers(Dersler dersler)
        {
            if (!string.IsNullOrEmpty(dersler.ToString()))
            {
                _ders.Add(dersler);
                return NoContent();
            }
            else return NotFound();
        }

        [HttpPut]
        public IActionResult PutDers(Dersler dersler)
        {
            if (!string.IsNullOrEmpty(dersler.ToString()))
            {
                _ders.Update(dersler);
                return NoContent();
            }
            else return NotFound();
        }

        public IActionResult DeleteDers(Dersler dersler)
        {
            if (!string.IsNullOrEmpty(dersler.ToString()))
            {
                _ders.Delete(dersler);
                return NoContent();
            }
            else return NotFound();
        }
    }
}