﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog124_Midterm_Project
{
     public class Data
    {
        private static ObservableCollection<Member> members = new ObservableCollection<Member>();
        private static ObservableCollection<Product> products = new ObservableCollection<Product>();
        private static Product currentProduct = null;
        private static Member currentMember = null;
        

        public static ObservableCollection<Member> MemberCollection => new ObservableCollection<Member>(members);
        public static ObservableCollection<Product> ProductCollection => new ObservableCollection<Product>(products);
        public static Product CurrentProduct { get => currentProduct; }
        public static Member CurrentMember { get => currentMember; }
        
        static Data()
        {
            members = new ObservableCollection<Member>();
            products = new ObservableCollection<Product>();
            Preload();
        }
        private static void Preload() // preload for test
        {
            products.Add(new Coffee("Johnny drink", 7, 99, Drink.DrinkSize.Short, "roast"));
            products.Add(new Coffee("drink2", 7, 99, Drink.DrinkSize.Short, "roast"));

        }
        public static void AddProductToCollection(Product product)
        {
            products.Add(product);
        }
        public static void Test(string name, decimal price, int point, Drink.DrinkSize drinkSize, string type) // test for debugging
        {
            products.Add(new Coffee(name, price, point, drinkSize, type));
        }

        public static void AddmemberToCollection(Member member)
        {
            members.Add(member);
        }
        public static void UpdateCurrentProduct(Product product)
        {
            currentProduct = product;
        }
        public static void UpdateCurrentMember(Member member)
        {
            currentMember = member;
        }
    }
    
}
