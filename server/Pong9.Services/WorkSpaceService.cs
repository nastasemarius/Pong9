using System;
using System.Collections.Generic;
using System.Linq;
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
        private readonly IUserRepository _userRepository;
        private readonly IPingPongTableRepository _pingPongTableRepository;

        public WorkSpaceService(IWorkSpaceRepository workSpaceRepository, IUserRepository userRepository, IPingPongTableRepository pingPongTableRepository)
        {
            _userRepository = userRepository;
            _workSpaceRepository = workSpaceRepository;
            _pingPongTableRepository = pingPongTableRepository;
        }

        public void CreateWorkSpace(WorkSpaceDTO workSpaceDto)
        {
            _workSpaceRepository.CreateWorkSpace(workSpaceDto);

            var workSpace = _workSpaceRepository.GetWorkSpaceByName(workSpaceDto.Name);
            var userId = _userRepository.GetUserByUsername(workSpaceDto.UserName).UserId;

            var userDto = new UserDTO()
            {
                WorkSpaceId = workSpace.WorkSpaceId
            };

            _userRepository.EditUser(userId, userDto);

            for (var index = 0; index < workSpaceDto.NumberOfTables; ++index)
            {
                var pingPongDto = new PingPongTableDTO()
                {
                    Name = "Table" + (index + 1).ToString(),
                    StartingHour = DateTime.Now,
                    EndingHour = DateTime.Now,
                    WorkingStateId = workSpace.WorkSpaceId
                };

                _pingPongTableRepository.CreatePingPongTable(pingPongDto);
            }
        }

        public ApiResult<WorkSpace> GetWorkSpaceByName(string name)
        {
            var workspace = _workSpaceRepository.GetWorkSpaceByName(name);
            if (workspace == null)
            {
                return new ApiResult<WorkSpace>(false);
            }

            return new ApiResult<WorkSpace>(workspace);
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
