using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using BackendAPI.Data;
using System.Threading.Tasks;

namespace BackendAPI.Controllers
{
    /// <summary>
    /// Author Controller Class
    /// </summary>
    public class AuthorController : ApiController
    {

        #region CRUD
        // GET: /Author/
        public IEnumerable<Author> GetAll()
        {
            try
            {
                Task<IEnumerable<Author>> resultAsync = Task.Run<IEnumerable<Author>>(async () => await new AuthorDalc().GetAllAsync());
                return resultAsync.Result;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        // UPDATE: /Author/
        public int Update(int id, string name)
        {
            try
            {
                Task<int> resultAsync = Task.Run<int>(async () => await new AuthorDalc().UpdateAsync(id,name));
                return resultAsync.Result;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        // DELETE: /Author/
        public int Delete(int id)
        {
            try
            {
                Task<int> resultAsync = Task.Run<int>(async () => await new AuthorDalc().DeleteAsync(id));
                return resultAsync.Result;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.InnerException.Message);
            }
        }


        // INSERT: /Author/
        public int Insert(string name)
        {
            try
            {
                Task<int> resultAsync = Task.Run<int>(async () => await new AuthorDalc().InsertAsync( name));
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
