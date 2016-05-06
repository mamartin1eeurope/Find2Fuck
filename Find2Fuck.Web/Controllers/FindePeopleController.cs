using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Find2Fuck.Web.Models;

namespace Find2Fuck.Web.Controllers
{
	public class FindPeopleController : Controller
	{
		#region Views
		public ActionResult Index()
		{
			return View();
		}
		#endregion

		#region Actions
		public ActionResult LoadPositions()
		{
			try
			{
				var positionsModel =  new List<PositionsModel>();

				var item = new PositionsModel
				{
					Name = "Pivita 1",
					Latitude = 37.3611622,
					Longitude = -6.0579287
				};

				positionsModel.Add(item);

				item = new PositionsModel
				{
					Name = "Pivita 2",
					Latitude = 37.368764,
					Longitude = -6.0895787
				};

				positionsModel.Add(item);

				return Json(new { ok = true, positions = positionsModel });
			}
			catch (Exception ex)
			{
				return Json(new { ok = false, message = ex.Message });
			}
		}
		#endregion
	}
}