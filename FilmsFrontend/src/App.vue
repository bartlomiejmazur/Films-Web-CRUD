<script setup>
import { RouterLink, RouterView } from 'vue-router'

</script>

<template>
 <div class="container">
    <h1 class="d-flex justify-content-center">Frontend Vue</h1>
    <h3 class="d-flex justify-content-center">Lista filmów</h3>

   
    

      <nav class="navbar navbar-expand-sm bg-light navbar-dark">
        <ul class="navbar-nav">
          <li class="nav-item m-1">
          <RouterLink class="btn btn-info" to="/">Lista obecnych filmów</RouterLink>
          </li>
          <li class="nav-item m-1">
        <RouterLink class="btn btn-light btn-outline-success" to="/add-film">Dodaj film</RouterLink>
          </li>
          <li class="nav-item m-1">
        <RouterLink class="btn btn-secondary" to="/upload-films">Pobierz filmy z bazy danych</RouterLink>
          </li>
      </ul>
      </nav>
      <router-view></router-view>
  </div>


  
</template>

<style scoped>

</style>
