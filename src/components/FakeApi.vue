<template>
    <div>
        <hr/>
        <h3>
            Fake Api
        </h3>
        <select v-model="checkCount">
            <option 
                v-for="(count, index) in counts" 
                v-bind:key="index" 
                v-bind:value="count"
                >{{count}}</option>
            
        </select>
        <div v-for="(data, index) in datas" v-bind:key="index">
            <b>{{data.id}}</b>. {{data.title}}
            <hr/>
        </div>
    </div>
</template>

<script>

export default {
    name: 'FakeApi',
    data: function(){
        this.get();
        return {
            counts: [4,6,8,12,20],
            checkCount: 4,
            url: 'https://jsonplaceholder.typicode.com/posts',
            datas: []
        }
    },
    watch: {
        checkCount: function(){
            this.get();
        }
    },
    methods: {
        get: async function(){
            let context = this;
            await fetch(`${this.url}`)
                    .then(response => {
                            //console.log(response);
                            return response.json()
                        })
                    .then(json => {
                            context.datas = json;
                            //return console.log(json);
                        });
            
        }
    }
}
</script>