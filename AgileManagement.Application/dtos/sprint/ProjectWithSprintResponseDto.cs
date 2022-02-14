using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileManagement.Application
{
    public class SprintDto
    {
        public DateTime StardDate { get; set; }
        public DateTime EndDate { get; set; }
        public string SprintName { get; set; }

    }
    public class ProjectSprintDto
    {
        public string ProjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<SprintDto> Sprints { get; set; } = new List<SprintDto>();
    }
    public class ProjectWithSprintResponseDto
    {
        public List<ProjectSprintDto> Projects = new List<ProjectSprintDto>();
    }
}
