<template>
  <v-container>
    <MainCalendar/>
  </v-container>
</template>

<script lang="ts">
import {Vue,  Component}  from "vue-property-decorator";
import MainCalendar from "./MainCalendar.vue";

@Component({
  components: {MainCalendar}
})
export default class HelloWorld extends Vue {

}
</script>
