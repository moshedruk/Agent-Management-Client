﻿using Agent_Management_Client.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;

namespace Agent_Management_Client.Controllers
{
    public class Mission_UpdeteController : Controller
    {
        private readonly HttpClient _httpClient;

        public Mission_UpdeteController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // GET: Mission_UpdeteController
        public async Task<IActionResult> Index()
        {
            var res = await _httpClient.GetStringAsync("http://localhost:5120/missions/get_Missions");
            
            List<modleMission> respons = JsonConvert.DeserializeObject<List<modleMission>>(res);            

            return View(respons);
        }

        // GET: Mission_UpdeteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Mission_UpdeteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mission_UpdeteController/Create
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

        // GET: Mission_UpdeteController/Edit/5
       
        public async Task<IActionResult> Edit(int id)
        {
            var bodycontent = new { token = "updete", status = "assigned" };
            var content = JsonContent.Create(bodycontent);
            await _httpClient.PutAsync($"http://localhost:5120/missions/{id}", content);

            return RedirectToAction("Index");
        }

        // POST: Mission_UpdeteController/Edit/5
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

        // GET: Mission_UpdeteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Mission_UpdeteController/Delete/5
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
