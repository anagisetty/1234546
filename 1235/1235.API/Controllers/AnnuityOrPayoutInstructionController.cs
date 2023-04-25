using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _1235.DataAccess;
using _1235.DTO;
using _1235.Service;

namespace _1235.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnnuityOrPayoutInstructionController : ControllerBase
    {
        private readonly AnnuityOrPayoutInstructionService _annuityOrPayoutInstructionService;

        public AnnuityOrPayoutInstructionController(AnnuityOrPayoutInstructionService annuityOrPayoutInstructionService)
        {
            _annuityOrPayoutInstructionService = annuityOrPayoutInstructionService;
        }

        [HttpPost]
        public IActionResult Create([FromBody] AnnuityOrPayoutInstruction annuityOrPayoutInstruction)
        {
            _annuityOrPayoutInstructionService.Create(annuityOrPayoutInstruction);
            return Ok();
        }

        [HttpGet]
        public List<AnnuityOrPayoutInstruction> GetAll()
        {
            return _annuityOrPayoutInstructionService.GetAll();
        }

        [HttpGet("{id}")]
        public AnnuityOrPayoutInstruction GetById(int id)
        {
            return _annuityOrPayoutInstructionService.GetById(id);
        }

        [HttpPut]
        public IActionResult Update([FromBody] AnnuityOrPayoutInstruction annuityOrPayoutInstruction)
        {
            _annuityOrPayoutInstructionService.Update(annuityOrPayoutInstruction);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _annuityOrPayoutInstructionService.Delete(id);
            return Ok();
        }

        [HttpPut("modify")]
        public IActionResult ModifyAnnuityOrPayoutInstruction([FromBody] AnnuityOrPayoutInstruction annuityOrPayoutInstruction)
        {
            _annuityOrPayoutInstructionService.ModifyAnnuityOrPayoutInstruction(annuityOrPayoutInstruction);
            return Ok();
        }
    }
}