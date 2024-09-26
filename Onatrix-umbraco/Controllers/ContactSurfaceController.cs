using Microsoft.AspNetCore.Mvc;
using Onatrix_umbraco.Models;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Website.Controllers;

namespace Onatrix_umbraco.Controllers;

public class ContactSurfaceController : SurfaceController
{
	public ContactSurfaceController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider) : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
	{
	}

	public IActionResult HandleSubmit(ContactFormModel form)
	{
		if (!ModelState.IsValid)
		{
			ViewData["name"] = form.Name;
			ViewData["phone"] = form.Phone;
			ViewData["email"] = form.Email;
			ViewData["selectOption"] = form.SelectOption;
			ViewData["message"] = form.Message;

			ViewData["error_name"] = string.IsNullOrEmpty(form.Name);
			ViewData["error_phone"] = string.IsNullOrEmpty(form.Phone);
			ViewData["error_email"] = string.IsNullOrEmpty(form.Email);
			ViewData["error_selectOption"] = string.IsNullOrEmpty(form.SelectOption);
			ViewData["error_message"] = string.IsNullOrEmpty(form.Message);

			return CurrentUmbracoPage();
		}

		TempData["success"] = "Your form has successfully been submitted";
		return RedirectToCurrentUmbracoPage();
	}

	public IActionResult ReturnSubmit()
	{
		return RedirectToCurrentUmbracoPage();
	}
}
