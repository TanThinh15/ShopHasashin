using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace HasashinShop.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            HasashinShopDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<HasashinShopDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            // Kiểm tra thông tin Product đã tồn tại hay chưa
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                new Product
                {
                    TenSP = "Chanel Allure Homme Sport",
                    NgayMua = DateTime.Parse("2022-10-16"),
                    LoaiSP = "Nước Hoa Nam",
                    Gia = 500000,
                    ImageProduct = "https://orchard.vn/wp-content/uploads/2014/06/Chanel-Allure-Homme-Sport_1_opla-ca.jpg"
                },
                new Product
                {
                    TenSP = "Bleu De Chanel Parfum",
                    NgayMua = DateTime.Parse("2022-10-16"),
                    LoaiSP = "Nước Hoa Nam",
                    Gia = 500000,
                    ImageProduct = "https://www.chanel.com/images//t_one//w_0.51,h_0.51,c_crop/q_auto:good,f_auto,fl_lossy,dpr_1.2/w_620/bleu-de-chanel-parfum-spray-3-4fl-oz--packshot-default-107180-8848376987678.jpg"
                },
                 new Product
                 {
                     TenSP = "Chanel Coco Eau de Parfum",
                     NgayMua = DateTime.Parse("2022-10-16"),
                     LoaiSP = "Nước Hoa Nữ",
                     Gia = 500000,
                     ImageProduct = "https://www.chanel.com/images//t_one//w_0.51,h_0.51,c_crop/q_auto:good,f_auto,fl_lossy,dpr_1.2/w_620/coco-eau-de-parfum-spray-3-4fl-oz--packshot-default-113530-8848377085982.jpg"
                 },
                 new Product
                 {
                     TenSP = "Chanel Coco Noir",
                     NgayMua = DateTime.Parse("2022-10-16"),
                     LoaiSP = "Nước Hoa Nữ",
                     Gia = 500000,
                     ImageProduct = "https://fimgs.net/mdimg/perfume/375x500.15963.jpg"
                 }
                );
                context.SaveChanges();//lưu dữ liệu
            }   
        }
    }
}
