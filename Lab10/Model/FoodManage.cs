using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10.Model
{
    public class FoodManage
    {
        public static void GetNews(string Category, ObservableCollection<NewsFood> newsFoods)
        {
            var allItems = GetNewsFoods();
            var filteredNewsFoods = allItems.Where(p => p.Category == Category).ToList();
            newsFoods.Clear();
            filteredNewsFoods.ForEach(p => newsFoods.Add(p));
        }
        private static List<NewsFood> GetNewsFoods()
        {
            var foods = new List<NewsFood>();

            foods.Add(new NewsFood() {Category="Food", Name = "Hamburger1" , Price = "4.5$", Image="Assets/ham1.jpg"  });
            foods.Add(new NewsFood() { Category = "Food", Name = "Hamburger2", Price = "4.5$", Image = "Assets/ham2.jpg" });
            foods.Add(new NewsFood() { Category = "Food", Name = "Hamburger3", Price = "4.5$", Image = "Assets/ham3.jpg" });
            foods.Add(new NewsFood() { Category = "Food", Name = "Hamburger4", Price = "4.5$", Image = "Assets/ham4.jpg" });
            foods.Add(new NewsFood() { Category = "Food", Name = "Hamburger5", Price = "4.5$", Image = "Assets/ham5.jpg" });

            foods.Add(new NewsFood() { Category = "Drink", Name = "Sinh tố xoài", Price = "4.5$", Image = "Assets/st1.jpg" });
            foods.Add(new NewsFood() { Category = "Drink", Name = "Sinh tố dâu", Price = "4.5$", Image = "Assets/st2.jpg" });
            foods.Add(new NewsFood() { Category = "Drink", Name = "Sinh tố bơ", Price = "4.5$", Image = "Assets/st3.jpg" });
            foods.Add(new NewsFood() { Category = "Drink", Name = "Sinh tố cam", Price = "4.5$", Image = "Assets/st4.jpg" });
            foods.Add(new NewsFood() { Category = "Drink", Name = "Sinh tố dưa hấu", Price = "4.5$", Image = "Assets/st5.jpg" });
            return foods;
        }
    }
}
