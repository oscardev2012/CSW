using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackendAPI.DTOs
{
    /// <summary>
    /// Book DTOs
    /// </summary>
    public class DTOBook
    {

        public int IdBook { get; set; }
        public string NameBook { get; set; }
        public int IdAuthor { get; set; }
        public string NameAuthor { get; set; }
        public int IdCategory { get; set; }
        public string NameCategory { get; set; }
       
    }
}