using Pratice.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Pratice
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Img> Images;
        private ObservableCollection<Product> Products;
        public MainPage()
        {
            this.InitializeComponent();
            Images = new List<Img>();
            Images.Add(new Img { ImageName = "Product1", ImagePath = "Assets/anime1.jpg" }); ;
            Images.Add(new Img { ImageName = "Product2", ImagePath = "Assets/anime2.png" });
            Images.Add(new Img { ImageName = "Product3", ImagePath = "Assets/anime3.jpg" });
            Images.Add(new Img { ImageName = "Product4", ImagePath = "Assets/anime4.jpg" });
            Images.Add(new Img { ImageName = "Product5", ImagePath = "Assets/anime5.jpg" });
            Images.Add(new Img { ImageName = "Product6", ImagePath = "Assets/anime6.jpg" });
            ImageProduct.ItemsSource = Images;
            ImageProduct.SelectedIndex = 0;

            Products = new ObservableCollection<Product>();
        }
        private void NewProductButton_Click(object sender, RoutedEventArgs e)
        {
            string imageProduct = ((Img)ImageProduct.SelectedValue).ImagePath;
            Products.Add(new Product { ProductName = product.Text, Description = description.Text, ImageProduct = imageProduct });

            product.Text = "";
            description.Text = "";
            ImageProduct.SelectedIndex = -1;

            product.Focus(FocusState.Programmatic);
        }
    }
}
