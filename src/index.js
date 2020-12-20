let express = require("express");
let app = express();
let port = 2337;

app.use(express.static("./src"));

app.listen(port, function () {
  console.log(`Listening at http://localhost:${port}`);
});