﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.Models;

namespace TaskAPI.Services.Todos
{
    public interface ITodoRepository
    {
        public List<Todo> GetAllTodos(int authorId);

        public Todo GetTodo(int authorId, int id);
    }
}
