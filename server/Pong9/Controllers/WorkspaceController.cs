using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pong9.Data.DTO;
using Pong9.IRepositories;

namespace Pong9.Api.Controllers
{
    public class WorkspaceController : Controller
    {
        private readonly IWorkSpaceRepository _workSpaceRepository;

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
        }
    }
}
