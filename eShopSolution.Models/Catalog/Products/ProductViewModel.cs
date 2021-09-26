using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Models.Catalog.Products
{
    public class ProductViewModel
    {
        //product
        [Display(Name = "Mã Sp")]
        public int Id { set; get; }
        [Display(Name = "Giá")]
        public decimal Price { set; get; }
        [Display(Name = "Giá gốc")]
        public decimal OriginalPrice { set; get; }
        [Display(Name = "Tồn kho")]
        public int Stock { set; get; }
        [Display(Name = "Lượt xem")]
        public int ViewCount { set; get; }
        [Display(Name = "Ngày tạo")]
        public DateTime DateCreated { set; get; }
        public bool? IsFeatured { get; set; }
        //product_translation
        [Display(Name = "Tên Sp")]
        public string Name { set; get; }
        [Display(Name = "Miêu tả")]
        public string Description { set; get; }
        [Display(Name = "Thông tin sản phẩm")]
        public string Details { set; get; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }
        public string SeoAlias { get; set; }
        [Display(Name = "Ngôn ngữ")]
        public string LanguageId { set; get; }


        [Display(Name = "Image")]
        public string ThumbnailImage { get; set; }


        public List<string> Categories { get; set; } = new List<string>();
    }
}
