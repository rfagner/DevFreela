using DevFreela.Core.Entities;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project("Meu projeto ASPNET Core", "Minha descrição do projeto", 1, 1, 10000),
                new Project("Meu projeto de IA", "Minha descrição do projeto", 1, 1, 15000),
                new Project("Meu projeto SQL Server", "Minha descrição do projeto", 1, 1, 20000)
            };
        }
        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }
    }
}
