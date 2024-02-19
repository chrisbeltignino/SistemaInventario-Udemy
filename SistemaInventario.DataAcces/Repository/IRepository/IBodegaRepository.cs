using SistemaInventario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.DataAcces.Repository.IRepository
{
    public interface IBodegaRepository : IRepository<Bodega>
    {
        void Update(Bodega bodega);
    }
}
