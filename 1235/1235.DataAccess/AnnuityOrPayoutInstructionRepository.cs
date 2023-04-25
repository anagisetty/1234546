using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1235
{
    public class AnnuityOrPayoutInstructionRepository
    {
        //Create
        public void Create(AnnuityOrPayoutInstruction annuityOrPayoutInstruction)
        {
            using (var context = new _1235Context())
            {
                context.AnnuityOrPayoutInstructions.Add(annuityOrPayoutInstruction);
                context.SaveChanges();
            }
        }

        //Read
        public List<AnnuityOrPayoutInstruction> GetAll()
        {
            using (var context = new _1235Context())
            {
                return context.AnnuityOrPayoutInstructions.ToList();
            }
        }

        public AnnuityOrPayoutInstruction GetById(int id)
        {
            using (var context = new _1235Context())
            {
                return context.AnnuityOrPayoutInstructions.FirstOrDefault(x => x.Id == id);
            }
        }

        //Update
        public void Update(AnnuityOrPayoutInstruction annuityOrPayoutInstruction)
        {
            using (var context = new _1235Context())
            {
                context.Entry(annuityOrPayoutInstruction).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        //Delete
        public void Delete(int id)
        {
            using (var context = new _1235Context())
            {
                var annuityOrPayoutInstruction = context.AnnuityOrPayoutInstructions.FirstOrDefault(x => x.Id == id);

                context.AnnuityOrPayoutInstructions.Remove(annuityOrPayoutInstruction);
                context.SaveChanges();
            }
        }
    }
}