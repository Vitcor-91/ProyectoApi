using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProyectoApi.Application.DTOs.User;
using Prueba.Application.Queries.Users;

namespace ProyectoApi.Api.Controllers
{
    [Route("api/[controller]")]
    public class usersController : ControllerBase
    {

        private readonly GetConnectionHandler _handler;

        public usersController(
            GetConnectionHandler getConnectionHandler
        )
        {
            _handler = getConnectionHandler;
        }

        [HttpPost(Name = "TestConection")]
        //[Authorize(Roles = "Cliente")]
        public async Task<IActionResult> TestConection(CancellationToken cancellationToken)
        {
            var result = await _handler.Handle(
                cancellationToken 
            );
            
            if(!result.success)
            {
                return Unauthorized(result);
            }

            return Ok(result);
        }

    }
}