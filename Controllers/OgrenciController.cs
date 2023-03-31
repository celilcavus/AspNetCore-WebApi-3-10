using CelilCavus.OgrenciKayitSistemi.Entites;
using CelilCavus.OgrenciKayitSistemi.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CelilCavus.OgrenciKayitSistemi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OgrenciController : ControllerBase
    {
        private readonly IRepository<Ogrenci> _ogrenci;

        public OgrenciController(IRepository<Ogrenci> ogrenci)
        {
            _ogrenci = ogrenci;
        }

        [HttpGet]
        public IActionResult GetList()
        {
            var ListNullOrEmpty = _ogrenci.GetAll();
            if (!string.IsNullOrEmpty(ListNullOrEmpty.ToString()))
            {
                return Ok(ListNullOrEmpty);
            }
            else return NotFound();
        }
        [HttpGet("{id}")]
        public IActionResult GetList(int id)
        {
            if (!string.IsNullOrEmpty(id.ToString()))
            {
                var ListNullOrEmpty = _ogrenci.GetById(id);
                if (!string.IsNullOrEmpty(ListNullOrEmpty.ToString()))
                {
                    return Ok(ListNullOrEmpty);
                }
                else return NotFound();
            }
            else return NotFound();
        }
        [HttpPost]
        public IActionResult PostOgrenci(Ogrenci ogrenci)
        {
            if (!string.IsNullOrEmpty(ogrenci.ToString()))
            {
                _ogrenci.Add(ogrenci);
                return NoContent();
            }
            else return NotFound();
        }
        [HttpPut]
        public IActionResult PutOgrenci(Ogrenci ogrenci)
        {
            if (!string.IsNullOrEmpty(ogrenci.ToString()))
            {
                
                _ogrenci.Update(ogrenci);
                return NoContent();
            }
            else return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteOgrenci(int id)
        {
            if (!string.IsNullOrEmpty(id.ToString()))
            {
                _ogrenci.Delete(new (){id = id});
                return NoContent();
            }
            else return NotFound();
        }

    }
}