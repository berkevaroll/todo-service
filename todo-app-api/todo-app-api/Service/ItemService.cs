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
        GeneralDto.Response Add(ItemDto.Add item);
        GeneralDto.Response Update(ItemDto.Update item);
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
        public GeneralDto.Response Add(ItemDto.Add itemModel)
        {
            try
            {
                var item = new Item { Title = itemModel.Title, Description = itemModel.Description, CreatedDate = itemModel.CreatedDate };
                _context.Item.Add(item);
                _context.SaveChanges();
                return new GeneralDto.Response { Message = "Basarili" };
            }
            catch (Exception)
            {
                return new GeneralDto.Response { Error = true, Message = "Basarisiz" };
            }
        }

        public GeneralDto.Response Update(ItemDto.Update itemModel)
        {
            try
            {
                Item result = _context.Item.Where(item => item.Id == itemModel.Id).FirstOrDefault();
                if (result != null)
                {
                    result.Title = itemModel.Title;
                    result.Description = itemModel.Description;
                    result.CreatedDate = itemModel.CreatedDate;
                    _context.SaveChanges();
                }
                return new GeneralDto.Response { Message = "Basarili" };
            }
            catch (Exception)
            {
                return new GeneralDto.Response { Error = true, Message = "Basarisiz" };
            }
        }
    }
}
