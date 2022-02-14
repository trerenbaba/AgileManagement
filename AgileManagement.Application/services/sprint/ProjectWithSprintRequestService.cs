using AgileManagement.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileManagement.Application
{
    public class ProjectWithSprintRequestService : IProjectWithSprintRequestService
    {
        private readonly IProjectRepository _projectRepository;

        public ProjectWithSprintRequestService(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }
        
        public ProjectWithSprintResponseDto OnProcess(string projectId)
        {
            var project = _projectRepository.GetQuery().Include(x => x.Sprints).Where(x => x.Id == projectId).Select(a => new ProjectSprintDto
            {
                ProjectId = a.Id,
                Name = a.Name,
                Description = a.Description,
                Sprints = a.Sprints.Select(x => new SprintDto
                {
                    StardDate = x.StartDate,
                    EndDate = x.EndDate,
                    SprintName = x.SprintName
                }).OrderByDescending(x => x.SprintName).ToList()

            }).ToList();

            var response = new ProjectWithSprintResponseDto
            {
                Projects = project
            };

            return response;
        }
    }
}
