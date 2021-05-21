using AutoLotDAL.Models;
using System.Data.Entity;
using System.Threading.Tasks;

namespace AutoLotDAL.Repos {
	public class CreditRiskRepo : BaseRepo<CreditRisk>, IRepo<CreditRisk> {

		public CreditRiskRepo() {
			Table = Context.CreditRisks;
		}

		public int Delete(int id) {
			Context.Entry(new CreditRisk { CustId = id }).State = EntityState.Deleted;
			return SaveChanges();
		}

		public Task<int> DeleteAsync(int id) {
			Context.Entry(new CreditRisk { CustId = id }).State = EntityState.Deleted;
			return SaveChangesAsync();
		}
	}
}
