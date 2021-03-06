﻿using System.Web.Http;
using System.Web.Mvc;
using WorkSample.Api.App_Start;

namespace WorkSample.Api
{
	public class WebApiApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();
			GlobalConfiguration.Configure(WebApiConfig.Register);
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			AutofacConfig.Register(GlobalConfiguration.Configuration);
		}
	}
}
