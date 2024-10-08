﻿using Agent_Management_Client.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Agent_Management_Client.Controllers
{
    public class MissionController : Controller
    {
        private readonly HttpClient _httpClient;

        public MissionController (HttpClient httpClient) 
        {
            _httpClient = httpClient;
        }

        // GET: MissionController


        public async Task<IActionResult> Index()
        {
            var res = await _httpClient.GetStringAsync("http://localhost:5120/missions");
            var respons = JsonConvert.DeserializeObject<List<Mission>>(res);
            return View(respons);
        }

        // GET: MissionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MissionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MissionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MissionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MissionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MissionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MissionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
