using System;
using System.Threading.Tasks;
using HomeExercise.Models;
using HomeExercise.Services;
using Microsoft.AspNetCore.Mvc;

namespace HomeExercise.Controllers
{
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
