using AutoLotDAL.EF;

namespace AutoLotDAL.Repos {
	public abstract class BaseRepo<T> where T: class, new() {
		public AutoLotEntities Context { get; } = new AutoLotEntities();
	}
}
