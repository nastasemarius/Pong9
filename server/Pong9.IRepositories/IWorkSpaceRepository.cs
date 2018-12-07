using Pong9.Data.DTO;
using Pong9.Data.Entities;
using System;
using System.Collections.Generic;

namespace Pong9.IRepositories
{
    public interface IWorkSpaceRepository
    {
        IEnumerable<WorkSpace> GetAllWorkSpaces();
        WorkSpace GetWorkSpaceById(Guid id);
        void CreateWorkSpace(WorkSpaceDTO workSpace);
        void EditWorkSpace(WorkSpaceDTO workSpace);
        void DeleteWorkSpace(WorkSpace workSpace);
    }
}
