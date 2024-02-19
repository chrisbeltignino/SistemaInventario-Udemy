using SistemaInventario.DataAcces.Data;
using SistemaInventario.DataAcces.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.DataAcces.Repository
{
    public class UnitWork : IUnitWork
    {
        private readonly ApplicationDbContext _db;

        public IBodegaRepository Bodega {  get; private set; }

        public UnitWork(ApplicationDbContext db)
        {
            _db = db;
            Bodega = new BodegaRepository(_db);
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public async Task Save()
        {
            await _db.SaveChangesAsync();
        }
    }
}
