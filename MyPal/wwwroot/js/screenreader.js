// text to speech web api
var msg = new SpeechSynthesisUtterance(document.documentElement.innerHTML);
var reader = window.speechSynthesis;

//text to speech for map page
function mapPagescreenReader() {
    reader = window.speechSynthesis;
    console.log(msg);
    console.log(reader.paused);
    console.log(reader.pending);
    console.log(reader.speaking);
    if (reader.paused == false && reader.pending == false && reader.speaking == false) {
        console.log("1");
        msg.lang = "en-GB";
        msg.rate = "0.75";
        msg.volume = "1";
        msg.text = 'The Campus Map, view map with pinpoints, View pinpoints with todays Events, Overlay: no overlay, level -2 parking, level -1, level 0, level 1. For navigation select desired start point or Present qr code, and the end point. Press Get Navigation for waypoint.';
        setTimeout(reader.speak(msg), 1000);
        return; // screen reader is currently speaking, transitioned pending -> speaking state    
    }
}
//text to speech for calendar page
function calendarPagescreenReader() {
    reader = window.speechSynthesis;
    console.log(msg);
    console.log(reader.paused);
    console.log(reader.pending);
    console.log(reader.speaking);
    if (reader.paused == false && reader.pending == false && reader.speaking == false) {
        console.log("1");
        msg.lang = "en-GB";
        msg.rate = "0.75";
        msg.volume = "1";
        msg.text = 'The Calendar with all public and private events, according to time and date. Itinerary, View the events with all their details. Or create a new private event';
        setTimeout(reader.speak(msg), 1000);
        return; // screen reader is currently speaking, transitioned pending -> speaking state    
    }
}
//text to speech for dashboard page
function dashboardPagescreenReader() {
    reader = window.speechSynthesis;
    console.log(msg);
    console.log(reader.paused);
    console.log(reader.pending);
    console.log(reader.speaking);
    if (reader.paused == false && reader.pending == false && reader.speaking == false) {
        console.log("1");
        msg.lang = "en-GB";
        msg.rate = "0.75";
        msg.volume = "1";
        msg.text = 'MyPal Dashboard. Showing all Available Public and Private Events, with all their details';
        setTimeout(reader.speak(msg), 1000);
        return; // screen reader is currently speaking, transitioned pending -> speaking state    
    }
}
//text to speech for AddPinpoint page
function addpinpointPagescreenReader() {
    reader = window.speechSynthesis;
    console.log(msg);
    console.log(reader.paused);
    console.log(reader.pending);
    console.log(reader.speaking);
    if (reader.paused == false && reader.pending == false && reader.speaking == false) {
        console.log("1");
        msg.lang = "en-GB";
        msg.rate = "0.75";
        msg.volume = "1";
        msg.text = "Add new pinpoint. With it's Name, Description, pinpoint and location on map";
        setTimeout(reader.speak(msg), 1000);
        return; // screen reader is currently speaking, transitioned pending -> speaking state    
    }
}