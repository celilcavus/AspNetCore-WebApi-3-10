using CelilCavus.OgrenciKayitSistemi.Entites;
using Microsoft.EntityFrameworkCore;

namespace CelilCavus.OgrenciKayitSistemi.Service
{
    public class DersService : BaseRepository<Dersler>
    {
        public DersService(DbContext dbcontext) : base(dbcontext)
        {
        }
    }
}