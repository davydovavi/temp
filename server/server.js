const path = require('path');
const http = require('http');
const express = require('express');

const publicPath = path.join(__dirname, '../src');
const port = process.env.PORT || 3000;
var app = express();
var server = http.createServer(app);
var io = require('socket.io')(server);

var countOfUsers = 0;
var allAudioMessages = [];

app.use(express.static(publicPath));//

app.get('/', (req, res) => {
  res.sendFile('C:/Users/Виктория/Documents/WEB Summer Practice/index.html');
  //res.sendFile(path.join(__dirname, '../index.html'));
});

app.get('/converse.js', (req, res)=>{
  res.sendFile('C:/Users/Виктория/Documents/WEB Summer Practice/src/js/converse.js');
  //res.sendFile(path.join(__dirname, '../src/js/converse.js'));
});

app.get("/voices", (req, res)=>{
  res.send(allAudioMessages);
});

io.on('connection', (socket) => {
  console.log('New user connected');
  countOfUsers++;
  io.emit("user", countOfUsers);
  

  socket.on('audioMessage', function(message) {
    io.emit("audioMessage", message);
    allAudioMessages.push({timeStamp:Date(), audioBlob: message});
  });

  socket.on('getAudioMessages', ()=> {
    io.emit("audioMessage", allAudioMessages);
  });

  socket.on("startRecording", ()=>{
    io.emit("playAudio");
  });

  socket.on("allMessages", ()=>{
    io.emit("allMessages", allAudioMessages);
  });

  socket.on('disconnect', () => {
    console.log('User was disconnected');
    countOfUsers--;
    io.emit("user", countOfUsers);
  });

});

server.listen(port, () => {
  console.log(`Server is up on ${port}`);
});