using System;
using System.Linq;
using System.Linq.Expressions;
using Find2Fuck.BL.Logger;
using Find2Fuck.Interfaces.Logger;

namespace Find2Fuck.BL.Repositories
{
	public abstract class RepositoryBase
	{
		#region Variables
		private static readonly ILogger DefaultLogger = new Ui2DbLogger();
		private readonly ILogger mLogger;
		#endregion

		#region Properties
		public ILogger Logger
		{
			get
			{
				return mLogger;
			}
		}
		#endregion

		#region Constructor
		protected RepositoryBase(ILogger logger)
		{
			mLogger = logger ?? DefaultLogger;
		}
		#endregion

		#region Methods
		protected long GetNextId<TItem>(IQueryable<TItem> items, Expression<Func<TItem, long>> selector)
		{
			try
			{
				var primKeys = items.OrderByDescending(selector).Select(selector).Take(1).ToList();
				return primKeys.Any() ? primKeys.Max() + 1 : 1;
			}
			catch (Exception ex)
			{
				Logger.Log(ex);
				return 1;
			}
		}
		#endregion
	}
}
