using Microsoft.EntityFrameworkCore;

namespace ValidationSQLApiModel
{
	public class SQLDB : DbContext
	{
		public SQLDB(DbContextOptions<SQLDB> options)
			:base(options)
		{
			
		}

		public DbSet<PropertySql> SQLDBItems { get; set; }
	}
}
