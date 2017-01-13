using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Data.Entity;
using BackendAPI.DTOs;

namespace BackendAPI.Data
{
    /// <summary>
    /// Book Dalc Class
    /// </summary>
    public class BookDalc
    {


        #region Async
        /// <summary>
        /// Get All Book 
        /// </summary>
        /// <returns></returns>
        public async Task<List<DTOBook>> GetAllAsync()
        {
            try
            {
                using (TestSGSEntities db = new TestSGSEntities())
                {

                    List<DTOBook> book =  await (from b in db.Books
                                          join
                                              a in db.Authors on b.AuthorId equals a.Id
                                          join
                                           c in db.Categories on b.CategoryId equals c.Id
                                          select new DTOBook()
                                          {
                                              IdBook = b.Id,
                                              IdAuthor = a.Id,
                                              IdCategory = c.Id,
                                              NameAuthor = a.Name,
                                              NameCategory = c.Name,
                                              NameBook = b.Name
                                          }).OrderBy(x => x.NameBook).ToListAsync();


                    return book; ;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        /// <summary>
        /// Insert Boook 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="authorId"></param>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public async Task<int> InsertAsync(string name, int authorId, int categoryId)
        {
            try
            {
                using (TestSGSEntities db = new TestSGSEntities())
                {
                    Book obj = new Book();
                    obj.Name = name;
                    obj.CategoryId = categoryId;
                    obj.AuthorId = authorId;
                    db.Books.Add(obj);
                    return await db.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }




        /// <summary>
        /// Delete Book
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<int> DeleteAsync(int id)
        {
            try
            {
                using (TestSGSEntities db = new TestSGSEntities())
                {
                    Book obj = (db.Books.Where(s => s.Id == id)).SingleOrDefault();

                    db.Books.Remove(obj);
                    return await db.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Update Book
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="authorId"></param>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public async Task<int> UpdateAsync(int id, string name, int authorId, int categoryId)
        {
            try
            {
                using (TestSGSEntities db = new TestSGSEntities())
                {
                    Book obj = (db.Books.Where(s => s.Id == id)).SingleOrDefault();
                    obj.Name = name;
                    obj.AuthorId = authorId;
                    obj.CategoryId = categoryId;
                    db.Entry(obj).State = EntityState.Modified;
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