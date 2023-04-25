using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 1235.DataAccess;
using 1235.DTO;
using Microsoft.AspNetCore.Mvc;

namespace 1235.API
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReopenLitigationClaimController : ControllerBase
    {
        private ReopenLitigationClaimService _reopenLitigationClaimService;

        public ReopenLitigationClaimController()
        {
            _reopenLitigationClaimService = new ReopenLitigationClaimService();
        }

        [HttpPost]
        public IActionResult ReopenClaim([FromBody] ReopenLitigationClaim claim)
        {
            _reopenLitigationClaimService.ReopenClaim(claim);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetReopenClaim(int id)
        {
            var claim = _reopenLitigationClaimService.GetReopenClaim(id);
            return Ok(claim);
        }

        [HttpPut]
        public IActionResult UpdateReopenClaim([FromBody] ReopenLitigationClaim claim)
        {
            _reopenLitigationClaimService.UpdateReopenClaim(claim);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteReopenClaim(int id)
        {
            _reopenLitigationClaimService.DeleteReopenClaim(id);
            return Ok();
        }
    }
}