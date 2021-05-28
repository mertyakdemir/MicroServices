using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.FakePayment.Models;
using SharedLib.ControllerBases;
using SharedLib.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.FakePayment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FakePaymentsController : CustomBaseController
    {
        [HttpPost]
        public IActionResult ReceivePayment(PaymentDto paymentDto)
        {
           return CreateActionResultInstance(Response<NoContent>.Success(200));
        }
    }
}
