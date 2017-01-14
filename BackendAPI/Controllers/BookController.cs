using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using BackendAPI.Data;
using System.Threading.Tasks;
using BackendAPI.DTOs;
using System.Web.Http;
using System.Net.Http;
using System.Net;

namespace BackendAPI.Controllers
{
    /// <summary>
    /// Book Controller Class
    /// </summary>
    public class BookController : ApiController
    {


        #region  CRUD
        // GET api/book

        public IEnumerable<DTOBook> GetAll()
        {
            try
            {
                Task<IEnumerable<DTOBook>> resultAsync = Task.Run<IEnumerable<DTOBook>>(async () => await new BookDalc().GetAllAsync());
                return resultAsync.Result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
        [System.Web.Http.HttpOptions]
        public HttpResponseMessage Options()
        {
            var resp = new HttpResponseMessage(HttpStatusCode.OK);
            return resp;
        }


        // GET api/book
        public IEnumerable<Book> GetBookByAuthor(int authorId)
        {
            try
            {
                using (TestSGSEntities db = new TestSGSEntities())
                {
                    return db.Books.Where(e => e.AuthorId == authorId).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }


        // GET api/book
        public IEnumerable<Book> GetBookByCategoryId(int categoryId)
        {
            try
            {
                using (TestSGSEntities db = new TestSGSEntities())
                {
                    return db.Books.Where(e => e.CategoryId == categoryId).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }


        // PUT api/book
        public int Update(int id, string name, int authorId, int categoryId)
        {
            try
            {
                Task<int> resultAsync = Task.Run<int>(async () => await new BookDalc().UpdateAsync(id, name, authorId, categoryId));
                return resultAsync.Result;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }


        // DELETE api/book

        public int Remove(int id)
        {
            try
            {
                Task<int> resultAsync = Task.Run<int>(async () => await new BookDalc().DeleteAsync(id));
                return resultAsync.Result;


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }


        // INSERT api/book
        public int Insert(string name, int authorId, int categoryId)
        {
            try
            {
                Task<int> resultAsync = Task.Run<int>(async () => await new BookDalc().InsertAsync(name, authorId, categoryId));
                return resultAsync.Result;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }


        #endregion

    }
}
