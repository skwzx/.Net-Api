namespace NET_API.Models
{
    public class Pet
    {
        public int _id { get; set; }
        public string _name { get; set; }
        public string  _type { get; set; }
        public int _age { get; set; }

        public Pet()
        {
        }

        public Pet(int id, string name, string type, int age)
        {
            _id = id;
            _name = name;
            _type = type;
            _age = age;
        }
    }


}
