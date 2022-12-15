using Microsoft.AspNetCore.Mvc;
using NET_API.Models;

namespace NET_API.Controllers
{
    [ApiController]
    [Route("pet")]
    public class PetController : ControllerBase
    {

        Sistema s = Sistema.GetInstance();

        [HttpGet]
        [Route("list")]
        public dynamic listPets()
        {

            List<Pet> pets = s.GetPets();
            return pets;
        }

        [HttpPost]
        [Route("add")]
        public dynamic addPet(Pet p)
        {
            s.AddPet(p);

            return new
            {
                succes = true,
                message = "Succesfull register",
                result = p
            };

        }

        [HttpDelete("{_id}")]
        [Route("delete")]
        public dynamic deletePet(int _id)
        {
            s.DeletePet(_id);
            return new
            {
                succes = true,
                message = "Succesfull delete",
                result = "hola"
            };

        }


        [HttpPut("{id}")]
        [Route("update")]
        public dynamic updatePet(Pet p, string name, string type, int age)
        {     
            s.UpdatePet(p, name, type, age);

            return new
            {
                succes = true,
                message = "Succesfull update",
                result = p
            };

        }

    }
}
