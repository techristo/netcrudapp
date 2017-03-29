using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace workshop.Controllers
{
    public class EmployeeController : Controller
    {
        workshopDBContainer db = new workshopDBContainer();
        // GET: Employee
        public ActionResult Index()
        {
            return View(db.EmployeesSet.ToList());
        }
        // Get: create view
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection fc)
        {
            string nom = fc["name"];
            string departementt = fc["departement"];
            int salairee = Convert.ToInt32(fc["salaire"]);

            Employees E = new Employees{name = nom, departement = departementt, salaire = salairee};

            db.EmployeesSet.Add(E);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {    
            return View(db.EmployeesSet.Find(id));
        }
        
        [HttpPost]
        public ActionResult Edit(int id, FormCollection fc)
        {
         
                Employees E = db.EmployeesSet.Find(id);
                E.name = fc["name"];
                E.departement = "ppppp";
                E.salaire = Convert.ToInt32(fc["salaire"]);
                db.Entry(E).State=EntityState.Modified;
               
                db.SaveChanges();
 
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            Employees E = db.EmployeesSet.Find(id);
            //db.EmployeesSet.Attach(E);
            db.EmployeesSet.Remove(E);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}