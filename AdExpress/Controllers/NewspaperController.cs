using System.Net;
using System.Web.Mvc;
using AdExpress.AdExpressWcfService;
using AdExpress.Models;
using AutoMapper;

namespace AdExpress.Controllers
{
    public class NewspaperController : Controller
    {
        private readonly AdExpressWcfServiceClient _service;

        public NewspaperController()
        {
            _service = new AdExpressWcfServiceClient();
        }
        // GET: /Newspaper/
        public ActionResult Index()
        {
            var sources = _service.GetAllNewspapers();
            var newspapers = Mapper.Map<Newspaper[], NewspaperViewModel[]>(sources);
            return View(newspapers);
        }

        // GET: /Newspaper/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewspaperViewModel newspaperviewmodel = Mapper.Map<Newspaper, NewspaperViewModel>(_service.FindNewspaper(id));
            if (newspaperviewmodel == null)
            {
                return HttpNotFound();
            }
            return View(newspaperviewmodel);
        }

        // GET: /Newspaper/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Newspaper/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ID,Name,Category")] NewspaperViewModel newspaperviewmodel)
        {
            if (ModelState.IsValid)
            {
                _service.AddNewspaper(newspaperviewmodel.Name, newspaperviewmodel.Category);
                return RedirectToAction("Index");
            }

            return View(newspaperviewmodel);
        }

         //GET: /Newspaper/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewspaperViewModel newspaperviewmodel = Mapper.Map<Newspaper, NewspaperViewModel>(_service.FindNewspaper(id));
            if (newspaperviewmodel == null)
            {
                return HttpNotFound();
            }
            return View(newspaperviewmodel);
        }

        // POST: /Newspaper/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Category")] NewspaperViewModel newspaperviewmodel)
        {
            if (ModelState.IsValid)
            {
                Newspaper newspaper = Mapper.Map<NewspaperViewModel, Newspaper>(newspaperviewmodel);
                _service.SaveNewspaper(newspaper);
                return RedirectToAction("Index");
            }
            return View(newspaperviewmodel);
        }

        // GET: /Newspaper/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewspaperViewModel newspaperviewmodel = Mapper.Map<Newspaper, NewspaperViewModel>(_service.FindNewspaper(id));
            if (newspaperviewmodel == null)
            {
                return HttpNotFound();
            }
            return View(newspaperviewmodel);
        }

        // POST: /Newspaper/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _service.RemoveNewspaper(_service.FindNewspaper(id));
            return RedirectToAction("Index");
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
