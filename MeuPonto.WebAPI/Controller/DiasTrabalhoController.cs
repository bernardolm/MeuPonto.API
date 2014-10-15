using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using MeuPonto.DAL;
using MeuPonto.Models;

namespace MeuPonto.WebAPI.Controller
{
    public class DiasTrabalhoController : ApiController
    {
        private Contexto db = new Contexto();

        // GET: api/DiasTrabalho
        public IQueryable<DiaTrabalho> GetDiasTrabalho()
        {
            return db.DiasTrabalho;
        }

        // GET: api/DiasTrabalho/5
        [ResponseType(typeof(DiaTrabalho))]
        public IHttpActionResult GetDiaTrabalho(int id)
        {
            DiaTrabalho diaTrabalho = db.DiasTrabalho.Find(id);
            if (diaTrabalho == null)
            {
                return NotFound();
            }

            return Ok(diaTrabalho);
        }

        // PUT: api/DiasTrabalho/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDiaTrabalho(int id, DiaTrabalho diaTrabalho)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != diaTrabalho.Id)
            {
                return BadRequest();
            }

            db.Entry(diaTrabalho).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DiaTrabalhoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/DiasTrabalho
        [ResponseType(typeof(DiaTrabalho))]
        public IHttpActionResult PostDiaTrabalho(DiaTrabalho diaTrabalho)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.DiasTrabalho.Add(diaTrabalho);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = diaTrabalho.Id }, diaTrabalho);
        }

        // DELETE: api/DiasTrabalho/5
        [ResponseType(typeof(DiaTrabalho))]
        public IHttpActionResult DeleteDiaTrabalho(int id)
        {
            DiaTrabalho diaTrabalho = db.DiasTrabalho.Find(id);
            if (diaTrabalho == null)
            {
                return NotFound();
            }

            db.DiasTrabalho.Remove(diaTrabalho);
            db.SaveChanges();

            return Ok(diaTrabalho);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DiaTrabalhoExists(int id)
        {
            return db.DiasTrabalho.Count(e => e.Id == id) > 0;
        }
    }
}