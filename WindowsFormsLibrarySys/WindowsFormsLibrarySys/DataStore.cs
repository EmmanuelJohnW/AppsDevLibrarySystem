using System.Data;

namespace WindowsFormsLibrarySys
{
    public static class DataStore
    {
        public static DataTable BookTable { get; private set; }
        public static DataTable BorrowerTable { get; private set; }
        public static DataTable TransactionTable { get; private set; }
        private static int _transactionCounter = 1;

        static DataStore()
        {
            BookTable = new DataTable();
            BookTable.Columns.Add("Book ID");
            BookTable.Columns.Add("Title");
            BookTable.Columns.Add("Author");

            BorrowerTable = new DataTable();
            BorrowerTable.Columns.Add("Borrower ID");
            BorrowerTable.Columns.Add("Name");
            BorrowerTable.Columns.Add("Contact");

            TransactionTable = new DataTable();
            TransactionTable.Columns.Add("Transaction ID");
            TransactionTable.Columns.Add("Book ID");
            TransactionTable.Columns.Add("Book Title");
            TransactionTable.Columns.Add("Borrower ID");
            TransactionTable.Columns.Add("Borrower Name");
            TransactionTable.Columns.Add("Borrow Date");
            TransactionTable.Columns.Add("Return Date");
            TransactionTable.Columns.Add("Status");
        }

        public static string NextTransactionID()
        {
            return "TXN-" + (_transactionCounter++).ToString("D4");
        }
    }
}
