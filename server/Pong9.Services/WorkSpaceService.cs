using System;
using System.Collections.Generic;
using System.Text;
using Pong9.Data.DTO;
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

        public void CreateWorkSpace(WorkSpaceDTO workSpaceDto)
        {
            _workSpaceRepository.CreateWorkSpace(workSpaceDto);
        }

        public ApiResult<WorkSpace> GetWorkSpaceById(Guid id)
        {
            var workspace = _workSpaceRepository.GetWorkSpaceById(id);
            if (workspace == null)
            {
                return new ApiResult<WorkSpace>(false);
            }

            return new ApiResult<WorkSpace>(workspace);
        }

        public bool DeleteWorkSpace(Guid id)
        {
            var workspace = _workSpaceRepository.GetWorkSpaceById(id);
            if (workspace == null)
            {
                return false;
            }

            _workSpaceRepository.DeleteWorkSpace(workspace);

            return true;
        }

        public bool UpdateWorkSpace(Guid id, WorkSpaceDTO workSpaceDto)
        {
            var workspace = _workSpaceRepository.GetWorkSpaceById(id);
            if (workspace == null)
            {
                return false;
            }

            _workSpaceRepository.EditWorkSpace(id, workSpaceDto);

            return true;
        }
    }
}
