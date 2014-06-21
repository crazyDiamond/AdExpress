using System.Net;
using System.Web.Mvc;
using AdExpress.AdExpressWcfService;
using AdExpress.Models;
using AutoMapper;

namespace AdExpress.Controllers
{
    public class AssociationController : Controller
    {
        private readonly AdExpressWcfServiceClient _service;

        public AssociationController()
        {
           _service = new AdExpressWcfServiceClient();
        }
        // GET: /Association/
        public ActionResult Index()
        {
            var sources = _service.GetAllAssociations();
            var associations = Mapper.Map<Association[], AssociationViewModel[]>(sources);
            return View(associations);
        }

        // GET: /Association/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AssociationViewModel associationviewmodel = Mapper.Map<Association, AssociationViewModel>(_service.FindAssociation(id));
            if (associationviewmodel == null)
            {
                return HttpNotFound();
            }
            return View(associationviewmodel);
        }

        // GET: /Association/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Association/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,StarDateTime,EndDateTime,AdId,NewspaperId")] AssociationViewModel associationviewmodel)
        {
            if (ModelState.IsValid)
            {
                _service.AddAssociation(associationviewmodel.StarDateTime, associationviewmodel.EndDateTime, associationviewmodel.AdId, associationviewmodel.NewspaperId);
                return RedirectToAction("Index");
            }

            return View(associationviewmodel);
        }

        //// GET: /Association/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    AssociationViewModel associationviewmodel = db.AssociationViewModels.Find(id);
        //    if (associationviewmodel == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(associationviewmodel);
        //}

        //// POST: /Association/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include="ID,StarDateTime,EndDateTime")] AssociationViewModel associationviewmodel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(associationviewmodel).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(associationviewmodel);
        //}

        //// GET: /Association/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    AssociationViewModel associationviewmodel = db.AssociationViewModels.Find(id);
        //    if (associationviewmodel == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(associationviewmodel);
        //}

        //// POST: /Association/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    AssociationViewModel associationviewmodel = db.AssociationViewModels.Find(id);
        //    db.AssociationViewModels.Remove(associationviewmodel);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

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
