namespace NET_API.Models
{
    public class Pet
    {
        public static int _Lastid { get; set; } = 1;
        public int _id { get; set; }
        public string _name { get; set; }
        public string  _type { get; set; }
        public int _age { get; set; }

        public Pet()
        {
        }

        public Pet(string name, string type, int age)
        {
            _id = _Lastid;
            _Lastid++;
            _name = name;
            _type = type;
            _age = age;
        }
    }


}
