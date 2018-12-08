using System;
using System.Collections.Generic;
using System.Text;
using Pong9.Data.DTO;
using Pong9.Data.Entities;
using Pong9.Services.Helpers;

namespace Pong9.IServices
{
    public interface IWorkSpaceService
    {
        void CreateWorkSpace(WorkSpaceDTO workSpaceDto);

        ApiResult<WorkSpace> GetWorkSpaceById(Guid id);

        bool DeleteWorkSpace(Guid id);

        bool UpdateWorkSpace(Guid id, WorkSpaceDTO workSpaceDto);
    }
}
