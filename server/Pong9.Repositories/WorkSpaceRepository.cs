using Pong9.Data.Entities;
using Pong9.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using Pong9.Data.DTO;
using Pong9.Persistence;

namespace Pong9.Repositories
{
    public class WorkSpaceRepository : IWorkSpaceRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public WorkSpaceRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public IEnumerable<WorkSpace> GetAllWorkSpaces()
        {
            return _applicationDbContext.WorkSpaces.ToList();
        }

        public WorkSpace GetWorkSpaceById(Guid id)
        {
            return _applicationDbContext.WorkSpaces.SingleOrDefault(workSpace => workSpace.WorkSpaceId == id);
        }

        public void CreateWorkSpace(WorkSpaceDTO workSpaceDto)
        {
            var workSpace = WorkSpace.CreateWorkSpace();
            workSpace.UpdateWorkSpace(workSpaceDto.Name, workSpaceDto.UrlTag, workSpaceDto.Users);

            _applicationDbContext.WorkSpaces.Add(workSpace);
            _applicationDbContext.SaveChanges();
        }

        
        public void EditWorkSpace(WorkSpaceDTO workSpaceDto)
        {
            var workSpaceEdit = WorkSpace.CreateWorkSpace();
            workSpaceEdit.UpdateWorkSpace(workSpaceDto.Name, workSpaceDto.UrlTag, workSpaceDto.Users);

            _applicationDbContext.SaveChanges();
        }

        public void DeleteWorkSpace(WorkSpace workSpace)
        {
            _applicationDbContext.WorkSpaces.Remove(workSpace);
            _applicationDbContext.SaveChanges();
        }

    }
}
