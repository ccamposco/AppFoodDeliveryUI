using AppFoodDeliveryUI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AppFoodDeliveryUI.ViewModels
{
    public class DeliveryViewModel
    {
        public ObservableCollection<Categories> categories { get; set; }

        public ObservableCollection<PopularFood> popularfood { get; set; }

        public DeliveryViewModel()
        {
            categories = new ObservableCollection<Categories>
            {
                new Categories
                {
                    Image="Burger",
                    Title = "Burger"
                },

                new Categories
                {
                    Image = "Seafood",
                    Title = "Seafood"
                },

                new Categories
                {
                    Image = "SoftDrink",
                    Title = "SoftDrink"
                }

            };

            popularfood = new ObservableCollection<PopularFood>
            {
                new PopularFood
                {
                    Image = "MenuOption",
                    Title = "Chicken Royal",
                    Type = "Hamgurguesa",
                    Price = "$15"
                },

                new PopularFood
                {
                    Image = "MenuOption",
                    Title = "Chicken Burguer",
                    Type = "King Royal",
                    Price = "$25"
                },

                new PopularFood
                {
                    Image = "MenuOption",
                    Title = "Chicken BRASA",
                    Type = "Hamgurguesa SUPER",
                    Price = "$35"
                }
            };
        }
    }
}
