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
        private readonly ILogger<HomeController> _logger;
        private readonly GmsContext _context;
        public HomeController(ILogger<HomeController> logger, GmsContext context)
        {
            _logger = logger;
            _context = context;
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

        [IgnoreAntiforgeryToken]
        [HttpPost]
        public async Task<ActionResult> GetByCustomFilter(SearchingInfo searchInfo)
        {
            try
            {
                string sort = string.Empty;
                if (searchInfo.Sort != null)
                {
                    var sortInfoList = JsonConvert.DeserializeObject<List<SortingInfo>>(searchInfo.Sort);
                    foreach (var sortInfo in sortInfoList)
                    {
                        sort += sortInfo.Selector + (bool.Parse(sortInfo.Desc.ToString()) ? " desc" : " asc");
                        sort += ",";
                    }
                }

                if (searchInfo.Filter != null)
                {
                    var filterList = JsonConvert.DeserializeObject<IList>(searchInfo.Filter, new JsonSerializerSettings
                    {
                        DateParseHandling = DateParseHandling.None
                    });
                }

                if (searchInfo.DynamicFilter != null)
                {
                    searchInfo.IsAdvanceSearch = true;
                    if (searchInfo.FilterText == null || searchInfo.FilterText == "")
                    {
                        searchInfo.FilterText = "(" + searchInfo.DynamicFilter + ")";
                    }
                    else
                    {
                        searchInfo.FilterText = searchInfo.FilterText + " AND (" + searchInfo.DynamicFilter + ")";
                    }
                }

                if (searchInfo.IsAdvanceSearch && !searchInfo.FilterText.EndsWith("#"))
                {
                    searchInfo.FilterText = searchInfo.FilterText + "#";
                }

                ViewData.Add("SearchInfo", searchInfo);
                searchInfo.PageSize = searchInfo.Take == 0 ? 10 : searchInfo.Take;
                searchInfo.CurrentPageIndex = searchInfo.Skip == 0 ? 0 : (searchInfo.Skip / searchInfo.Take) + 1;
                ResponseResult<StockItem>? page = new ResponseResult<StockItem>();
                page = await (from st in _context.StockItems
                              join refst in _context.ReferenceStores on st.StoreId equals refst.Id
                              where (st.Enabled == true && refst.StoreId == 4)
                              select st).ToPagedAsync(searchInfo.CurrentPageIndex, searchInfo.PageSize, sort);
                return Json(new { data = page.Items, totalcount = page.TotalItemCount });
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }

        [IgnoreAntiforgeryToken]
        [HttpPost]
        public async Task<ActionResult> GetBySafeBoxOrder(SearchingInfo searchInfo)
        {
            try
            {
                string sort = string.Empty;
                if (searchInfo.Sort != null)
                {
                    var sortInfoList = JsonConvert.DeserializeObject<List<SortingInfo>>(searchInfo.Sort);
                    foreach (var sortInfo in sortInfoList)
                    {
                        sort += sortInfo.Selector + (bool.Parse(sortInfo.Desc.ToString()) ? " desc" : " asc");
                        sort += ",";
                    }
                }

                if (searchInfo.Filter != null)
                {
                    var filterList = JsonConvert.DeserializeObject<IList>(searchInfo.Filter, new JsonSerializerSettings
                    {
                        DateParseHandling = DateParseHandling.None
                    });
                }

                if (searchInfo.DynamicFilter != null)
                {
                    searchInfo.IsAdvanceSearch = true;
                    if (searchInfo.FilterText == null || searchInfo.FilterText == "")
                    {
                        searchInfo.FilterText = "(" + searchInfo.DynamicFilter + ")";
                    }
                    else
                    {
                        searchInfo.FilterText = searchInfo.FilterText + " AND (" + searchInfo.DynamicFilter + ")";
                    }
                }

                if (searchInfo.IsAdvanceSearch && !searchInfo.FilterText.EndsWith("#"))
                {
                    searchInfo.FilterText = searchInfo.FilterText + "#";
                }

                ViewData.Add("SearchInfo", searchInfo);
                searchInfo.PageSize = searchInfo.Take == 0 ? 10 : searchInfo.Take;
                searchInfo.CurrentPageIndex = searchInfo.Skip == 0 ? 0 : (searchInfo.Skip / searchInfo.Take) + 1;
                ResponseResult<StockItem>? page = new ResponseResult<StockItem>();
                page = await (from st in _context.StockItems
                              join refst in _context.ReferenceStores on st.StoreId equals refst.Id
                              where (st.Enabled == false && refst.StoreId == 1)
                              select st).ToPagedAsync(searchInfo.CurrentPageIndex, searchInfo.PageSize, sort);
                return Json(new { data = page.Items, totalcount = page.TotalItemCount });
            }
            catch (Exception ex)
            {
                return Json(new { error = ex.Message });
            }

        }

        [IgnoreAntiforgeryToken]
        [HttpPost]
        public async Task<ActionResult> ChangeSafeBox(SearchingInfo searchInfo)
        {
            try
            {
                Guid[] ids = null;

                if (searchInfo.Filter != null)
                {
                    var filterList = JsonConvert.DeserializeObject<IList>(searchInfo.Filter, new JsonSerializerSettings
                    {
                        DateParseHandling = DateParseHandling.None
                    });

                    string[] sid = filterList[2].ToString().Split(',');
                    ids = Array.ConvertAll(sid, Guid.Parse);
                }
                var refStore = await _context.ReferenceStores.Where(i => i.StoreId == 1).FirstOrDefaultAsync();
                if (ids != null && ids.Length > 0)
                {
                    foreach (var id in ids)
                    {
                        var changedresult = await _context.StockItems.Where(i => i.Id == id).FirstOrDefaultAsync();
                        changedresult.Enabled = false;
                        changedresult.StoreId = refStore.Id;
                        changedresult.StoreCode = refStore.StoreCode;
                        changedresult.StoreDescription = refStore.StoreDescription;
                        _context.StockItems.Attach(changedresult);
                        _context.SaveChanges();
                    }

                }
                return Json("Update Successful");
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }

        [IgnoreAntiforgeryToken]
        [HttpPost]
        public async Task<ActionResult> ChangeInHand(SearchingInfo searchInfo)
        {
            try
            {
                Guid[] ids = null;
                if (searchInfo.Filter != null)
                {
                    var filterList = JsonConvert.DeserializeObject<IList>(searchInfo.Filter, new JsonSerializerSettings
                    {
                        DateParseHandling = DateParseHandling.None
                    });

                    string[] sid = filterList[2].ToString().Split(',');
                    ids = Array.ConvertAll(sid, Guid.Parse);
                }
                var refStore = await _context.ReferenceStores.Where(i => i.StoreId == 4).FirstOrDefaultAsync();
                if (ids != null && ids.Length > 0)
                {
                    foreach (var id in ids)
                    {
                        var changedresult = await _context.StockItems.Where(i => i.Id == id).FirstOrDefaultAsync();
                        changedresult.Enabled = true;
                        changedresult.StoreId = refStore.Id;
                        changedresult.StoreCode = refStore.StoreCode;
                        changedresult.StoreDescription = refStore.StoreDescription;
                        _context.StockItems.Attach(changedresult);
                        _context.SaveChanges();
                    }
                }
                return Json("Update Successful");
            }
            catch (Exception ex)
            {
                return Json(new { error = ex.Message });
            }

        }

        [HttpGet]
        public async Task<ActionResult> OrderDropdown(string prefix)
        {
            try
            {
                var result = _context.OrderOrders.Take(5).ToList();
                var jsonResult = new JsonResult(result.Select(r => new { text = "[" + r.OrderCode + "] " + r.OrderDescription, description = r.OrderDescription, id = r.Id, code = r.OrderCode }));
                return Json(new { data = jsonResult, add = true });
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult> SmithDropdown(string prefix)
        {
            try
            {
                var result = _context.SmithSmiths.ToList();
                var jsonResult = new JsonResult(result.Select(r => new { text = "[" + r.SmithCode + "] " + r.SmithDescription, description = r.SmithDescription, id = r.Id, code = r.SmithCode }));
                return Json(new { data = jsonResult, add = true });
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult> CategoryDropdown(string prefix)
        {
            try
            {
                var result = await _context.ReferenceCategories.ToListAsync();
                var jsonResult = new JsonResult(result.Select(r => new { text = "[" + r.CategoryCode + "] " + r.CategoryDescription, description = r.CategoryDescription, id = r.Id, code = r.CategoryCode }));
                return Json(new { data = jsonResult, add = true });
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult> SubCategoryDropdown(string prefix)
        {
            try
            {
                var result = _context.ReferenceSubCategories.ToList();
                var jsonResult = new JsonResult(result.Select(r => new { text = "[" + r.CategoryCode + "] " + r.CategoryDescription, description = r.CategoryDescription, id = r.Id, code = r.CategoryCode }));
                return Json(new { data = jsonResult, add = true });
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult> ReferenceItemCategoriesDropdown(string prefix)
        {
            try
            {
                var result = _context.ReferenceItemCategories.ToList();
                var jsonResult = new JsonResult(result.Select(r => new { text = "[" + r.CategoryCode + "] " + r.CategoryDescription, description = r.CategoryDescription, id = r.Id, code = r.CategoryCode }));
                return Json(new { data = jsonResult, add = true });
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult> ReferenceStoresDropdown(string prefix)
        {
            try
            {
                var result = _context.ReferenceStores.ToList();
                var jsonResult = new JsonResult(result.Select(r => new { text = "[" + r.StoreCode + "] " + r.StoreDescription, description = r.StoreDescription, id = r.Id, code = r.StoreCode }));
                return Json(new { data = jsonResult, add = true });
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }

    }

}