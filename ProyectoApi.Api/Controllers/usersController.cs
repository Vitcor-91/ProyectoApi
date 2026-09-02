using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProyectoApi.Application.DTOs.User;

namespace ProyectoApi.Api.Controllers
{
    [Route("api/[controller]")]
    public class usersController : ControllerBase
    {

        [HttpPost(Name = "TestConection")]
        //[Authorize(Roles = "Cliente")]
        public IEnumerable<TestConection> TestConection()
        {
            var result = new List<TestConection>
            {
                new TestConection { success = true, message = "Conexión exitosa" }
            };

            return result;
        }

    }
}