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
        GeneralDto.Response AddItem(ItemDto.Add item);
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
        public GeneralDto.Response AddItem(ItemDto.Add item)
        {
            try
            {
                var _item = new Item { Title = item.Title, Description = item.Description, CreatedDate = item.CreatedDate };
                _context.Item.Add(_item);
                _context.SaveChanges();
                return new GeneralDto.Response { Message = "Basarili" };
            }
            catch (Exception)
            {
                return new GeneralDto.Response { Error = true, Message = "Basarili" };
            }
        }
    }
}
