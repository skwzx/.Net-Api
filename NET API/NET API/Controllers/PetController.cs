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
            p._id = 3;
            s.AddPet(p);

            return new
            {
                succes = true,
                message = "Succesfull register",
                result = p
            };

        }

        [HttpDelete]
        [Route("delete")]
        public dynamic deletePet(Pet p)
        {    
            s.DeletePet(p);
            return new
            {
                succes = true,
                message = "Succesfull delete",
                result = p
            };

        }


        [HttpPut]
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
