const { microphone, stream, list, response } = require("./const");

var socket = io.connection("https://voicy-speaker.herokuapp.com/");

socket.on('audioMessage', function(audioChunks) {
    const audioBlob = new Blob(audioChunks);
    const audioUrl = URL.createObjectURL(audioBlob);
    const audio = new Audio(audioUrl);
    audio.play();
});

socket.on('allMessages', function(audioMessages){
    response.innerHTML = audioMessages;
});

socket.on('playAudio', ()=>{
    var audio  = document.getElementById("tempAudio");
    audio.play();
})

socket.on('user', function(countOfUsers){
    response.innerHTML = countOfUsers;//add div element countOfUsers into index.html
});

var contraints = {audio: true, video: false};
navigator.mediaDevices.getUserMedia(contraints)
 .then(mediaStream =>{
     var mediaRecorder = new mediaRecorder(mediaStream);
     var audioChunks = [];
     microphone.on('touchstart mousedown', function(e){
         mediaRecorder.start();
         console.log("recorder started");
         socket.emit('startRecording');
        });
        stream.on('touchstart mousedown', function(e){
            if (mediaRecorder.state!=='inactive'){
                mediaRecorder.stop();
                console.log("recorder stoped");
            }
            socket.emit('getAudioMessages');
        });

        list.on('touchstart mousedown', function(e){
            if (mediaRecorder.state!=='inactive'){
                mediaRecorder.stop();
                console.log("recorder stoped");
            }
            socket.emit('allMessages');            
        });

        mediaRecorder.addEventListener("dataavailable", event =>{
            audioChunks.push(event.data);
        });

        mediaRecorder.addEventListener("stop", () => {
            socket.emit('audioMessage', audioChunks);
            console.log("audiochunks emited");
            audioChunks.length = 0;
        });   

    })
 .catch(function(err) { console.log(err.name + ": " + err.message); });