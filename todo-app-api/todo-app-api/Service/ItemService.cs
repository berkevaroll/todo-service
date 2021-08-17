using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using todo_app_api.Dto;
using todo_app_api.Entity;

namespace todo_app_api.Service
{
    public interface IItemService
    {
        GeneralDto.Response Get();
    }
    public class ItemService : IItemService
    {
        todoContext _context;
        public ItemService(todoContext context)
        {
            _context = context;
        }
        public GeneralDto.Response Get()
        {
            return new GeneralDto.Response { Data = "ECE", Message = "Basarili" };
        }
    }
}
