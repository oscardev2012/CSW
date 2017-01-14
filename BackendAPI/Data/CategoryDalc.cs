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
    /// Category Dalc Class
    /// </summary>
    public class CategoryDalc
    {

        #region Async

        /// <summary>
        /// Get All Category Async
        /// </summary>
        /// <returns></returns>
        public async Task<List<Category>> GetAllAsync()
        {
            try
            {
                using (TestSGSEntities db = new TestSGSEntities())
                {
                    return db.Categories.ToListAsync().Result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Insert Category Async
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<int> InsertAsync(string name)
        {
            try
            {
                using (TestSGSEntities db = new TestSGSEntities())
                {
                    Category obj = new Category();
                    obj.Name = name;
                    db.Categories.Add(obj);
                    return await db.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        /// <summary>
        /// Delete category Async
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<int> DeleteAsync(int id)
        {
            try
            {
                using (TestSGSEntities db = new TestSGSEntities())
                {
                    Category obj = (db.Categories.Where(s => s.Id == id)).SingleOrDefault();

                    db.Categories.Remove(obj);
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
        /// Update Category Async
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
                    Category obj = (db.Categories.Where(s => s.Id == id)).SingleOrDefault();
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
        #endregion


    }
}