using ShoeShopMVCAdmin.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace ShoeShopMVCAdmin.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin

        private AdminContext _db = new AdminContext();



        public ActionResult Dashboard()
        {

            return View();
        }


       
        //-------------------------------------------------------BRAND----------------------------------------
        public ActionResult BrandList()
        {
            return View(_db.tblBrands.ToList());
        }


        public ActionResult CreateBrand()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateBrand(tblBrand t)
        {
            if (ModelState.IsValid)
            {
                _db.tblBrands.Add(t);
                _db.SaveChanges();
                return RedirectToAction("BrandList");
            }

            return View(t);
        }


        public ActionResult EditBrand(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblBrand tblBrand = _db.tblBrands.Find(id);
            if (tblBrand == null)
            {
                return HttpNotFound();
            }
            return View(tblBrand);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditBrand(tblBrand t)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(t).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("BrandList");
            }
            return View(t);
        }


        public ActionResult DeleteBrand(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblBrand t = _db.tblBrands.Find(id);

            if (t != null)
            {
                _db.tblBrands.Remove(t);
                _db.SaveChanges();
                return RedirectToAction("BrandList");
            }
            else
            {
                return View("BrandList");
            }
        }


        //---------------------------------------------Category-------------------------------------------


        public ActionResult CategoryList()
        {
            return View(_db.tblCategories.ToList());
        }


        public ActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateCategory(tblCategory t)
        {
            if (ModelState.IsValid)
            {
                _db.tblCategories.Add(t);
                _db.SaveChanges();
                return RedirectToAction("CategoryList");
            }

            return View(t);
        }


        public ActionResult EditCategory(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblCategory t = _db.tblCategories.Find(id);
            if (t == null)
            {
                return HttpNotFound();
            }
            return View(t);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditCategory(tblCategory t)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(t).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("CategoryList");
            }
            return View(t);
        }


        public ActionResult DeleteCategory(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblCategory t = _db.tblCategories.Find(id);

            if (t != null)
            {
                _db.tblCategories.Remove(t);
                _db.SaveChanges();
                return RedirectToAction("CategoryList");
            }
            else
            {
                return View("CategoryList");
            }
        }


        //--------------------------------------------------Size----------------------------------------

        public ActionResult SizeList()
        {
            return View(_db.tblSizes.ToList());
        }


        public ActionResult CreateSize()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateSize(tblSize t)
        {
            if (ModelState.IsValid)
            {
                _db.tblSizes.Add(t);
                _db.SaveChanges();
                return RedirectToAction("SizeList");
            }

            return View(t);
        }


        public ActionResult EditSize(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblSize t = _db.tblSizes.Find(id);
            if (t == null)
            {
                return HttpNotFound();
            }
            return View(t);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditSize(tblSize t)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(t).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("SizeList");
            }
            return View(t);
        }


        public ActionResult DeleteSize(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblSize t = _db.tblSizes.Find(id);

            if (t != null)
            {
                _db.tblSizes.Remove(t);
                _db.SaveChanges();
                return RedirectToAction("SizeList");
            }
            else
            {
                return View("SizeList");
            }
        }

        //-------------------------------------------------Gender------------------------------------------

        public ActionResult GenderList()
        {
            return View(_db.tblGenders.ToList());
        }


        public ActionResult CreateGender()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateGender(tblGender t)
        {
            if (ModelState.IsValid)
            {
                _db.tblGenders.Add(t);
                _db.SaveChanges();
                return RedirectToAction("GenderList");
            }
            return View(t);
        }


        public ActionResult EditGender(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblGender t = _db.tblGenders.Find(id);
            if (t == null)
            {
                return HttpNotFound();
            }
            return View(t);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditGender(tblGender t)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(t).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("GenderList");
            }
            return View(t);
        }


        public ActionResult DeleteGender(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblGender t = _db.tblGenders.Find(id);

            if (t != null)
            {
                _db.tblGenders.Remove(t);
                _db.SaveChanges();
                return RedirectToAction("GenderList");
            }
            else
            {
                return View("GenderList");
            }
        }

        //-----------------------------------------Product---------------------------------------------


        public ActionResult ProductList()
        {
            var tblProducts = _db.tblProducts.Include(t => t.tblBrand).Include(t => t.tblCategory).Include(t => t.tblGender).Include(t => t.tblSize);
            return View(tblProducts.ToList());
        }


        public ActionResult CreateProduct()
        {
            ViewBag.BrandId = new SelectList(_db.tblBrands, "BrandId", "BrandName");
            ViewBag.CategoryId = new SelectList(_db.tblCategories, "CategoryId", "CategoryName");
            ViewBag.GenderId = new SelectList(_db.tblGenders, "GenderId", "GenderType");
            ViewBag.SizeId = new SelectList(_db.tblSizes, "SizeId", "SizeNumber");
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateProduct(tblProduct t)
        {
            if (ModelState.IsValid == true)
            {
                string myfile = Path.GetFileNameWithoutExtension(t.myImg.FileName);
                string extention = Path.GetExtension(t.myImg.FileName);
                HttpPostedFileBase postfile = t.myImg;
                int length = postfile.ContentLength;
                if (extention.ToLower() == ".jpg" || extention.ToLower() == ".png")
                {
                    if (length <= 1000000)
                    {
                        myfile = myfile + extention;

                        t.ProdImage = "~/Images/" + myfile;
                        myfile = Path.Combine(Server.MapPath("~/Images/"), myfile);
                        t.myImg.SaveAs(myfile);
                        _db.tblProducts.Add(t);
                        int a = _db.SaveChanges();
                        if (a > 0)
                        {
                            TempData["Insmess"] = "Data Inserted Successfully";
                            ModelState.Clear();
                            return RedirectToAction("ProductList");
                        }
                        else
                        {
                            TempData["Insmess"] = "Data Not Inserted";
                        }
                    }
                    else
                    {
                        TempData["lengthmess"] = "Length is more than 1 mb";
                    }
                }
                else
                {
                    TempData["extentionMess"] = "Invalid Extention";
                }
            }

            ViewBag.BrandId = new SelectList(_db.tblBrands, "BrandId", "BrandName", t.BrandId);
            ViewBag.CategoryId = new SelectList(_db.tblCategories, "CategoryId", "CategoryName", t.CategoryId);
            ViewBag.GenderId = new SelectList(_db.tblGenders, "GenderId", "GenderType", t.GenderId);
            ViewBag.SizeId = new SelectList(_db.tblSizes, "SizeId", "SizeNumber", t.SizeId);
            return View(t);

        }



        public ActionResult EditProduct(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblProduct tblProduct = _db.tblProducts.Find(id);
            if (tblProduct == null)
            {
                return HttpNotFound();
            }

            Session["imgprev"] = tblProduct.ProdImage;

            ViewBag.BrandId = new SelectList(_db.tblBrands, "BrandId", "BrandName", tblProduct.BrandId);
            ViewBag.CategoryId = new SelectList(_db.tblCategories, "CategoryId", "CategoryName", tblProduct.CategoryId);
            ViewBag.GenderId = new SelectList(_db.tblGenders, "GenderId", "GenderType", tblProduct.GenderId);
            ViewBag.SizeId = new SelectList(_db.tblSizes, "SizeId", "SizeNumber", tblProduct.SizeId);
            return View(tblProduct);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditProduct(tblProduct t)
        {
            if (ModelState.IsValid == true)
            {
                if (t.myImg != null)
                {
                    string myfile = Path.GetFileNameWithoutExtension(t.myImg.FileName);
                    string extention = Path.GetExtension(t.myImg.FileName);
                    HttpPostedFileBase postfile = t.myImg;
                    int length = postfile.ContentLength;
                    if (extention.ToLower() == ".jpg" || extention.ToLower() == ".png")
                    {
                        if (length <= 1000000)
                        {
                            myfile = myfile + extention;
                            t.ProdImage = "~/Images/" + myfile;
                            myfile = Path.Combine(Server.MapPath("~/Images/"), myfile);
                            t.myImg.SaveAs(myfile);
                            _db.Entry(t).State = EntityState.Modified;
                            int a = _db.SaveChanges();
                            if (a > 0)
                            {
                                string delimgPath = Request.MapPath(Session["imgprev"].ToString());
                                if (System.IO.File.Exists(delimgPath))
                                {
                                    System.IO.File.Delete(delimgPath);
                                }
                                TempData["Updatemess"] = "Data Updated Successfully";
                                ModelState.Clear();
                                return RedirectToAction("ProductList");
                            }
                            else
                            {
                                TempData["Updatemess"] = "Data Not Updated";
                            }
                        }
                        else
                        {
                            TempData["lengthmess"] = "Length is more than 1 mb";
                        }
                    }
                    else
                    {
                        TempData["extentionMess"] = "Invalid Extention";
                    }
                }
                else
                {
                    t.ProdImage = Session["imgprev"].ToString();
                    _db.Entry(t).State = EntityState.Modified;
                    int a = _db.SaveChanges();
                    if (a > 0)
                    {
                        TempData["Updatemess"] = "Data Updated Successfully";
                        ModelState.Clear();
                        return RedirectToAction("ProductList");
                    }
                    else
                    {
                        TempData["Updatemess"] = "Data Not Updated";
                    }
                }
            }
            ViewBag.BrandId = new SelectList(_db.tblBrands, "BrandId", "BrandName", t.BrandId);
            ViewBag.CategoryId = new SelectList(_db.tblCategories, "CategoryId", "CategoryName", t.CategoryId);
            ViewBag.GenderId = new SelectList(_db.tblGenders, "GenderId", "GenderType", t.GenderId);
            ViewBag.SizeId = new SelectList(_db.tblSizes, "SizeId", "SizeNumber", t.SizeId);
            return View(t);

        }


        public ActionResult DeleteProduct(int id)
        {

            if (id > 0)
            {

                var deldata = _db.tblProducts.Where(x => x.ProdId == id).FirstOrDefault();

                if (deldata != null)
                {
                    _db.Entry(deldata).State = EntityState.Deleted;
                    _db.SaveChanges();

                    //Deleteing Images from Folder
                    string delimgPath = Request.MapPath(deldata.ProdImage).ToString();

                    if (System.IO.File.Exists(delimgPath))
                    {
                        System.IO.File.Delete(delimgPath);
                    }
                    TempData["delProd"] = "Product Deleted Successfully";
                }

            }
            return RedirectToAction("ProductList");
        }


    }
}