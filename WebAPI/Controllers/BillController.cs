using ERP.Domain.Entity;
using ERP.Domain.UnitOfWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ERP.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillController : ControllerBase
    {
        private readonly IErpUnitOfWork _erpUnitOfWork;

        public BillController(IErpUnitOfWork erpUnitOfWork)
        {
            _erpUnitOfWork = erpUnitOfWork;
        }

        [HttpGet]
        [Authorize]
        public IActionResult GetAll()
        {
            //var bills = _erpUnitOfWork.Repository<Bill>().GetList().Take(1);
            return Ok("Hi there");
        }

        [HttpGet("{id:int}", Name = "GetById")]
        [AllowAnonymous]
        public IActionResult Test2(int id)
        {
            return Ok($"Your id is {id}");
        }
    }
}
