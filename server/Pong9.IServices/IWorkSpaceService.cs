using System;
using System.Collections.Generic;
using System.Text;
using Pong9.Data.Entities;
using Pong9.Services.Helpers;

namespace Pong9.IServices
{
    public interface IWorkSpaceService
    {
        ApiResult<WorkSpace> GetWorkspaceById(Guid id);

        
    }
}
