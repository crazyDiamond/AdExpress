using System.Net;
using System.Web.Mvc;
using AdExpress.AdExpressWcfService;
using AdExpress.Models;
using AutoMapper;

namespace AdExpress.Controllers
{
    public class AdController : Controller
    {
        private readonly AdExpressWcfServiceClient _service;

        public AdController()
        {
            _service = new AdExpressWcfServiceClient();
        }

        // GET: /Ads/
        public ActionResult Index()
        {
            //TODO : Does this method have to return a list?
            var sources =  _service.GetAllAdsList();
            var ads = Mapper.Map<Ad[], AdViewModel[]>(sources);
           
            return View(ads);
        }

        

        // GET: /Ads/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ad ad = _service.FindAd(id);
            if (ad == null)
            {
                return HttpNotFound();
            }
            var advm = Mapper.Map<Ad, AdViewModel>(ad);
            return View(advm);
        }

        // GET: /Ads/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Ads/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ID,Title,Version")] AdViewModel adViewModel)
        {
            if (ModelState.IsValid)
            {
                _service.AddAd(adViewModel.Title, adViewModel.Version);
                return RedirectToAction("Index");
            }

            return View(adViewModel);
        }

        // GET: /Ads/Edit/5
     public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdViewModel adViewModel = Mapper.Map<Ad, AdViewModel>(_service.FindAd(id));
            if (adViewModel == null)
            {
                return HttpNotFound();
            }
            return View(adViewModel);
        }

        // POST: /Ads/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
       [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ID,Title,Version")] AdViewModel adViewModel)
        {
            if (ModelState.IsValid)
            {
                Ad ad = Mapper.Map<AdViewModel, Ad>(adViewModel);
                _service.SaveAd(ad);
                return RedirectToAction("Index");
            }
            return View(adViewModel);
        }

        // GET: /Ads/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdViewModel adViewModel = Mapper.Map<Ad, AdViewModel>(_service.FindAd(id));
            if (adViewModel == null)
            {
                return HttpNotFound();
            }
            return View(adViewModel);
        }

        // POST: /Ads/Delete/5
       [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _service.RemoveAd(_service.FindAd(id));
            return RedirectToAction("Index");
        }

        //TODO: Do I need to dispose of the service object?
        /* protected override void Dispose(bool disposing)
         {
             if (disposing)
             {
                 db.Dispose();
             }
             base.Dispose(disposing);
         }*/
    }
}
