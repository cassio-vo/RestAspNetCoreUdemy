using RestAspNetCoreUdemy_Verbos.Model.Base;
using System;

namespace RestAspNetCoreUdemy_Verbos.Model
{
    public class Book : BaseEntity
    {
        public string Author { get; set; }

        public DateTime LaunchDate { get; set; }

        public decimal Price { get; set; }

        public string Title { get; set; }
    }
}
