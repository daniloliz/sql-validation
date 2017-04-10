using System.Collections.Generic;

namespace ValidationSQLApiModel
{
	public interface ISQLDBRepository
	{
		void Add(PropertySql sql);
		IEnumerable<PropertySql> GetAll();
		PropertySql Find(long key);
		void Remove(long key);
		void Update(PropertySql key);
	}
}
