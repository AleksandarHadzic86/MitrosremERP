using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MitrosremERP.Aplication.IRepositories;
using MitrosremERP.Aplication.ViewModels.ZaposleniMitroSremVM;

namespace MitrosremERP.Controllers
{
    public class GodisnjiController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _autoMapper;
        private readonly ILogger _logger;
        public GodisnjiController(IUnitOfWork unitOfWork, IMapper autoMapper, ILogger<GodisnjiController> logger)
        {
            _unitOfWork = unitOfWork;
            _autoMapper = autoMapper;
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Create(Guid? id)
        {
            try
            {
                var zaposleni = await _unitOfWork.ZaposleniRepository.GetByIdAsync(id);

                if (zaposleni == null)
                {
                    Response.StatusCode = 404;
                    return View("../Zaposleni/ZaposleniNijePronadjen");
                }
                else
                {
                    ViewBag.Id = zaposleni.Id;
                    var godisnjiZaposleniId = _unitOfWork.GodisnjiRepository.GetQueryable(godisnji => godisnji.ZaposleniId == zaposleni.Id).ToList();

                    KreirajGodisnjiVM bolovanjeVM = new KreirajGodisnjiVM();

                    bolovanjeVM.GodisnjiVM = new GodisnjiVM();
                    bolovanjeVM.GodisnjiVMlista = _autoMapper.Map<List<GodisnjiVM>>(godisnjiZaposleniId);
                    bolovanjeVM.ZaposleniVM = _autoMapper.Map<ZaposleniVM>(zaposleni);

                    return View(bolovanjeVM);
                }
            }
            catch (Exception ex)
            {

                Response.StatusCode = 500;
                _logger.LogError(ex, "Doslo je do prekida u konekciji sa bazom");
                return View("InternalServerError");
            }
        }
    }
}
