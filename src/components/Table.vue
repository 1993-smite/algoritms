<template>
    <fieldset>
        <legend>
            Table
        </legend>
        <table class="ttable" v-show="isTableTr">
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
        <span v-show="!isTableTr">нет записей</span>
    </fieldset>
</template>

<script>
export default {
    name: 'Table',
    props: {
        titles: Array,
        table: Array
    },
    data: function() {
        return {
            
        }
    },
    computed: {
        isTableTr: function() {
            return this.table.length > 0;
        }
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