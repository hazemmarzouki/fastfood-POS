using FastFoodPOS.Models;

namespace FastFoodPOS.Components
{
    class ReceiptTemplate
    {

        public static string GetReceipt(Transaction transaction)
        {
            return GenerateReceiptTemplate()
                .Replace("<Orders/>", GetOrderRows(transaction))
                .Replace("<Total/>", transaction.Total.ToString() + "Tnd")
                .Replace("<Cash/>", transaction.Cash.ToString() + "Tnd")
                .Replace("<Change/>", transaction.Change.ToString() + "Tnd")
                .Replace("<Id/>", transaction.Id)
                .Replace("<Cashier/>", transaction.GetCashier().Fullname)
                .Replace("<Date/>", transaction.Date.ToString());
        }

        static string GetOrderRows(Transaction transaction)
        {
            string result = "";
            transaction.GetOrders().ForEach((Order item) =>
            {
                result += "<tr>";
                result += "<td>" + item.GetProduct().Name + "</td>";
                result += "<td align='center'>x " + item.Quantity + "</td>";
                result += "<td align='right'>" + item.Subtotal + "Tnd</td>";
                result += "</tr>";
            });
            return result;
        }

        private static string GenerateReceiptTemplate()
        {
            return
                @"
                <center>
                    <font size='22px'><b>Fast Food</b></font><br/>
                    <span>hazem.marzouki11@gmail.com</span>
                </center>
                <br/><br/>
                <table width='90%'>  <font size='22px'></font>

                    <thead>
                        <tr>
                            <th align='left'>Product Name</th>
                            <th>Quantity</th>
                            <th align='right'>Subtotal</th>
                        </tr>
                    </thead>
                    <tbody>
                        <Orders/>
                    </tbody>
                        </font>
                </table>
                <br/>
                <center>---------------------------------------</center>
                <br/>

                Total: <b><Total/></b><br/>
                Cash: <b><Cash/></b><br/>
                Change: <b><Change/></b><br/>
                <br/>
                Transaction ID: #<Id/><br/>
                Cashier: <Cashier/><br/>
                Date: <Date/><br/>

                <br/>
                <center>---------------------------------------</center>
                <br/>

                <center><b>Thanks for visiting FastFood</b></center>
                ";
        }
    }
}
