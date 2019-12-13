
<template>
  <div>
      <b-card v-for="item in items" :key="item.nro" no-body class="text-center">
        {{item.nombre}}
        </b-card>
  </div>
</template>

<script lang="ts">
import Vue from 'vue';
import { Component } from 'vue-property-decorator';

@Component
export default class List extends Vue{
    private items!: {nro: number, nombre: string}[];
    constructor() {
        super();
        this.items = [{
        nro: 1,
        nombre: "Seba"
        },
        {
        nro: 2,
        nombre: "Hombre"
        },
        {
        nro: 3,
        nombre: "Laucha"
        }
        ]
    }
}
</script>

<style>

</style>