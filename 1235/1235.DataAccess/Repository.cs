using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 1235
{
    // Repository class to perform all CRUD operations
    public class Repository
    {
        public void Create(ReopenLitigationClaim claim)
        {
            using (var context = new ReopenLitigationClaimContext())
            {
                context.ReopenLitigationClaims.Add(claim);
                context.SaveChanges();
            }
        }

        public ReopenLitigationClaim Read(int id)
        {
            using (var context = new ReopenLitigationClaimContext())
            {
                return context.ReopenLitigationClaims.FirstOrDefault(c => c.Id == id);
            }
        }

        public void Update(ReopenLitigationClaim claim)
        {
            using (var context = new ReopenLitigationClaimContext())
            {
                var claimToUpdate = context.ReopenLitigationClaims.FirstOrDefault(c => c.Id == claim.Id);
                claimToUpdate.ReopenReason = claim.ReopenReason;
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = new ReopenLitigationClaimContext())
            {
                var claimToDelete = context.ReopenLitigationClaims.FirstOrDefault(c => c.Id == id);
                context.ReopenLitigationClaims.Remove(claimToDelete);
                context.SaveChanges();
            }
        }
    }
}