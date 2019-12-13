<template>
  <div class="about">
    <h1>This is an about page</h1>
  </div>
</template>

<script lang="ts">
import Vue from "vue";
import User from "../models/user";
export default class About extends Vue{
 /**
  *
  */
 constructor() {
   super();
   var a = this.getUsers();
   alert(a);
 } 
  private async getUsers() {
        var users = await fetch("https://localhost:44346/user", {credentials: "same-origin"});
        return (await users.json()) as User[];
        
    }
}
</script>