﻿using PyTaskBot.Infrastructure;

namespace PyTaskBot.App.Commands
{
    public class ListTaskInCategoryCommand : Command
    {
        private readonly PyTaskDatabase db;

        public ListTaskInCategoryCommand(PyTaskDatabase db) : base("catinfo", "show list of tasks in category")
        {
            this.db = db;
            foreach (var x in db.CategoriesSet)
            {
                Aliases.Add(x);
            }
        }

        public override string CreateResponse(params object[] args)
        {
            var query = args[0] as string;

            var tasks = db.GetNamesOfTasksInCategory(query);
            return $"Категория: {query}\n\n" +
                   $"Таски:\n" +
                   string.Join("\n", tasks);
        }
    }
}