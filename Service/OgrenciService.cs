using CelilCavus.OgrenciKayitSistemi.Entites;
using Microsoft.EntityFrameworkCore;

namespace CelilCavus.OgrenciKayitSistemi.Service
{
    public class OgrenciService : BaseRepository<Ogrenci>
    {
        public OgrenciService(DbContext dbcontext) : base(dbcontext)
        {
        }
    }
}