using Microsoft.AspNetCore.Mvc;
using TRINTY_ESTATES.Data;
using TRINTY_ESTATES.Models;

namespace TRINTY_ESTATES.Controllers
{
    public class RentListingsController : Controller
    {
        private readonly ApplicationDbContext _db;


        public RentListingsController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult RentListings()
        {
            IEnumerable<RentListingModel> objListings = _db.listings;
            return View(objListings);
        }

        

        [HttpPost]
        public IActionResult Create(RentListingModel model, List<IFormFile> images)
        {
            if (ModelState.IsValid)
            {
                model.Images = new List<byte[]>();

                if (images != null && images.Count > 0)
                {
                    foreach (var image in images)
                    {
                        if (image.Length > 0)
                        {
                            using (var stream = new MemoryStream())
                            {
                                image.CopyTo(stream);
                                model.Images.Add(stream.ToArray());
                            }
                        }
                    }
                }

                // Save the model...

                return RedirectToAction("RentListing");
            }

            return View(model);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(RentListingModel obj)
        {
           
            if (ModelState.IsValid)
            {
                _db.listings.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("RentListing");
            }
            return View(obj);

        }

        //Edit category
        //GET
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var listingsFromDb = _db.listings.Find(id);
            if (listingsFromDb == null)
            {
                return NotFound();
            }
            return View(listingsFromDb);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(RentListingModel obj)
        {
            
            if (ModelState.IsValid)
            {
                _db.listings.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("RentListing");
            }
            return View(obj);

        }

        //Delete category

        //GET
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var listingsFromDb = _db.listings.Find(id);
            if (listingsFromDb == null)
            {
                return NotFound();
            }
            return View(listingsFromDb);
        }

        //POST
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.listings.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.listings.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("RentListing");
        }
    }
}




    

       
