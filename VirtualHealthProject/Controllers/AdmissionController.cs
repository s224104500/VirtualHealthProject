using Microsoft.AspNetCore.Mvc;
using VirtualHealthProject.Models; // Adjust the namespace as necessary
using VirtualHealthProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Net;

namespace VirtualHealthProject.Controllers
{
    public class AdmissionController : Controller
    {
        private readonly VirtualHealthDbContext _context;

        public AdmissionController(VirtualHealthDbContext context)
        {
            _context = context;
        }

        // GET: Admissions
        public async Task<IActionResult> Index()
        {
            var admits = await _context.Admissions
                .Include(a => a.Patient) 
                .ToListAsync(); 

            var admission = admits.Select(admit => new AdmissionViewModel
            {
                PatientID = admit.PatientID,
                PatientName = admit.Patient.FirstName + " " + admit.Patient.LastName,
                AdmissionDate = admit.AdmissionDate,
                Status = "Admitted"
            }).ToList();

            return View(admission);
        }

        public IActionResult Details(int id)
        {

            if (id < 1)
            {
                id = 1; 
            }
            var admission = _context.Admissions
                .Where(a => a.AdmissionId == id) 
                .Select(a => new AdmissionViewModel
                {
                    PatientID = a.PatientID,
                    PatientName = a.PatientName,
                    AdmissionDate = a.AdmissionDate,
                    Status = a.Status
                })
                .FirstOrDefault();

            if (admission == null)
            {
                return NotFound();
            }

            return View(admission);
        }
    
        // GET: Admission/Create
        public async Task<IActionResult> Create()
        {
            var model = new AdmissionViewModel
            {
                PatientOptions = await _context.Patients
                    .Select(p => new SelectListItem
                    {
                        Value = p.PatientID.ToString(),
                        Text = $"{p.FirstName} {p.LastName}"
                    }).ToListAsync()
            };

            return View(model);
        }


        // POST: Admission/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AdmissionViewModel model)
        {

            var patient = await _context.Patients.FindAsync(model.SelectedPatientID);
            if (patient == null)
            {
                ModelState.AddModelError("", "Selected patient not found.");
                return await PopulateDropdowns(model);

            }
            var admit = new Admission
            {
                PatientID = model.SelectedPatientID,
                AdmissionDate = model.AdmissionDate,
                PatientName = $"{patient.FirstName} {patient.LastName}",
                Status = "Admitted"
            };

            await _context.Admissions.AddAsync(admit);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index"); 

        }

        private async Task<IActionResult> PopulateDropdowns(AdmissionViewModel model)
        {

            model.PatientOptions = await _context.Patients
             .Select(p => new SelectListItem
             {
                 Value = p.PatientID.ToString(),
                 Text = $"{p.FirstName} {p.LastName}"
             }).ToListAsync();

            return View(model);
        }

        
        public async Task<IActionResult> Edit(int id)
        {

            if (id < 1)
            {
                id = 1;
            }

            var admission = await _context.Admissions.FindAsync(id);
            if (admission == null)
            {
                return NotFound();
            }

            var model = new AdmissionViewModel
            {
                AdmissionId = admission.AdmissionId, 
                PatientID = admission.PatientID,
                PatientName = admission.PatientName,
                AdmissionDate = admission.AdmissionDate,
                Status = admission.Status
            };

            return View(model);
        }

        // POST: Admissions/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(AdmissionViewModel model)
        {
            if (ModelState.IsValid)
            {
                var admission = await _context.Admissions.FindAsync(model.AdmissionId);
                if (admission == null)
                {
                    return NotFound();
                }

                // Update the admission record
                admission.PatientID = model.PatientID;
                admission.PatientName = model.PatientName; 
                admission.AdmissionDate = model.AdmissionDate;
                admission.Status = model.Status;

                _context.Update(admission);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index)); 
            }

            return View(model); 
        }

        // GET: Admission/Delete/1
        public IActionResult Delete(int id)
        {

            if (id < 1)
            {
                id = 1; 
            }
            var admission = _context.Admissions
                .Where(a => a.AdmissionId == id)
                .Select(a => new AdmissionViewModel
                {
                    AdmissionId = a.AdmissionId,
                    PatientID = a.PatientID,
                    PatientName = a.PatientName,
                    AdmissionDate = a.AdmissionDate,
                    Status = a.Status
                })
                .FirstOrDefault();

            if (admission == null)
            {
                return NotFound();
            }

            return View(admission); 
        }

        // POST: Admission/Delete
        [HttpPost]
        public IActionResult DeleteConfirmed(int admissionId) 
        {
            var admission = _context.Admissions.Find(admissionId);

            if (admission == null)
            {
                return NotFound();
            }

            _context.Admissions.Remove(admission);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}


       

