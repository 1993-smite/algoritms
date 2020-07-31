<template>
    <div>
        <h2>
            {{ msg }}
        </h2>
        <h3>
            For test
        </h3>
        <h3>
            {{ txt }}
        </h3>
    </div>
</template>

<script>
export default {
    name: 'App',
    data: function(){
        return {
            msg: 'test',
        }
    },
    props: {
        txt: String
    }
}
</script>