using DevFreela.Core.Entities;
using DevFreela.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DevFreela.UnitTests.Core.Entities
{
    public class ProjectTests
    {
        [Fact]
        public void TestIfProjectStartWorks()
        {
            var project = new Project("Nome do teste", "Descrição do teste", 1, 2, 10000);
            
            // Validando a inicialização do Objeto e se a Data de criação seja nula
            Assert.Equal(ProjectStatusEnum.Created, project.Status);
            Assert.Null(project.StartedAt);

            // Validando se o Título não seja nulo e nem vazio
            Assert.NotNull(project.Title);
            Assert.NotEmpty(project.Title);

            // Validando se o campo Descrição não seja nulo e nem vazio
            Assert.NotNull(project.Description);
            Assert.NotEmpty(project.Description);

            project.Start();

            // Validando se o Start do projeto está ok
            Assert.Equal(ProjectStatusEnum.InProgress, project.Status);
            Assert.NotNull(project.StartedAt);

            
        }
    }
}
