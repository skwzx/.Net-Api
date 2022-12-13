<template>
    <section class="pet">
      <h1>This is MyPets page.</h1>
    </section>
    <section class="pet">
      <h2>My Pets Manager</h2>
      <table class="table table-dark table-striped table-bordered">
        <thead class="thead-light">
          <tr>
              <th>ID</th>
              <th>NAME</th>
              <th>TYPE</th>
              <th>AGE</th>
              <th>Actions</th>
          </tr>
        </thead>  
          <tr v-for="todo in todos" :key="todo._id">
            <td>{{todo._id}}</td>
            <td>{{todo._name}}</td>
            <td>{{todo._type}}</td>
            <td>{{todo._age}}</td>
            <td>Edit Delete</td>
          </tr>  
      </table>
    </section>
    <section class="pet">
      <h2>Add new pet</h2>
      <from @submite="addPet">

      </from>
    </section>
</template>


<script>
import axios from 'axios'

export default {
  data () {
    return {
      todos:null
    }
  },
  mounted(){ 
      this.getTodos();
  },
  methods: {
    getTodos(){
   
    axios
      .get("https://localhost:7225/pet/list")     
        .then(response => {
          this.todos = response.data

        })
        .catch( e=> console.log(e)) 
    }
  }
}
</script>

<style>
.pet{
    margin-top: 2rem;
}
</style>