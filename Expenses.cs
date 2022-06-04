using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class Expenses
    {
        private static object[] Groceries;
        private static object[] WaterAndLights;
        private static object[] TravelCosts;
        private static object[] CellPhoneandTelePhone;
        private static object[] OtherExpenses;
        public static int x = 0;

        public static object[] Groceries1 { get => Groceries; set => Groceries = value; }
        public static object[] WaterAndLights1 { get => WaterAndLights; set => WaterAndLights = value; }
        public static object[] TravelCosts1 { get => TravelCosts; set => TravelCosts = value; }
        public static object[] CellPhoneandTelePhone1 { get => CellPhoneandTelePhone; set => CellPhoneandTelePhone = value; }
        public static object[] OtherExpenses1 { get => OtherExpenses; set => OtherExpenses = value; }

        public Expenses(int Size)
        {
            Groceries = new object[Size];
            WaterAndLights = new object[Size];
            TravelCosts = new object[Size];
            CellPhoneandTelePhone = new object[Size];
            OtherExpenses = new object[Size];
        }
        public void Push(object Groceries, object WaterAndLights, object TravelCosts, object CellPhoneandTelephone, object OtherExpenses)
        {
        }
        public static object Display()
        {
            object strDisplay = "";
            for (int i = 0; i < x; i++)
            {
                strDisplay += " Groceries" + Groceries[i] + "\n" +
                    " WaterAndLights" + WaterAndLights[i] + "\n" +
                    "TravelCosts" + TravelCosts[i] + "\n" +
                    " CellPhoneandTelephone" + CellPhoneandTelePhone[i] + "\n " +
                    "OtherExpenses " + OtherExpenses[i] + "\n";
            }
            return strDisplay;
        }


    }
}
    