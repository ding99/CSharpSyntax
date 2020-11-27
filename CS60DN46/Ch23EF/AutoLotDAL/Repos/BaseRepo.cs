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
	public abstract class BaseRepo<T> where T : class, new() {
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
	}
}
