using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project("Meu projeto ASPNET Core", "Minha Descrição de Projeto", 1, 1, 10000),
                new Project("Meu projeto ASPNET Core", "Minha Descrição de Projeto", 1, 1, 20000),
                new Project("Meu projeto ASPNET Core", "Minha Descrição de Projeto", 1, 1, 30000)
            };

            Users = new List<User>
            {
               new User("Jorge Mateus", "j.mateusnascimento@gmail.com", new DateTime(1994,4,6)),
               new User("Janaina Olivera", "eujanainasilva@outlook.com", new DateTime(1996,12,14)),
               new User("Patricia Alexandra", "alexandrapati@gmail.com", new DateTime(1975,1,15))
            };

            Skills = new List<Skill>
            {
                new Skill(".NET core"),
                new Skill(".C#"),
                new Skill("SQL")
            };
        }

        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }
        public List<ProjectComment> ProjectComments { get; set; }

    }
}
