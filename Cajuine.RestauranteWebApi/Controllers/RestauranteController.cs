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
using Cajuine.DataAccess.Contexts;
using Cajuine.DomainModel.Entities;
using Cajuine.RestauranteWebApi.Models;

namespace Cajuine.RestauranteWebApi.Controllers
{
    public class RestauranteController : ApiController
    {
        private SocialNetworkContext db = new SocialNetworkContext();

        // GET: api/Restaurante
        public IQueryable<RestauranteViewModel> GetPosts()
        {
            return db.Posts.Where(p => p.PostType == PostTypeEnum.Restaurante).Select(p => new RestauranteViewModel
            {
                Content = p.Content,
            });
        }

        // GET: api/Restaurante/5
        [ResponseType(typeof(RestauranteViewModel))]
        public async Task<IHttpActionResult> GetPost(Guid id)
        {
            Post post = await db.Posts.FirstOrDefaultAsync(p => p.Id == id && p.PostType == PostTypeEnum.Restaurante);
            if (post == null)
            {
                return NotFound();
            }

            var RestaurantePost = new RestauranteViewModel
            {
                Content = post.Content,
            };
            return Ok(RestaurantePost);
        }

        // PUT: api/Restaurante/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPost(Guid id, Post post)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != post.Id)
            {
                return BadRequest();
            }

            db.Entry(post).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PostExists(id))
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

        // POST: api/Restaurante
        [ResponseType(typeof(RestauranteViewModel))]
        public async Task<IHttpActionResult> PostPost(Post post)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Posts.Add(post);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PostExists(post.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            var restaurantePost = new RestauranteViewModel
            {
                Content = post.Content,
            };

            return CreatedAtRoute("DefaultApi", new { id = restaurantePost.Id }, restaurantePost);
        }

        // DELETE: api/Restaurante/5
        [ResponseType(typeof(Post))]
        public async Task<IHttpActionResult> DeletePost(Guid id)
        {
            Post post = await db.Posts.FindAsync(id);
            if (post == null)
            {
                return NotFound();
            }

            db.Posts.Remove(post);
            await db.SaveChangesAsync();

            return Ok(post);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PostExists(Guid id)
        {
            return db.Posts.Count(e => e.Id == id) > 0;
        }
    }
}