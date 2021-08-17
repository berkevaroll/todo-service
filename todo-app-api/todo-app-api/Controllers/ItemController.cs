using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using todo_app_api.Entity;
using todo_app_api.Service;

namespace todo_app_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        IItemService _itemService;
        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_itemService.Get());
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
