﻿using BE;
using PL.models;
using PL.userControls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PL.viewModels
{
    public class AnalyzeBuyingVM:IVM
    {
        BuyingModel Model;
        AnalyzeBuyingUC AnalyzeBuyingUC;
        public List<probility> probilities { get; set; }
        public AnalyzeBuyingVM(MainWindow main)
        {


            main.DataContext = this;
            Model = new BuyingModel();
            buyinglist = new ObservableCollection<Buying>(Model.buyings);
            userlist = new ObservableCollection<User>(Model.userlist);
            storelist = new ObservableCollection<Store>(Model.storelist);
            productlist = new ObservableCollection<Product>(Model.productlist);
            categorylist = new ObservableCollection<Category>(Model.categorylist);
            AnalyzeBuyingUC = main.centerOfPageGrid.GetChildOfType<AnalyzeBuyingUC>();
            AnalyzeBuyingUC.ShowButtonClickedEvent += Active_ShowButtonClickedEvent;
            probilities= getProbabiltyList();
            AnalyzeBuyingUC.probabiltyDataGrid.ItemsSource = probilities;
            
        }

        private void Active_ShowButtonClickedEvent()
        {

            int product1 = (AnalyzeBuyingUC.productname.SelectedValue as Product).ProductId;
            int product2 = (AnalyzeBuyingUC.productname1.SelectedValue as Product).ProductId;

            AnalyzeBuyingUC.probability.Text = Model.getProbability(product1, product2).ToString();


        }

        public struct probility
        {
            public probility(string product1, string product2, float probability)
            {
                this.product1 = product1;
                this.product2 = product2;
                this.probability = probability;
            }
            public string product1 { get; set; }
            public string product2 { get; set; }
            public float probability { get; set; }
        }

        public List<probility> getProbabiltyList()
        {
            List<probility> probilities = new List<probility>();
            List<Product> products = Model.productlist;
            for (int i=0; i<products.Count; i++)
            {
                for (int j = i+1; j < products.Count; j++)
                {
                    int p1 = products[i].ProductId;
                    int p2 = products[j].ProductId;
                    float probability = Model.getProbability(p1, p2);
                    probilities.Add(new probility(products[i].ProductName, products[j].ProductName, probability));
                }
            }
            return probilities;  
        }
    }
}
