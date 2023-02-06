namespace Bai1.Service
{
    interface IStaffManagement
    {
        public void AddStaff(Officer officer);
        public void SearchStaffByName();
        public Officer AddInfoOffice();
        public void GetAllStaff();
        public void AddDetailStaff(Officer officer, string role);
    }
    
}