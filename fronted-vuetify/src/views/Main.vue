<template>
  <v-app app>
    <Layout />
    <router-view></router-view>
  </v-app>
</template>

<script lang="ts">
import { Vue, Component } from "vue-property-decorator";
import Layout from "../components/Layout.vue";

@Component({
    components: { Layout },
})
export default class Main extends Vue{}
</script>