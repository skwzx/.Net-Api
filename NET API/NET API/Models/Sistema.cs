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
            Pet pet = new Pet(p._name, p._type, p._age);
            pets.Add(pet);
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
            Pet pet1 = new Pet("Tokyo", "Cat", 1);
            Pet pet2 = new Pet("Roma", "Cat", 2);
            pets.Add(pet1);
            pets.Add(pet2);
        }

        public void DeletePet(int id)
        {
            foreach (Pet pet in pets)
            {
                if (pet._id == id)
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
