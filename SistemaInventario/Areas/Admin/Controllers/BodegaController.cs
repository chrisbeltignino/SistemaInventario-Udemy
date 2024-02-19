using Microsoft.AspNetCore.Mvc;
using SistemaInventario.DataAcces.Repository.IRepository;

namespace SistemaInventario.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BodegaController : Controller
    {
        private readonly IUnitWork _unitWork;

        public BodegaController(IUnitWork unitWork)
        {
            _unitWork = unitWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        #region API

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var all = await _unitWork.Bodega.GetAll();
            return Json(new { data = all });
        }

        #endregion
    }
}
