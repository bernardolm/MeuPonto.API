﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MeuPonto.Models;
using MeuPonto.DAL;

namespace MeuPonto.WebAPI.Controllers
{
	public class DiasTrabalhoController : Controller
	{
		private Contexto db = new Contexto();

		// GET: /Dias/
		public ActionResult Index()
		{
			return View(db.DiasTrabalho.ToList());
		}

		// GET: /Dias/Details/5
		public ActionResult Details(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			DiaTrabalho diatrabalho = db.DiasTrabalho.Find(id);
			if (diatrabalho == null)
			{
				return HttpNotFound();
			}
			return View(diatrabalho);
		}

		// GET: /Dias/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: /Dias/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create([Bind(Include = "Id,Entrada,IntervaloSaida,IntervaloRetorno,Saida,IntervaloExtraSaida,IntervaloExtraRetorno")] DiaTrabalho diatrabalho)
		{
			if (ModelState.IsValid)
			{
				db.DiasTrabalho.Add(diatrabalho);
				db.SaveChanges();
				return RedirectToAction("Index");
			}

			return View(diatrabalho);
		}

		// GET: /Dias/Edit/5
		public ActionResult Edit(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			DiaTrabalho diatrabalho = db.DiasTrabalho.Find(id);
			if (diatrabalho == null)
			{
				return HttpNotFound();
			}
			return View(diatrabalho);
		}

		// POST: /Dias/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit([Bind(Include = "Id,Entrada,IntervaloSaida,IntervaloRetorno,Saida,IntervaloExtraSaida,IntervaloExtraRetorno")] DiaTrabalho diatrabalho)
		{
			if (ModelState.IsValid)
			{
				db.Entry(diatrabalho).State = EntityState.Modified;
				db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(diatrabalho);
		}

		// GET: /Dias/Delete/5
		public ActionResult Delete(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			DiaTrabalho diatrabalho = db.DiasTrabalho.Find(id);
			if (diatrabalho == null)
			{
				return HttpNotFound();
			}
			return View(diatrabalho);
		}

		// POST: /Dias/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public ActionResult DeleteConfirmed(int id)
		{
			DiaTrabalho diatrabalho = db.DiasTrabalho.Find(id);
			db.DiasTrabalho.Remove(diatrabalho);
			db.SaveChanges();
			return RedirectToAction("Index");
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				db.Dispose();
			}
			base.Dispose(disposing);
		}
	}
}
