<template>
  <div class="hello">
<h1>{{ profile }}</h1>
  </div>
</template>

<script>
import axios from "axios";

export default {
  name: "HelloWorld",

  data() {
    return {
      profile: String,
    };
  },

  mounted() {

    console.log("Env", process.env)

    axios.get("http://instance_dcbackend/Home").then(res => {
      this.profile = res.data.message;
    });
  },
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
h3 {
  margin: 40px 0 0;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>
