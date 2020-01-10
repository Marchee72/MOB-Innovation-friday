<template>
  <v-container>
    <v-sheet height="500">
      <v-calendar type="week" now="2019-01-08" value="2019-01-08"></v-calendar>
    </v-sheet>
  </v-container>
</template>

<script lang="ts">
import { Vue, Component } from "vue-property-decorator";

@Component
export default class MainDashboard extends Vue {

}
</script>

<style>
</style>