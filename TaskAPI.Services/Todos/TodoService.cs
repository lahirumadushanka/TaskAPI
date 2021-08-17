﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskAPI.Models;

namespace TaskAPI.Services.Todos
{
    public class TodoService:ITodoRepository
    {
        public List<Todo> GetAllTodos(int authorId)
        {
            var todos = new List<Todo>();

            var todo1 = new Todo
            {
                Id = 1,
                Title = "Get books for School",
                Description = "Get some text books for school",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New
            };

            todos.Add(todo1);

            var todo2 = new Todo
            {
                Id = 2,
                Title = "Get vegetable",
                Description = "Get vegetable for week",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(2),
                Status = TodoStatus.New
            };

            todos.Add(todo2);

            var todo3 = new Todo
            {
                Id = 3,
                Title = "Water the plants",
                Description = "Water all the plants quickly",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(1),
                Status = TodoStatus.New
            };

            todos.Add(todo3);

            return todos;
        }       

        public Todo GetTodo(int authorId, int id)
        {
            throw new NotImplementedException();
        }
    }
}
