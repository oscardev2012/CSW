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
    /// Category Controller Class
    /// </summary>
    public class CategoryController : ApiController
    {

        #region CRUD

        // GET: /CATEGORY/
        public IEnumerable<Category> GetAll()
        {
            try
            {
                 Task<IEnumerable<Category>> resultAsync = Task.Run<IEnumerable<Category>>(async () => await new CategoryDalc().GetAllAsync());
                return resultAsync.Result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }



        // PUT api/CATEGORY
        public int Update(int id, string name)
        {
            try
            {
                Task<int> resultAsync = Task.Run<int>(async () => await new CategoryDalc().UpdateAsync(id,name));
                return resultAsync.Result;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }


        // DELETE api/CATEGORY
        public int Remove(int id)
        {
            try
            {
               Task<int> resultAsync = Task.Run<int>(async () => await new CategoryDalc().DeleteAsync(id));
                return resultAsync.Result;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.InnerException.Message);
            }

        }


        // INSERT api/CATEGORY
        public int Insert(string name)
        {
            try
            {
                Task<int> resultAsync = Task.Run<int>(async () => await new CategoryDalc().InsertAsync(name));
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
