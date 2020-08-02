<template>
    <fieldset>
        <legend>
            Table
        </legend>
        <table class="ttable">
            <thead class="thead">
                <tr>
                    <td v-for="(title, index) in titles" v-bind:key="index">
                        {{title}}
                    </td>
                </tr>
            </thead>
            <tbody class="tbody">
                <tr v-for="(tr, index) in table" v-bind:key="index">
                    <td v-for="(value, key) in tr" v-bind:key="key">
                        {{value}}
                    </td>
                </tr>
            </tbody>
        </table>
    </fieldset>
</template>

<script>
export default {
    name: 'Table',
    data: function() {
        return {
        }
    },
    props: {
        titles: Array,
        table: Array
    }
}
</script>

<style>
.thead {
  background-color: black;
  color: white;
}
.tbody {
  background-color: green;
  color: black;
}
table.ttable {
    border: none;
    border-spacing: 0px;
}
</style>