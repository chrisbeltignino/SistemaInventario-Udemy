using SistemaInventario.DataAcces.Data;
using SistemaInventario.DataAcces.Repository.IRepository;
using SistemaInventario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.DataAcces.Repository
{
    public class BodegaRepository : Repository<Bodega>, IBodegaRepository
    {
        private readonly ApplicationDbContext _db;

        public BodegaRepository(ApplicationDbContext context) : base(context)
        {
            _db = context;
        }

        public void Update(Bodega bodega)
        {
            var bodegaDB = _db.Bodegas.FirstOrDefault(b => b.ID == bodega.ID);
            
            if (bodegaDB != null)
            {
                bodegaDB.Nombre = bodega.Nombre;
                bodegaDB.Descripcion = bodega.Descripcion;
                bodega.Estado = bodegaDB.Estado;
                _db.SaveChanges();
            }
        }
    }
}
