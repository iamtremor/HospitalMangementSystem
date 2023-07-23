using Hospital.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;



namespace YourProject.Controllers
{
    public class AppointmentController : Controller
    {
        public ActionResult Create()
        {
            var viewModel = new AppointmentViewModel
            {
                Providers = GetProvidersList()
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(AppointmentViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var appointment = new Appointment
                {
                    PatientId = viewModel.PatientId,
                    AppointmentDateTime = viewModel.AppointmentDateTime,
                    Notes = viewModel.Notes
                };
                TempDataStore.AddAppointment(appointment);
                return RedirectToAction("Details", new { id = appointment.AppointmentId });
            }
            viewModel.Providers = GetProvidersList();
            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            var appointment = TempDataStore.GetAppointmentById(id);
            

            return View(appointment);
        }


        private List<SelectListItem> GetProvidersList()
        {
            
            return new List<SelectListItem>
            {
                new SelectListItem { Value = "1", Text = "Tremorr" },
            };
        }

    }
}
