using AutoMapper;
using Net5Superpowers.WebUI.Models;

namespace Net5Superpowers.WebUI
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TodoList, TodoListDto>();
            CreateMap<TodoItem, TodoItemDto>();
        }
    }
}
