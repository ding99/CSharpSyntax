using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using AutoLotDAL.Models;

namespace AutoLotDAL.EF {
	public class DataInitializer : DropCreateDatabaseAlways<AutoLotEntities> {
		protected override void Seed(AutoLotEntities context) {
			
		}
	}
}
