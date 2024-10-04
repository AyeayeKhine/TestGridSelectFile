using Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using TestGridSelectFile.Extensions;
using TestGridSelectFile.Models;

namespace TestGridSelectFile.Controllers
{
    public class HomeController : BaseController
    {
        public string connsectionString = "Data Source=DESKTOP-251TL74;Initial Catalog=TestDB2;Integrated Security=True;Trust Server Certificate=True";
        private readonly ILogger<HomeController> _logger;
        //private readonly TestDb2Context _context;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            //_context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        //Search: Home/UserMember
       [IgnoreAntiforgeryToken]
       [HttpPost]
        //public async Task<ActionResult> GetByCustomFilter(SearchingInfo searchInfo)
        //{
        //    string sort = string.Empty;
        //    int[] ids = null;
        //    if (searchInfo.Sort != null)
        //    {
        //        var sortInfoList = JsonConvert.DeserializeObject<List<SortingInfo>>(searchInfo.Sort);
        //        foreach (var sortInfo in sortInfoList)
        //        {
        //            sort += sortInfo.Selector + (bool.Parse(sortInfo.Desc.ToString()) ? " desc" : " asc");
        //            sort += ",";
        //        }
        //    }

        //    if (searchInfo.Filter != null)
        //    {
        //        var filterList = JsonConvert.DeserializeObject<IList>(searchInfo.Filter, new JsonSerializerSettings
        //        {
        //            DateParseHandling = DateParseHandling.None
        //        });

        //        string[] sid =filterList[2].ToString().Split(',');
        //        ids = Array.ConvertAll(sid, int.Parse);
        //    }

        //    if (searchInfo.DynamicFilter != null)
        //    {
        //        searchInfo.IsAdvanceSearch = true;
        //        if (searchInfo.FilterText == null || searchInfo.FilterText == "")
        //        {
        //            searchInfo.FilterText = "(" + searchInfo.DynamicFilter + ")";
        //        }
        //        else
        //        {
        //            searchInfo.FilterText = searchInfo.FilterText + " AND (" + searchInfo.DynamicFilter + ")";
        //        }
        //    }

        //    if (searchInfo.IsAdvanceSearch && !searchInfo.FilterText.EndsWith("#"))
        //    {
        //        searchInfo.FilterText = searchInfo.FilterText + "#";
        //    }

        //    ViewData.Add("SearchInfo", searchInfo);
        //    searchInfo.PageSize = searchInfo.Take == 0 ? 10 : searchInfo.Take;
        //    searchInfo.CurrentPageIndex = searchInfo.Skip == 0 ? 0 : (searchInfo.Skip / searchInfo.Take) + 1;
        //    ResponseResult<TblUser>? page = new ResponseResult<TblUser>();
        //    if (ids != null && ids.Length > 0) {
        //        page = await _context.TblUsers.Where(i => ids.Contains(i.Id)).ToPagedAsync(searchInfo.CurrentPageIndex, searchInfo.PageSize, sort);
        //    }
        //    else
        //    {
        //        page = await _context.TblUsers.ToPagedAsync(searchInfo.CurrentPageIndex, searchInfo.PageSize, sort);
        //    }
        //    return Json(new { data = page.Items, totalcount = page.TotalItemCount });
        //}

        public IActionResult GetByCustomFilter()
        {
            return View();
        }

    }

}