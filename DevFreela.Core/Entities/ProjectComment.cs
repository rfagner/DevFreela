﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Core.Entities
{
    public class ProjectComment:BaseEntity
    {
        public ProjectComment(string content, int idProject, int idUser)
        {
            Content = content;
            IdProject = idProject;
            IdUser = idUser;
            CreatedAt = DateTime.Now;
        }

        public string Content { get; private set; }
        public int IdProject { get; private set; }
        public Project Project{ get; private set; }
        public int IdUser { get; private set; }
        public User User { get; set; }
        public DateTime CreatedAt { get; private set; }
    }
}
