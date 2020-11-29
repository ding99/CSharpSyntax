using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data.Entity.Infrastructure.Interception;
using static System.Console;

namespace AutoLotDAL.Interception {
	public class ConsoleWriterInterceptor : IDbCommandInterceptor {
		public void NonQueryExecuting(DbCommand command, DbCommandInterceptionContext<int> interceptionContext) {

		}
		public void NonQueryExecuted(DbCommand command, DbCommandInterceptionContext<int> interceptionContext) {

		}

		public void ReaderExecuting(DbCommand command, DbCommandInterceptionContext<DbDataReader> interceptionContext) {

		}
		public void ReaderExecuted(DbCommand command, DbCommandInterceptionContext<DbDataReader> interceptionContext) {

		}

		public void ScalarExecuting(DbCommand command, DbCommandInterceptionContext<object> interceptionContext) {

		}
		public void ScalarExecuted(DbCommand command, DbCommandInterceptionContext<object> interceptionContext) {

		}
	}
}
