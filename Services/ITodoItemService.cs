using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCoreTodo.Models;

namespace AspNetCoreTodo.Services
{
    public interface ITodoItemService
    {
        Task<IEnumerable<TodoItem>> GetIncompleteItemsAsync();

        Task<bool> MarkDoneAsync(Guid id);
        
        Task<bool> AddItemAsync(NewTodoItem newItem);
    }
}