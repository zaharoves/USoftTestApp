using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyTestWebApplication.Models;
using MyTestWebApplication.Services;
using System.Diagnostics;

namespace MyTestWebApplication.Controllers
{
    public class HomeController : Controller
    {
        RecordContext _recordContext;
        public HomeController(RecordContext recordContext)
        {
            _recordContext = recordContext;
        }


        public async Task<IActionResult> Index(PageService pageService, int pageSize = 10, int firstPageRecord = 1)
        {
            IQueryable<Record> source = _recordContext.Records;
            int totalRecords = await source.CountAsync();
            List<Record>? records = await source.Skip(firstPageRecord - 1).Take(pageSize).ToListAsync();

            PageViewModel pageViewModel = new PageViewModel(totalRecords, pageSize, firstPageRecord, records, pageService.SelectPages);
            return View(pageViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}