using System;
using System.Collections.Generic;
using System.Text;
using Pong9.Data.Entities;
using Pong9.IRepositories;
using Pong9.IServices;
using Pong9.Services.Helpers;

namespace Pong9.Services
{
    public class WorkSpaceService : IWorkSpaceService
    {
        private readonly IWorkSpaceRepository _workSpaceRepository;

        public WorkSpaceService(IWorkSpaceRepository workSpaceRepository)
        {
            _workSpaceRepository = workSpaceRepository;
        }

        public ApiResult<WorkSpace> GetWorkspaceById(Guid id)
        {
            var workspace = _workSpaceRepository.GetWorkSpaceById(id);
            if (workspace == null)
            {
                return new ApiResult<WorkSpace>(false);
            }

            return new ApiResult<WorkSpace>(workspace);
        }
    }
}
