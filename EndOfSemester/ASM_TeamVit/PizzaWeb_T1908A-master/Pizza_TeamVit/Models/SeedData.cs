using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Pizza_TeamVit.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                     new Product
                     {
                         Name = "Pizza Hải Sản Pesto Xanh",
                         Description = "Tôm, cua, mực và bông cải xanh tươi ngon trên nền sốt Pesto Xanh",
                         Img = "https://thepizzacompany.vn/images/thumbs/000/0002393_seafood-pesto_500.png",
                         Price = 169,
                         Category = "Pizza"
                     },
                     new Product
                     {
                         Name = "Pizza Tôm Cocktail",
                         Description = "Tôm với nấm, dứa, cà chua và sốt Thousand Island",
                         Img = "https://thepizzacompany.vn/images/thumbs/000/0002216_shrimp_500.png",
                         Price = 129,
                         Category = "Pizza"
                     },
                     new Product
                     {
                         Name = "Pizza Hải Sản Nhiệt Đới",
                         Description = "Tôm, nghêu, mực cua, dứa với sốt Thousand Island",
                         Img = "https://thepizzacompany.vn/images/thumbs/000/0002211_tropical-sf_500.png",
                         Price = 129,
                         Category = "Pizza"
                     },
                     new Product
                     {
                         Name = "Pizza Hải Sản Cocktail",
                         Description = "Tôm, cua, giăm bông,... với sốt Thousand Island",
                         Img = "https://thepizzacompany.vn/images/thumbs/000/0002212_sf-cocktail_500.png",
                         Price = 129,
                         Category = "Pizza"
                     },
                     new Product
                     {
                         Name = "Pizza Hải Sản Cao Cấp",
                         Description = "Tôm, cua, mực và nghêu với sốt Marinara",
                         Img = "https://thepizzacompany.vn/images/thumbs/000/0002214_sf-deluxe_500.png",
                         Price = 129,
                         Category = "Pizza"
                     },

                     new Product
                     {
                         Name = "Pizza Aloha",
                         Description = "Thịt nguội, xúc xích tiêu cay và dứa hòa quyện với sốt Thousand Island",
                         Img = "https://thepizzacompany.vn/images/thumbs/000/0002217_aloha_500.png",
                         Price = 119,
                         Category = "Pizza"
                     },
                     new Product
                     {
                         Name = "Pizza Thịt Xông Khói",
                         Description = "Thịt giăm bông, thịt xông khói và hai loại rau của ớt xanh, cà chua",
                         Img = "https://thepizzacompany.vn/images/thumbs/000/0002221_bacon-sup_500.png",
                         Price = 119,
                         Category = "Pizza"
                     },
                     new Product
                     {
                         Name = "Pizza Thịt Nguội Kiểu Canada",
                         Description = "Sự kết hợp giữa thịt nguội và bắp ngọt",
                         Img = "https://thepizzacompany.vn/images/thumbs/000/0002222_ca-bacon_500.png",
                         Price = 119,
                         Category = "Pizza"
                     },
                     new Product
                     {
                         Name = "Pizza Gà Nướng 3 Vị",
                         Description = "Gà nướng, gà bơ tỏi và gà ướp sốt nấm",
                         Img = "https://thepizzacompany.vn/images/thumbs/000/0002223_ck-trio_500.png",
                         Price = 119,
                         Category = "Pizza"
                     },
                     new Product
                     {
                         Name = "Pizza 3 Loại Thịt Thập Cẩm Và Rau Củ",
                         Description = "Sự kết hợp hài hòa của ba loại thịt và rau củ.",
                         Img = "https://thepizzacompany.vn/images/thumbs/000/0002220_deluxe_500.png",
                         Price = 119,
                         Category = "Pizza"
                     },
                     new Product
                     {
                         Name = "Pizza 5 Loại Thịt Đặc Biệt",
                         Description = "Xúc xích lợn và bò đặc trưng của Ý, giăm bông, thịt xông khói",
                         Img = "https://thepizzacompany.vn/images/thumbs/000/0002219_meat-deluxe_500.png",
                         Price = 119,
                         Category = "Pizza"
                     },
                     new Product
                     {
                         Name = "Pizza Gà Nướng Dứa",
                         Description = "Thịt gà mang vị ngọt của dứa kết hợp với vị cay nóng của ớt",
                         Img = "https://thepizzacompany.vn/images/thumbs/000/0002228_ck-caldo_500.png",
                         Price = 99,
                         Category = "Pizza"
                     },
                     new Product
                     {
                         Name = "Pizza Phô Mai",
                         Description = "Bánh Pizza với vô vàn phô mai để bạn tha hồ tận hưởng.",
                         Img = "https://thepizzacompany.vn/images/thumbs/000/0002226_double-cheese_500.png",
                         Price = 99,
                         Category = "Pizza"
                     },
                     new Product
                     {
                         Name = "Pizza Thịt Nguội & Nấm",
                         Description = "Pizza giăm bông và nấm đem đến cho bạn những trải nghiệm thú vị.",
                         Img = "https://thepizzacompany.vn/images/thumbs/000/0002227_h-m_500.png",
                         Price = 99,
                         Category = "Pizza"
                     },
                     new Product
                     {
                         Name = "Pizza Xúc Xích Ý",
                         Description = "Xúc xích cay kiểu Ý trên nền sốt cà chua",
                         Img = "https://thepizzacompany.vn/images/thumbs/000/0002225_double-pepperoni_500.png",
                         Price = 99,
                         Category = "Pizza"
                     },
                     new Product
                     {
                         Name = "Pizza Thịt Nguội & Nấm",
                         Description = "Pizza giăm bông và nấm đem đến cho bạn những trải nghiệm thú vị.",
                         Img = "https://thepizzacompany.vn/images/thumbs/000/0002227_h-m_500.png",
                         Price = 99,
                         Category = "Pizza"
                     },
                     new Product
                     {
                         Name = "Pizza Hawaiian",
                         Description = "Giăm bông, thịt muối và dứa",
                         Img = "https://thepizzacompany.vn/images/thumbs/000/0002224_hawaii_500.png",
                         Price = 99,
                         Category = "Pizza"
                     },
                     new Product
                     {
                         Name = "Pizza Rau Củ",
                         Description = "Hành, ớt chuông, nấm, dứa, cà chua",
                         Img = "https://thepizzacompany.vn/images/thumbs/000/0002229_veg_500.png",
                         Price = 99,
                         Category = "Pizza"
                     },

                     new Product
                     {
                         Name = "Pizza Gà Nướng 3 Vị Nhân Nhồi",
                         Description = "Gà nướng, gà bơ tỏi, gà ướp sốt, nấm, ớt và sốt cà chua",
                         Img = "https://thepizzacompany.vn/images/thumbs/000/0002232_pizza-puff-ck-trio_500.png",
                         Price = 109,
                         Category = "Pizza"
                     },
                     new Product
                     {
                         Name = "Pizza Hawaiian Nhân Nhồi",
                         Description = "Đặc trưng miền nhiệt đới với giăm bông, thịt muối, dứa và sốt cà chua",
                         Img = "https://thepizzacompany.vn/images/thumbs/000/0002231_pizza-puff-hawaiian_500.png",
                         Price = 109,
                         Category = "Pizza"
                     },
                     new Product
                     {
                         Name = "Pizza 5 Loại Thịt Đặc Biệt và Rau Củ Nhân Nhồi",
                         Description = "Siêu thượng hạng với nhiều loại thịt và rau phong phú với sốt cà chua",
                         Img = "https://thepizzacompany.vn/images/thumbs/000/0002230_pizza-puff-super-deluxe_500.png",
                         Price = 119,
                         Category = "Pizza"
                     },

                     new Product
                     {
                         Name = "Cánh Gà Tẩm Bột Chiên Giòn (10 miếng)",
                         Description = "Phủ bởi lớp bột đặc biệt tạo nên lớp vỏ giòn dai hấp dẫn",
                         Img = "https://thepizzacompany.vn/images/thumbs/000/0002417_korean-style-chicken-wings-10pcs_500.png",
                         Price = 199,
                         Category = "Cánh gà"
                     },
                     new Product
                     {
                         Name = "Cánh Gà Tẩm Bột Chiên Giòn (6 miếng)",
                         Description = "Phủ bởi lớp bột đặc biệt tạo nên lớp vỏ giòn dai hấp dẫn.",
                         Img = "https://thepizzacompany.vn/images/thumbs/000/0002238_korean-style-chicken-wings-6pcs_500.jpeg",
                         Price = 129,
                         Category = "Cánh gà"
                     },
                     new Product
                     {
                         Name = "Cánh gà nướng BBQ (10 miếng)",
                         Description = "Cánh gà nướng thấm vị với lớp da mỏng giòn",
                         Img = "https://thepizzacompany.vn/images/thumbs/000/0002416_bbq-chicken-wings-10-pcs_500.png",
                         Price = 199,
                         Category = "Cánh gà"
                     },
                     new Product
                     {
                         Name = "Cánh gà nướng BBQ (6 miếng)",
                         Description = "Cánh gà nướng thấm vị với lớp da mỏng giòn",
                         Img = "https://thepizzacompany.vn/images/thumbs/000/0002233_bbq-chicken-wings-6-pcs_500.jpeg",
                         Price = 129,
                         Category = "Cánh gà"
                     },

                     new Product
                     {
                         Name = "Mì Ý Cay Hải Sản",
                         Description = "Mỳ Ý rán với các loại hải sản tươi ngon cùng ớt và tỏi",
                         Img = "https://thepizzacompany.vn/images/thumbs/000/0002253_spaghetti-spicy-seafood_500.png",
                         Price = 129,
                         Category = "Mì Ý"
                     },
                     new Product
                     {
                         Name = "Mì Ý Tôm Sốt Kem Cà Chua",
                         Description = "Sự tươi ngon của tôm kết hợp với sốt kem cà chua",
                         Img = "https://thepizzacompany.vn/images/thumbs/000/0002257_spaghetti-shrimp-rose_500.png",
                         Price = 129,
                         Category = "Mì Ý"
                     },
                     new Product
                     {
                         Name = "Mì Ý thịt bò bằm",
                         Description = "Sốt thịt bò bằm đặc trưng kết hợp cùng mỳ Ý",
                         Img = "https://thepizzacompany.vn/images/thumbs/000/0002258_spaghetti-bolognese_500.png",
                         Price = 129,
                         Category = "Mì Ý"
                     },
                     new Product
                     {
                         Name = "Mì Ý Cay Xúc Xích",
                         Description = "Mỳ Ý rán với xúc xích cay, thảo mộc, ngò gai và húng quế Ý",
                         Img = "https://thepizzacompany.vn/images/thumbs/000/0002254_spicy-sausage-spaghetti_500.png",
                         Price = 109,
                         Category = "Mì Ý"
                     },

                     new Product
                     {
                         Name = "Salad Đặc Sắc",
                         Description = "Bông cải xanh, búp cải tím, táo, xà lách, trứng… và sốt Salad đặc biệt",
                         Img = "https://thepizzacompany.vn/images/thumbs/000/0002250_signature-salad_500.png",
                         Price = 69,
                         Category = "Salad"
                     },
                     new Product
                     {
                         Name = "Salad Trộn Sốt Caesar",
                         Description = "Rau tươi trộn với sốt Caesar",
                         Img = "https://thepizzacompany.vn/images/thumbs/000/0002251_caesars-salad_500.png",
                         Price = 69,
                         Category = "Salad"
                     },
                     new Product
                     {
                         Name = "Salad Trộn Dầu Giấm",
                         Description = "Rau với sốt dầu giấm",
                         Img = "https://thepizzacompany.vn/images/thumbs/000/0002252_garden-salad_500.png",
                         Price = 59,
                         Category = "Salad"
                     },
                     new Product
                     {
                         Name = "Russian Salad",
                         Description = "Salad Nga với cà rốt, khoai tây, đậu hạt, ngô hạt, jămbông, củ cải đỏ, cần tây, trộn xốt mayonnaise.",
                         Img = "https://api.alfrescos.com.vn//uploads/images/Alfrescos-Hanoi-Russian-Salad.jpg",
                         Price = 130,
                         Category = "Salad"
                     }
                );
                context.SaveChanges();
            }
        }
    }
}