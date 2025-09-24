using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RoseMountainBandWebsite.Data;
using RoseMountainBandWebsite.Models;
using RoseMountainBandWebsite.ViewModel;

namespace RoseMountainBandWebsite.Controllers
{
    public class ToursController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ToursController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Tours
        public async Task<IActionResult> Index()
        {
            List<Tour> Tours = await _context.Tour.ToListAsync();
            List<Concert> Concerts = await _context.Concert.ToListAsync();
            return View(packageToursAndConcertsIntoViewModel(Tours, Concerts));
        }

        private TourConcertViewModel packageToursAndConcertsIntoViewModel(List<Tour> Tours, List<Concert> Concerts)
        {
            TourConcertViewModel TCVM = new TourConcertViewModel();
            TCVM.Tours = Tours;
            foreach (Tour Tour in Tours)
            {
                List<Concert> ConcertsForCurrentTour = new List<Concert>();
                foreach (Concert Concert in Concerts)
                {
                    if (Concert.TourId == Tour.Id)
                    {
                        ConcertsForCurrentTour.Add(Concert);
                    }
                }

                TCVM.Concerts.Add(ConcertsForCurrentTour);
            }
            return TCVM;
        }

        // GET: Tours/Details/5
        /*public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tour = await _context.Tour
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tour == null)
            {
                return NotFound();
            }

            return View(tour);
        }*/

        // GET: Tours/Create
        /*public IActionResult Create()
        {
            return View();
        }*/

        // GET: Tours/Create
        public async Task<IActionResult> Create()
        {
            List<Tour> Tours = await _context.Tour.ToListAsync();
            List<Concert> Concerts = await _context.Concert.ToListAsync();
            return View(packageToursAndConcertsIntoViewModel(Tours, Concerts));
        }


        // POST: Tours/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NewTour.Id, NewTour.StartDate, NewTour.EndDate, NewTour.Name, NewTour.Description")] TourConcertViewModel TCVM)
        {
            if (ModelState.IsValid)
            {
                _context.Add(TCVM.NewTour);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Create));
            }

            return View(TCVM);
        }

        // GET: Tours/Edit/5
        /*public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tour = await _context.Tour.FindAsync(id);
            if (tour == null)
            {
                return NotFound();
            }
            return View(tour);
        }*/

        // POST: Tours/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        /*[HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,StartDate,EndDate,Name,Description")] Tour tour)
        {
            if (id != tour.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tour);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TourExists(tour.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(tour);
        }*/

        // POST: Tours/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddConcertToTour(int TourId, [Bind("NewlySubmittedConcert.Id, NewlySubmittedConcert.TourId, NewlySubmittedConcert.Location, NewlySubmittedConcert.Date, NewlySubmittedConcert.Description")] TourConcertViewModel TCVMWithNewConcert)
        {

            if (TourId != TCVMWithNewConcert.NewConcert.TourId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //TourConcertViewModel TCVM = await _context.TCVM.FindAsync(TourId);
                    //TCVM.Concerts.Add(TCVMWithNewConcert.NewlySubmittedConcert);
                    //TCVM.Concerts.Add(TCVMWithNewConcert.NewlySubmittedConcert);


                    _context.Update(TCVMWithNewConcert.NewConcert);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TourExists(TCVMWithNewConcert.NewConcert.TourId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            List<Tour> Tours = await _context.Tour.ToListAsync();
            List<Concert> Concerts = await _context.Concert.ToListAsync();
            return View(packageToursAndConcertsIntoViewModel(Tours, Concerts));
        }

        // GET: Tours/Delete/5
        /*public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tour = await _context.Tour
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tour == null)
            {
                return NotFound();
            }

            return View(tour);
        }

        // POST: Tours/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tour = await _context.Tour.FindAsync(id);
            if (tour != null)
            {
                _context.Tour.Remove(tour);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }*/

        private bool TourExists(int TourId)
        {
            return _context.Tour.Any(e => e.Id == TourId);
        }
    }
}
