namespace Bai9.Model
{
    public class Bill
    {
        public int FamilyId { get; set; }
        public int OldCode { get; set; }
        public int NewCode { get; set; }
        public int Total { get; set; }
        public Bill(int familyId, int oldCode, int newCode, int total)
        {
            FamilyId = familyId;
            OldCode = oldCode;
            NewCode = newCode;
            Total = total;
        }
    }
}