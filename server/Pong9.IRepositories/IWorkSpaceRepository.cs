using Pong9.Data.Entities;
using System;
using System.Collections.Generic;

namespace Pong9.IRepositories
{
    public interface IWorkSpaceRepository
    {
        IEnumerable<WorkSpace> GetAllWorkSpaces();
        WorkSpace GetWorkSpaceById(Guid id);
        void CreateWorkSpace(WorkSpace workSpace);
        void EditWorkSpace(WorkSpace workSpace);
        void DeleteWorkSpace(WorkSpace workSpace);
    }
}
