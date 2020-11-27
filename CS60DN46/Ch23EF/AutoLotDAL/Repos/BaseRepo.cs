﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using AutoLotDAL.EF;

namespace AutoLotDAL.Repos {
	public abstract class BaseRepo<T> : IRepo<T> where T : class, new() {
		public AutoLotEntities Context { get; } = new AutoLotEntities();
		protected DbSet<T> Table;

		internal int SaveChanges() {
			try {
				return Context.SaveChanges();
			}
			catch(DbUpdateConcurrencyException ex) {
				throw;
			}
			catch(DbUpdateException ex) {
				throw;
			}
			catch(CommitFailedException ex) {
				throw;
			}
			catch(Exception ex) {
				throw;
			}
		}

		internal async Task<int> SaveChangesAsync() {
			try {
				return await Context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException ex) {
				throw;
			}
			catch (DbUpdateException ex) {
				throw;
			}
			catch (CommitFailedException ex) {
				throw;
			}
			catch (Exception ex) {
				throw;
			}
		}

		public T GetOne(int? id) => Table.Find(id);
		public Task<T> GetOneAsync(int? id) => Table.FindAsync(id);
		public List<T> GetAll() => Table.ToList();
		public Task<List<T>> GetAllAsync() => Table.ToListAsync();

		public List<T> ExecuteQuery(string sql) => Table.SqlQuery(sql).ToList();
		public Task<List<T>> ExecuteQueryAsync(string sql) => Table.SqlQuery(sql).ToListAsync();
		public List<T> ExecuteQuery(string sql, object[] sqlParametersObjects) => Table.SqlQuery(sql, sqlParametersObjects).ToList();
		public Task<List<T>> ExecuteQueryAsync(string sql, object[] sqlParametersObjects) => Table.SqlQuery(sql, sqlParametersObjects).ToListAsync();
	}
}
