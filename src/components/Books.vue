<template>
    <div>
        <h3>
            Books
        </h3>
        <hr/>
        <div v-for="book in books" v-bind:key="book.Id">
            {{book.Id}}
            {{book.Name}}
            <hr/>
        </div>
    </div>
</template>

<script>

import books from './json/data.json';

export default {
    name: 'Books',
    data: function(){
        return {
            msg: 'test',
            books,
        }
    }
}
</script>