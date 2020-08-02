<template>
  <div id="app">
    <img alt="Vue logo" src="./assets/logo.png">
    <HelloWorld msg="Welcome to Your Vue.js App"/>
    <Test v-bind:txt="msg" />
    <Books/>
    <FakeApi/>
    <Table v-bind:titles="table.titles" v-bind:table="table.list"/>
  </div>
</template>

<script>
import HelloWorld from './components/HelloWorld.vue'
import Test from './components/Test.vue'
import Books from './components/Books.vue'
import FakeApi from './components/FakeApi.vue'
import Table from './components/Table.vue'

export default {
  name: 'App',
  data: function(){
      return {
        msg: 'Hello, dude',
        table: {
          titles: ['Id','LastName', 'Name'],
          list: [
            {
              Id: 1,
              LastName: "Nevsky",
              Name: "Alex"
            },
            {
              Id: 2,
              LastName: "Romanov",
              Name: "Petr"
            },
            {
              Id: 3,
              LastName: "Stalin",
              Name: "Iosif"
            }
          ]
        }
      }
  },
  components: {
    HelloWorld,
    Test,
    Books,
    FakeApi,
    Table
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
