using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using RentaCars.EN;

namespace RentaCarWEBAPI.Controllers
{
    public class RentasController : ApiController
    {
        private Modelo db = new Modelo();

        // GET: api/Rentas
        public IQueryable<Renta> GetRenta()
        {
            return db.Renta;
        }

        // GET: api/Rentas/5
        [ResponseType(typeof(Renta))]
        public async Task<IHttpActionResult> GetRenta(int id)
        {
            Renta renta = await db.Renta.FindAsync(id);
            if (renta == null)
            {
                return NotFound();
            }

            return Ok(renta);
        }

        // PUT: api/Rentas/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutRenta(int id, Renta renta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != renta.RentaID)
            {
                return BadRequest();
            }

            db.Entry(renta).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RentaExists(id))
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

        // POST: api/Rentas
        [ResponseType(typeof(Renta))]
        public async Task<IHttpActionResult> PostRenta(Renta renta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Renta.Add(renta);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = renta.RentaID }, renta);
        }

        // DELETE: api/Rentas/5
        [ResponseType(typeof(Renta))]
        public async Task<IHttpActionResult> DeleteRenta(int id)
        {
            Renta renta = await db.Renta.FindAsync(id);
            if (renta == null)
            {
                return NotFound();
            }

            db.Renta.Remove(renta);
            await db.SaveChangesAsync();

            return Ok(renta);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RentaExists(int id)
        {
            return db.Renta.Count(e => e.RentaID == id) > 0;
        }
    }
}