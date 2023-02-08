using Bai9.Model;

namespace Bai9.Service
{
    public class BillService : IBillService
    {
        public List<Bill> ListBills;
        FamilyService FamilyServices = new FamilyService();
        public BillService()
        {
            ListBills = new List<Bill>(){
                new Bill(123,3,5,15),
                new Bill(456,4,5,5)
            };
        }   
        public double TotalBill()
        {
            throw new NotImplementedException();
        }
    }
}