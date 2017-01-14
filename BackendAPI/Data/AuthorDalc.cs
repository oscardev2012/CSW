using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Data.Entity;
using BackendAPI.DTOs;
using System.Data.Entity.Infrastructure;
namespace BackendAPI.Data
{
    /// <summary>
    /// Author Dalc Class
    /// </summary>
    public class AuthorDalc
    {

        #region Async

        /// <summary>
        /// Insert Author
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<int> InsertAsync(string name)
        {
            try
            {
                using (TestSGSEntities db = new TestSGSEntities())
                {
                    Author obj = new Author();
                    obj.Name = name;
                    db.Authors.Add(obj);
                    return await db.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        /// <summary>
        /// Delete Author Async
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<int> DeleteAsync(int id)
        {
            try
            {
                using (TestSGSEntities db = new TestSGSEntities())
                {
                    Author obj = (db.Authors.Where(s => s.Id == id)).SingleOrDefault();
                    db.Authors.Remove(obj);
                    return await db.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                if (ex.GetType().Equals(typeof(DbUpdateException)))
                {
                    throw new Exception("Delete");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        /// <summary>
        /// Update Author Async
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<int> UpdateAsync(int id, string name)
        {
            try
            {
                using (TestSGSEntities db = new TestSGSEntities())
                {
                    Author obj = (db.Authors.Where(s => s.Id == id)).SingleOrDefault();
                    obj.Name = name;
                    db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                    return await db.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Get All Author
        /// </summary>
        /// <returns></returns>
        public async Task<List<Author>> GetAllAsync()
        {
            try
            {
                TestSGSEntities db = new TestSGSEntities();
                var query = from c in db.Authors
                         
                            select c;
                List<Author> obj = await query.ToListAsync();
                return obj   ;
                

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion

    }
}
