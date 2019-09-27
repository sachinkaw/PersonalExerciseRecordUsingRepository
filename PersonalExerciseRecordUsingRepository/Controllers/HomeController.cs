using PersonalExerciseRecordUsingRepository.Models;
using PersonalExerciseRecordUsingRepository.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalExerciseRecordUsingRepository.Controllers
{
    public class HomeController : Controller
    {
        private _IAllRepository<ExerciseRecord> interfaceObj;

        public HomeController()
        {
            this.interfaceObj = new AllRepository<ExerciseRecord>();
        }
        public ActionResult Index()
        {
            return View(from m in interfaceObj.GetAllExercises() select m);
        }
   
    

        [HttpPost]
        public ActionResult Create(string ExerciseName, DateTime ExerciseDate, int DurationInMinutes)
        {
            try
            {
                ExerciseRecord collection = new ExerciseRecord();

                collection.ExerciseName = ExerciseName;
                collection.ExerciseDate = ExerciseDate;
                collection.DurationInMinutes = DurationInMinutes;

                interfaceObj.InsertExerciseRecord(collection);
                interfaceObj.Save();

                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                return View();
            }
        }
    }
}