using System;
using System.Collections.ObjectModel;

namespace LKQ.ViewModels
{
    public class MainPageViewModel
    {
        public ObservableCollection<string> ButtonList { get; private set; } = new ObservableCollection<string>();

        public MainPageViewModel()
        {
            CreateSalesCollection();
        }
        public MainPageViewModel(string selectedbtn)
        {
            switch (selectedbtn)
            {
                case "Sales":

                    CreateSalesCollection();
                    break;
                case "Trn":
                    CreateTrnsCollection();

                    break;
                case "Proc":
                    CreateProcCollection();

                    break;
                case "Inq":
                    CreateInqCollection();

                    break;
                case "Lbls":
                    CreateLblsCollection();

                    break;
            }
        }
        private void CreateSalesCollection()
        {
            ButtonList.Clear();
            ButtonList.Add("Sales Picking");
            ButtonList.Add("Route Staging");
            ButtonList.Add("Route Loading");
        }
        private void CreateTrnsCollection()
        {
            ButtonList.Clear();
            ButtonList.Add("Transfer Picking");
            ButtonList.Add("Transfer Receiving");
            ButtonList.Add("Cross Dock Scanning");
        }
        private void CreateProcCollection()
        {
            ButtonList.Clear();
            ButtonList.Add("Individual Bin Movement");
            ButtonList.Add("Stock Receipts");
            ButtonList.Add("Mark OTR PO as arrived");
            ButtonList.Add("Bulk Bin Movements");
            ButtonList.Add("Wall to Wall");
            ButtonList.Add("Cycle Count");
            ButtonList.Add("Returns Processing");
        }
        private void CreateInqCollection()
        {
            ButtonList.Clear();
            ButtonList.Add("Sales Picking");
            ButtonList.Add("Route Staging");
            ButtonList.Add("Route Loading");
        }
        private void CreateLblsCollection()
        {
            ButtonList.Clear();
            ButtonList.Add("Product");
            ButtonList.Add("Product by Bin");
            ButtonList.Add("Bin by Product");
            ButtonList.Add("EDI Scanning");
        }
    }
}
