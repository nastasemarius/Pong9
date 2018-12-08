using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Pong9.Api.Models.WorkSpaceModels;
using Pong9.Data.DTO;
using Pong9.IServices;

namespace Pong9.Api.Controllers
{
    [ApiController]
    [Route("workSpace/[action]")]
    public class WorkspaceController : Controller
    {
        private readonly IWorkSpaceService _workSpaceService;

        public WorkspaceController(IWorkSpaceService workSpaceService)
        {
            _workSpaceService = workSpaceService;
        }

        [AllowAnonymous]
        [HttpPost, ActionName("create")]
        public IActionResult CreateWorkSpace([FromBody] WorkSpaceCreateModel workSpaceModel)
        {
            var workSpaceDto = new WorkSpaceDTO()
            {
                Name = workSpaceModel.Name,
                UserName = workSpaceModel.Username,
                NumberOfTables = workSpaceModel.NumberOfTables
            };

            _workSpaceService.CreateWorkSpace(workSpaceDto);

            if (!_workSpaceService.GetWorkSpaceByName(workSpaceDto.Name).IsSuccess)
            {
                return BadRequest();
            }

            return Ok(_workSpaceService.GetWorkSpaceByName(workSpaceDto.Name));
        }

        [HttpGet, ActionName("get")]
        public IActionResult GetWorkSpaceById(Guid id)
        {
            var workspaceResult = _workSpaceService.GetWorkSpaceById(id);
            if (!workspaceResult.IsSuccess)
            {
                return NotFound();
            }

            return Ok(workspaceResult.Value);
        }

        [HttpPost, ActionName("delete")]
        public IActionResult DeleteWorkSpace(Guid id)
        {
            var gotDeleted = _workSpaceService.DeleteWorkSpace(id);
            if (gotDeleted)
            {
                return Ok();
            }

            return NotFound();
        }

        [HttpPut, ActionName("update")]
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
