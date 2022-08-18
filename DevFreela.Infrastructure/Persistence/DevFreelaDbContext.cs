using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;


namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project("Meu projeto ASP.NET Core 1", "Minha descrição de projeto 1", 1, 1, 10000),
                new Project("Meu projeto ASP.NET Core 2", "Minha descrição de projeto 2", 1, 1, 20000),
                new Project("Meu projeto ASP.NET Core 3", "Minha descrição de projeto 3", 1, 1, 30000),
            };

            Users = new List<User>
            {
                new User("Fagner Santos", "fagnersantos@atlantis.io", new DateTime(1990, 12, 14)),
                new User("Rodrigo Kono", "rodrigokono@dotkon.com", new DateTime(1985, 10, 02)),
                new User("André Baltieri", "andrebaltieri@balta.io", new DateTime(1987, 06, 05)),
            };

            Skills = new List<Skill>
            {
                new Skill(".NET Core"),
                new Skill("Cloud"),
                new Skill("Angular"),
            };
        }
        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }
        public List<ProjectComment> ProjectComments { get; set; }
    }
}
