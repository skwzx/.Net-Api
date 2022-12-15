<template>
    <form @submit.prevent="createPet">
        <div class="row">
            <div class="col-4 p-1">
                 <input class="form-control" type="text" id="petName" v-model="formData._name" placeholder="Pet Name">
            </div>
            <div class="col-4 p-1">
                <input class="form-control" type="text" id="petType" v-model="formData._type" placeholder="Pet Type">
            </div>
             <div class="col-2 p-1">
                <input class="form-control" type="number" id="petAge" v-model="formData._age" placeholder="Pet Age">
            </div>
             <div class="col-2 p-1">
                 <button @click="reloadPage" class="btn btn-primary">Add Pet</button>
            </div>
        </div>
    </form>
</template>

<script>
import axios from 'axios';

    export default {
        name: 'createPet',
        data(){
            return {
                formData :{
                     _name: "",
                     _type: "",
                     _age: ""
                },
            }
        },

        methods: {
            createPet(){
                axios.post('https://localhost:7225/pet/add', this.formData)
                        .then(response => console.log(response))
                        .catch(error => console.log(error, this.formData))                         
            },
            reloadPage() {
                    window.location.reload();
             }
        }    
    }
</script>

