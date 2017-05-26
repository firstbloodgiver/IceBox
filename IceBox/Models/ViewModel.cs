using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IceBox.Models
{
    public class ViewModel
    {
        public List<NewsTable> news { get; set; }
        public List<ProductTable> special { get; set; }
        public List<ProductList> recom { get; set; }
        public List<ProductList> coming { get; set; }
        public List<ProductList> disco { get; set; }
    }
    
    public class ProductList
    {
        public ProductTable product { get; set; }
        public List<TypeTable> type { get; set; }
    }

     
}