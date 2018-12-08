using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pong9.Data.DTO;
using Pong9.IRepositories;
using Pong9.IServices;

namespace Pong9.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WorkspaceController : Controller
    {
        /*private readonly IWorkSpaceRepository _workSpaceRepository;

        public WorkspaceController(IWorkSpaceRepository workSpaceRepository)
        {
            _workSpaceRepository = workSpaceRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_workSpaceRepository.GetAllWorkSpaces());
        }

        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            var workspace = _workSpaceRepository.GetWorkSpaceById(id);
            if (workspace == null)
            {
                return NotFound();
            }

            _workSpaceRepository.DeleteWorkSpace(workspace);

            return Ok();
        }

        [HttpPost]
        public IActionResult Create([FromBody]WorkSpaceDTO workSpaceDto)
        {
            _workSpaceRepository.CreateWorkSpace(workSpaceDto);

            return Ok();
        }

        [HttpPut]
        public IActionResult Update(Guid id, [FromBody]WorkSpaceDTO workSpaceDto)
        {
            var workspace = _workSpaceRepository.GetWorkSpaceById(id);
            if (workspace == null)
            {
                return NotFound();
            }

            _workSpaceRepository.EditWorkSpace(id, workSpaceDto);

            return Ok();
        }*/

        private readonly IWorkSpaceService _workSpaceService;

        public WorkspaceController(IWorkSpaceService workSpaceService)
        {
            _workSpaceService = workSpaceService;
        }

        [HttpPost]
        public IActionResult CreateWorkSpace([FromBody] WorkSpaceDTO workSpaceDto)
        {
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
