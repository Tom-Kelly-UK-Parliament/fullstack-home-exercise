using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using UKParliament.CodeTest.Services;

namespace UKParliament.CodeTest.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DivisionsController : Controller
    {
        private readonly IDivisionInfoService _divisionInfoService;

        public DivisionsController(IDivisionInfoService divisionInfoService)
        {
            _divisionInfoService = divisionInfoService;
        }

        [HttpGet("[action]")]
        public Task<DivisionInformation> DivisionPage(int skip, int take)
        {
            var model = _divisionInfoService.GetDivisionPage(skip, take);
            throw new NotImplementedException();
        }
    }
}
