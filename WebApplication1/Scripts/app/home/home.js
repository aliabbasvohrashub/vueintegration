var obj = new Vue({
    el: "#home",
    ready: function () {
        loadMsg();
    },
    data: {
        message: "Hello from vue js"
    },
    methods: {
        loadMsg: {
            message : "Hi from vue js"
        }
    }
});