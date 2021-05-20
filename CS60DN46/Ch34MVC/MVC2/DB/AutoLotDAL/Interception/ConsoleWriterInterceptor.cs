using System.Data.Common;
using System.Data.Entity.Infrastructure.Interception;
using System.Reflection;
using static System.Console;

namespace AutoLotDAL.Interception {
	public class ConsoleWriterInterceptor : IDbCommandInterceptor {
		public void NonQueryExecuting(DbCommand command, DbCommandInterceptionContext<int> interceptionContext) {
			WriteInfo(interceptionContext.IsAsync, MethodInfo.GetCurrentMethod().Name, command.CommandText);
		}
		public void NonQueryExecuted(DbCommand command, DbCommandInterceptionContext<int> interceptionContext) {
			WriteInfo(interceptionContext.IsAsync, MethodInfo.GetCurrentMethod().Name, command.CommandText);
		}

		public void ReaderExecuting(DbCommand command, DbCommandInterceptionContext<DbDataReader> interceptionContext) {
			WriteInfo(interceptionContext.IsAsync, MethodInfo.GetCurrentMethod().Name, command.CommandText);
		}
		public void ReaderExecuted(DbCommand command, DbCommandInterceptionContext<DbDataReader> interceptionContext) {
			WriteInfo(interceptionContext.IsAsync, MethodInfo.GetCurrentMethod().Name, command.CommandText);
		}

		public void ScalarExecuting(DbCommand command, DbCommandInterceptionContext<object> interceptionContext) {
			WriteInfo(interceptionContext.IsAsync, MethodInfo.GetCurrentMethod().Name, command.CommandText);
		}
		public void ScalarExecuted(DbCommand command, DbCommandInterceptionContext<object> interceptionContext) {
			WriteInfo(interceptionContext.IsAsync, MethodInfo.GetCurrentMethod().Name, command.CommandText);
		}

		private void WriteInfo(bool isAsync, string method, string commandText) {
			WriteLine($"IsAsync: {isAsync}, Method: <{method}>, Command Text: {commandText}");
		}
	}
}
