using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 1235.DataAccess;
using 1235.DTO;

namespace 1235
{
    public class ReopenLitigationClaimService
    {
        private Repository _repository;

        public ReopenLitigationClaimService()
        {
            _repository = new Repository();
        }

        public void ReopenClaim(ReopenLitigationClaim claim)
        {
            _repository.Create(claim);
        }

        public ReopenLitigationClaim GetReopenClaim(int id)
        {
            return _repository.Read(id);
        }

        public void UpdateReopenClaim(ReopenLitigationClaim claim)
        {
            _repository.Update(claim);
        }

        public void DeleteReopenClaim(int id)
        {
            _repository.Delete(id);
        }
    }
}