using System;
using System.Collections.Generic;
using System.Text;
using Nobatgir.Model;

namespace Nobatgir.ViewModel
{

    public class PagedResult<T> where T : BaseClass
    {
        public List<T> Items { get; set; } = new List<T>();
        public List<string> DisplayColumns { get; set; } = new List<string>() { nameof(BaseClass.Title) };
        public PagingData PagingData { get; set; } = new PagingData();

        public string Controller { get; set; } = "";
    }

    public class PagingData
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages => (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);
    }
}
