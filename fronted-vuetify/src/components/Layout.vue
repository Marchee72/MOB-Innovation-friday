<template>
  <v-container>
    <v-app-bar app clipped-left color="dark" dark>
      <v-app-bar-nav-icon @click.stop="drawer = !drawer" />
      <v-toolbar-title>SymLite</v-toolbar-title>
      <v-spacer></v-spacer>
      <v-btn icon>
        <v-icon>mdi-heart</v-icon>
      </v-btn>
      <v-btn icon>
        <v-icon>mdi-magnify</v-icon>
      </v-btn>
      <v-menu left bottom>
        <template v-slot:activator="{ on }">
          <v-btn icon v-on="on">
            <v-icon>mdi-dots-vertical</v-icon>
          </v-btn>
        </template>
        <v-list>
          <v-list-item v-for="n in 5" :key="n" @click="() => {}">
            <v-list-item-title>Option {{ n }}</v-list-item-title>
          </v-list-item>
        </v-list>
      </v-menu>
    </v-app-bar>

    <v-navigation-drawer v-model="drawer" app clipped>
      <v-list dense>
        <v-list-item link v-for="item in this.actionItems" v-bind:key="item.name" :to="item.url">
          <v-list-item-action>
            <v-icon>{{ item.icon }}</v-icon>
          </v-list-item-action>
          <v-list-item-content>
            <v-list-item-title>{{ item.name }}</v-list-item-title>
          </v-list-item-content>
        </v-list-item>
      </v-list>
    </v-navigation-drawer>
  </v-container>
</template>

<script lang="ts">
import { Vue, Component } from "vue-property-decorator";

@Component
export default class Layout extends Vue {
  drawer!: boolean;
  actionItems!: { name: string; url: string; icon: string }[];
  constructor() {
    super();
    this.$vuetify.theme.dark = true;

    this.drawer = false;
    this.load();
  }

  private async load() {
    this.actionItems = [
      { name: "Dashboard", url: "/dashboard", icon: "mdi-view-dashboard" },
      { name: "Edifices", url: "/edifices", icon: "mdi-office-building" }
    ];
  }
}
</script>

