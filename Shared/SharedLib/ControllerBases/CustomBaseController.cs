using Microsoft.AspNetCore.Mvc;
using SharedLib.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharedLib.ControllerBases
{
    public class CustomBaseController : ControllerBase
    {
        public IActionResult CreateActionResultInstance<T>(Response<T> response)
        {
            return new ObjectResult(response)
            {
                StatusCode = response.StatusCode
            };
        }
    }
}
