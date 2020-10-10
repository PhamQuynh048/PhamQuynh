using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Music.Models
{
    public class MusicDatabaseInitializer : DropCreateDatabaseAlways<MusicContext>
    {
        protected override void Seed(MusicContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetMusics().ForEach(p => context.Musics.Add(p));
        }
        private static List<Category> GetCategories()
        {
            var categories = new List<Category>
            {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "VietNam"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "China"
                },
                new Category
                {

                    CategoryID = 3,
                    CategoryName = "Korean"
                },
                new Category
                {
                    CategoryID=4,
                    CategoryName = "U.S. UK"
                },
            };
            return categories;
        }
        private static List<AppMusic> GetMusics()
        {
            var musics = new List<AppMusic>
            {
                new AppMusic
                {
                    MusicID = 1,
                    MusicName = "Convertible Car",
                    Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)." + "Power it up and let it go!",
                    ImagePath="carconvert.png",
                    UnitPrice = 22.50,
                    CategoryID = 1
                },
                new AppMusic
                {
                    MusicID=2,
                    MusicName="Old-time Car",
                    Description = "There's nothing old about this toy car, except it's looks. Compatible with other old toy cars.",
                    ImagePath="carearly.png",
                    UnitPrice = 15.95,
                    CategoryID = 1
                },
                new AppMusic
                {
                    MusicID = 4,
                    MusicName = "Super Fast Car",
                    Description = "Use this super fast car to entertain quests.Lights and doors work!",
                    ImagePath="carfash.png",
                    UnitPrice= 8.95,
                    CategoryID = 1
                },
                new AppMusic
                {
                    MusicID = 5,
                    MusicName = "Old Style Racer",
                    Description="This old style racer can fly (with user assistance). Gravity controls flight duration." +
                    "No batteries required.",
                    ImagePath = "cajgd.png",
                    UnitPrice = 34.95,
                    CategoryID = 1
                },
                new AppMusic
                {
                    MusicID = 6,
                    MusicName = "Ace Plane",
                    Description = "Authentic airplane toy. Features realistic color and details.",
                    ImagePath="planeace.png",
                    UnitPrice = 95.00,
                    CategoryID = 2
                },
                new AppMusic
                {
                    MusicID = 7,
                    MusicName = "Glider",
                    Description = "This fun glider is made from real balsa wood. Some assembly required.",
                    ImagePath="planeglider.png",
                    UnitPrice = 4.95,
                    CategoryID = 2
                },
                new AppMusic
                {
                    MusicID = 8,
                   MusicName = "Paper Plane",
                    Description = "This paper plane is like no other paper plane. Some folding required.",
                    ImagePath = "shfje.png",
                    UnitPrice = 2.95,
                    CategoryID = 2
                },
                new AppMusic
                {
                    MusicID = 9,
                    MusicName = "Propeller Plane",
                    Description = "Rubber band powered plane features two wheels.",
                    ImagePath="planeprop.png",
                    UnitPrice = 32.95,
                    CategoryID = 2
                },
                new AppMusic
                {
                    MusicID = 10,
                    MusicName = "Early Truck",
                    Description = "This toy truck has a real gas powered engine. Requires regular tune ups.",
                    ImagePath="truckearly.png",
                    UnitPrice = 15.00,
                    CategoryID = 3
                },
                new AppMusic
                {
                    MusicID = 11,
                    MusicName = "Fire Truck",
                    Description = "You will have endless fun with this one quarter sized fire truck.",
                    ImagePath="truckfire.png",
                    UnitPrice = 26.00,
                    CategoryID = 3
                },
                new AppMusic
                {
                    MusicID = 12,
                    MusicName = "Big Truck",
                    Description = "This fun toy truck can be used to tow other trucks that are not as big.",
                    ImagePath="truckbig.png",
                    UnitPrice = 29.00,
                    CategoryID = 3
                },
                new AppMusic
                {
                    MusicID = 13,
                    MusicName = "Big Ship",
                    Description = "Is it a boat or a ship. Let this floating vehicle decide by using its " +
                    "artifically intelligent computer brain!",
                    ImagePath = "boatbig.png",
                    UnitPrice = 95.00,
                    CategoryID = 4
                },
                new AppMusic
                {
                    MusicID = 14,
                    MusicName = "Paper Boat",
                    Description = "Floating fun for all! This toy boat can be assembled in seconds.Floats for minutes!" +
                    "Some folding required.",
                    ImagePath="boatpaper.png",
                    UnitPrice = 4.95,
                    CategoryID = 4
                },
                new AppMusic
                {
                    MusicID = 15,
                    MusicName = "Sail Boat",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="boatsail.png",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },
                new AppMusic
                {
                    MusicID = 16,
                    MusicName = "Rocket",
                    Description = "This fun rocket will travel up to a heightof 200 feet.",
                    ImagePath = "rocket.png",
                    UnitPrice = 122.95,
                    CategoryID = 5
                }
            };
            return musics;
        }
    }
}