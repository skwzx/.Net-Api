namespace NET_API.Models
{
    public class Sistema
    {
  
        private Sistema() { 
            PreLoad();
        }

        private static Sistema _instance;

        public static Sistema GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Sistema();
            }
            return _instance;
        }

        public List<Pet> pets { get; set; } = new List<Pet>();

        public void AddPet(Pet p)
        {
            pets.Add(p);
        }

        public List<Pet> GetPets()
        {
            List <Pet> aux = new List<Pet>();

            foreach (Pet pet in pets) {
                aux.Add(new Pet
                {
                    _id = pet._id,
                    _name = pet._name,
                    _type = pet._type,
                    _age = pet._age,
                }); 
            }
            return aux;
        }

        private void PreLoad() {
            Pet pet1 = new Pet(1, "Tokyo", "Cat", 1);
            Pet pet2 = new Pet(2, "Roma", "Cat", 2);

            AddPet(pet1);
            AddPet(pet2);
        }

        public void DeletePet(Pet p)
        {
            foreach (Pet pet in pets)
            {
                if (pet._id == p._id)
                {
                    pets.Remove(pet);
                }
                
            }
        }

        public void UpdatePet(Pet p, string name, string type, int age)
        {
            foreach (Pet pet in pets)
            {
                if (pet._id == p._id)
                {
                    pet._name = name;
                    pet._type = type;
                    pet._age= age;
                }

            }
        }
    }
}
