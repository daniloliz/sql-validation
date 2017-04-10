using System.Collections.Generic;
using System.Linq;

namespace ValidationSQLApiModel
{
	public class SQLDBRepository : ISQLDBRepository
	{
		private readonly SQLDB SqlDb;

		public SQLDBRepository(SQLDB SqlDb)
		{
			this.SqlDb = SqlDb;
		}

		public IEnumerable<PropertySql> GetAll()
		{
			return SqlDb.SQLDBItems.ToList();
		}

		public void Add(PropertySql item)
		{
			SqlDb.SQLDBItems.Add(item);
			SqlDb.SaveChanges();
		}

		public PropertySql Find(long key)
		{
			return SqlDb.SQLDBItems.FirstOrDefault(x => x.Id == key);
		}

		public void Remove(long key)
		{
			var item = SqlDb.SQLDBItems.FirstOrDefault(x => x.Id == key);
			SqlDb.SQLDBItems.Remove(item);
			SqlDb.SaveChanges();
		}

		public void Update(PropertySql item)
		{
			SqlDb.SQLDBItems.Update(item);
			SqlDb.SaveChanges();
		}
	}
}
