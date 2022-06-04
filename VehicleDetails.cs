using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class VehicleDetails<T>
    {
        private static object[] ModelAndMake;
        private static object[] PurchasePrice;
        private static object[] TotalDeposit;
        private static object[] InterestRate;
        private static object[] EstimatedInsurancePremium;
        public static int x = 0;

        public static object areaSelected { get; internal set; }
        public static object[] ModelAndMake1 { get => ModelAndMake; set => ModelAndMake = value; }
        public static object[] PurchasePrice1 { get => PurchasePrice; set => PurchasePrice = value; }
        public static object[] TotalDeposit1 { get => TotalDeposit; set => TotalDeposit = value; }
        public static object[] InterestRate1 { get => InterestRate; set => InterestRate = value; }
        public static object[] EstimatedInsurancePremium1 { get => EstimatedInsurancePremium; set => EstimatedInsurancePremium = value; }

        public VehicleDetails(int Size)
        {
            ModelAndMake = new object[Size];
            PurchasePrice = new object[Size];
            TotalDeposit = new object[Size];
            InterestRate = new object[Size];
            EstimatedInsurancePremium = new object[Size];
        }

        public VehicleDetails()
        {
        }

        public static object Display()
        {
            object strDisplay = "";
            for (int i = 0; i < x; i++)
            {
                strDisplay += " ModelAndMake" + ModelAndMake[i] + "\n" +
                    " PurchasePrice" + PurchasePrice[i] + "\n" +
                    "TotalDeposit" + TotalDeposit[i] + "\n" +
                    " InterestRate" + InterestRate[i] + "\n " +
                    "EstimatedInsurancePremium " + EstimatedInsurancePremium[i] + "\n";
            }
            return strDisplay;
        }
        private static float emi_Calculator(float emi, float interestRate, float monthrepay)
        {
            interestRate = interestRate / (12 * 100);//one month interest
            monthrepay = monthrepay * 12;//one month period
            emi = (emi * interestRate * (float)Math.Pow(1 + interestRate, monthrepay))
                / (float)(Math.Pow(1 + interestRate, monthrepay) - 1);
            return (emi);
        }

        internal static void push(object strModelAndMake, object strPurchasePrice, object strTotalDeposit, object strInterestRate, object strEstimatedInsurancePremium)
        {
            ModelAndMake[x]= strModelAndMake;
            PurchasePrice[x] = strPurchasePrice;
            TotalDeposit[x] = strTotalDeposit;
            InterestRate[x] = strInterestRate;
            EstimatedInsurancePremium[x] = strEstimatedInsurancePremium;
        }

        internal void Push(object strModelAndMake, object strPurchasePrice, object strTotalDeposit, object strInterestRate, object strEstimatedInsurancePremium)
        {
            throw new NotImplementedException();
        }
    }
}
 

