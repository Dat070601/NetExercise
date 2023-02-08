using Bai9.Model;

namespace Bai9.Service
{
    class FamilyService : IFamilyService
    {
        public List<Family> ListFamilies;
        public FamilyService()
        {
            ListFamilies = new List<Family>(){
                new Family("HOANG LE HUY", "NGU HANH SON", 123),
                new Family("NGUYEN THI HAI YEN", "LIEN CHIEU", 456)
            };
        }

        public void AddFamily(Family family)
        {
            var findFamily = ListFamilies.Where(fa => fa.ElectricityCode == family.ElectricityCode).FirstOrDefault();
            if(findFamily != null){
                Console.WriteLine("Family is already exist!");
            }
            else
            {
                ListFamilies.Add(family);
            }
        }

        public void ShowFamilyInfo()
        {
            foreach (var item in ListFamilies)
            {
                Console.WriteLine("Name: " + item.Name + " Address: " + item.Address + " ElectricityCode: "+ item.ElectricityCode);
            }
        }
    }
}