namespace ConsoleAppADO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SPClass sp = new SPClass();
            //sp.SPInsert();
            //sp.SPDelete();
            //sp.SPUpdate();
            //sp.SPFetch();
            //sp.SPFetchAccountType();
            
            BulkInsertClass bulkInsert = new BulkInsertClass();
            bulkInsert.BulkOperation();


            //ADOConnectedClass cs = new ADOConnectedClass();
            //cs.InsertData();
            //cs.DeleteData();
            //cs.UpdateData();
            //cs.FetchData();
            //cs.FetchDataAccType("saving");
            //cs.FetchMultipleData();
            //ADODisconnectedClass dis = new ADODisconnectedClass();
            //dis.FetchData();

        }
    }
}
