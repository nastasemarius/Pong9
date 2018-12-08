using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pong9.Api.Models.WorkSpaceModels;
using Pong9.Data.DTO;
using Pong9.Data.Entities;
using Pong9.IRepositories;
using Pong9.IServices;

namespace Pong9.Api.Controllers
{
    [Route("workSpace/[action]")]
    [ApiController]
    public class WorkspaceController : Controller
    {
        private readonly IWorkSpaceService _workSpaceService;

        public WorkspaceController(IWorkSpaceService workSpaceService)
        {
            _workSpaceService = workSpaceService;
        }

        [HttpPost]
        public IActionResult CreateWorkSpace([FromBody] WorkSpaceCreateModel workSpaceModel)
        {
            var workSpaceDto = new WorkSpaceDTO()
            {
                Name = workSpaceModel.Name,
                NumberOfTables = workSpaceModel.NumberOfTables,
                UserName = workSpaceModel.Username
            };

            _workSpaceService.CreateWorkSpace(workSpaceDto);

            return Ok();
        }

        [HttpGet]
        public IActionResult GetWorkSpaceById(Guid id)
        {
            var workspaceResult = _workSpaceService.GetWorkSpaceById(id);
            if (!workspaceResult.IsSuccess)
            {
                return NotFound();
            }

            return Ok(workspaceResult.Value);
        }

        [HttpDelete]
        public IActionResult DeleteWorkSpace(Guid id)
        {
            var gotDeleted = _workSpaceService.DeleteWorkSpace(id);
            if (gotDeleted)
            {
                return Ok();
            }

            return NotFound();
        }

        [HttpPut]
        public IActionResult UpdateWorkSpace(Guid id, [FromBody] WorkSpaceDTO workSpaceDto)
        {
            var gotUpdated = _workSpaceService.UpdateWorkSpace(id, workSpaceDto);
            if (gotUpdated == false)
            {
                return NotFound();
            }

            return Ok();
        }
    }
}
