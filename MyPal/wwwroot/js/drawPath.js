// Global variables
var drawPathLvl0, drawPathLvlMin1, len, lat, lng;

//function to turn on camera on html page
function turnOnCamera() {

    document.getElementById("preview").hidden = false;

    let scanner = new Instascan.Scanner({ video: document.getElementById('preview') });

    //listener for the scanning function
    scanner.addListener('scan', async function (content) {
        console.log(content);
        alert("QR Coordinate has been received");
        document.getElementById("preview").hidden = true;

        if (content == 'https://www.youtube.com/watch?v=dQw4w9WgXcQ&ab_channel=RickAstleyVEVO') {
            //Rick Roll Redirect
            location.href = content;
        } else {
            //set the key variable and get the pinpoint object
            var key = "CurrentLocation";
            await retreivePinpointObject(key, content);
            scanner.stop();
        }
    });

    Instascan.Camera.getCameras().then(function (cameras) {
        if (cameras.length > 0) {
            scanner.start(cameras[0]);
        } else {
            console.error('No cameras found.');
        }
    }).catch(function (e) {
        console.error(e);
    });
}

//function to get a pinpoint object based on the name passed
function retreivePinpointObject(key, pinpointQR_Url) {
    var port = location.port;
    var url = "https://localhost:" + port + "/Pinpoints";
    var xhttp = new XMLHttpRequest();
    var pinpointURL = url + pinpointQR_Url;
    xhttp.open("GET", pinpointURL, true);
    xhttp.responseType = 'text';
    xhttp.send();

    xhttp.onreadystatechange = async function () {
        if (this.readyState == 4, this.status == 200) {
            if (this.responseText != "") {
                var pinpoint = await JSON.parse(this.responseText);
                document.getElementById("startPointName").value = pinpoint.name;
                document.getElementById("startId").value = pinpoint.id;
                savePinpointAsSession(key, pinpoint);
            }
        }
    }
}

//function to reset everything back to default values
function ResetNavigation() {
    document.getElementById("startPointName").value = "";
    document.getElementById("endPointName").value = "";
    document.getElementById("startId").value = "";
    document.getElementById("endId").value = "";


    document.getElementById("GetNavigation").hidden = false;
    document.getElementById("UpdateNavigation").hidden = true;

}

async function RetreiveNavigation() {
    let startpoint = document.getElementById("startId").value;
    let endpoint = document.getElementById("endId").value;

    if (startpoint == "" && endpoint == "") {
        alert("You did not input any start on end points");
    }
    else if (startpoint == "") {
        alert("You forgot to add a starting Location");
    } else if (endpoint == "") {
        alert("You forgot to add an end Location");
    } else {
        startpoint = parseInt(startpoint);
        endpoint = parseInt(endpoint);
        document.getElementById("GetNavigation").hidden = true;

        //calling the calculate path function which in turn calls the navigation API
        calculatePath(startpoint, endpoint);
        document.getElementById("UpdateNavigation").hidden = false;
    }
}

function savePinpointAsSession(key, pinpoint) {
    var xhttp = new XMLHttpRequest();

    var port = location.port;
    var url = "https://localhost:" + port + "/Pinpoints";

    xhttp.open("POST", url + "/SetSessionLocation?key=" + key, true);
    xhttp.setRequestHeader("Content-type", "application/json");
    xhttp.responseType = 'json';
    /*console.log(pinpoint.name);
    console.log(JSON.stringify(pinpoint));*/
    xhttp.send(JSON.stringify(pinpoint));

    xhttp.onreadystatechange = function () {

        if ((this.readyState == 2 || this.readyState == 4) && this.status == 200) {
            //if (this.responseText != "") {
            //var pinObject = JSON.parse(this.response);
            //alert(pinObject);
            //}
        } else {
            alert("Something went wrong whilst setting Session Variable: " + key + " Status= " + this.status + " ReadyState= " + this.readyState);
        }
    }

}

function getSessionAsPinpoint(key) {
    var port = location.port;
    var url = "https://localhost:" + port + "/Pinpoints";
    var retreivedPinpoint;
    var xhttp = new XMLHttpRequest();
    xhttp.open("GET", url + "/GetSessionLocation?key=" + key, true);
    //xhttp.responseType = 'text';
    xhttp.send();

    xhttp.onreadystatechange = function () {
        if (this.readyState == 4, this.status == 200) {
            if (this.responseText != "") {
                retreivedPinpoint = JSON.parse(this.responseText);
                console.log("From Get Location Session API");
                //console.log(pinpoint);
            }
        }
    }
    return retreivedPinpoint;
}


function calculatePath(start, end) {
    var countLvl0 = 0;
    var countLvlMin1 = 0;
    var path = [];
    var markerListLvl0 = [];
    var markerListLvlMin1 = [];
    var formattedCoord0 = [];
    var formattedCoordMin1 = [];
    var coordinatesLvl0 = [];
    var coordinatesLvlMin1 = [];
    var markerLvl0Ids = [];
    var markerLvlMin1Ids = [];
    let request = new XMLHttpRequest();

    document.getElementById('pastePath').innerHTML = 'Calculating path';

    // Gending a request to the navigation API with the user selected start and end nodes
    request.open('GET', 'https://localhost:' + port + '/Pinpoints/GetNavigationId?start=' + start + '&end=' + end);
    request.send();
    request.onload = () => {
        path = JSON.parse(request.response);
        console.log("Outputting path: " + path);
        var len = path.length;
        var pathMarkers = new Array(len);
        for (var i = 0; i < len; i++) {
            pathMarkers[i] = 0;
        }
        console.log(pathMarkers);


        for (var i = 0; i < len; i++) {
            //storing the path nodes
            /*markers.find(element => {
                *//*console.log(element);*//*
                if (element.id === path[i]) {

                }
            });*/
            let specificMarker = null;
            if (specificMarker === null) {
                specificMarker = markers.find(({ id }) => id === path[i]);
            }
            console.log("Path at " + i + ": " + path[i]);
            console.log("Logging specific marker: " + specificMarker);
            pathMarkers[i] = specificMarker;


            console.log("Outputting PathMarkers[i] at i: "+i);
            console.log(pathMarkers[i]);
            //if current path node is level 0
            if (pathMarkers[i].level == 0) {
                //returning the position of the current marker and storing in array
                markerListLvl0[countLvl0] = pathMarkers[i].marker.position + '';
                markerLvl0Ids[countLvl0] = pathMarkers[i].id;

                //formatting the coordinates and storing in lat lng variables
                formattedCoord0[countLvl0] = markerListLvl0[countLvl0].replace(' ', '');
                formattedCoord0[countLvl0] = markerListLvl0[countLvl0].split(', ');
                formattedCoord0[countLvl0][0] = formattedCoord0[countLvl0][0].replace('(', '');
                formattedCoord0[countLvl0][1] = formattedCoord0[countLvl0][1].replace(')', '');
                lat = parseFloat(formattedCoord0[countLvl0][0]);
                lng = parseFloat(formattedCoord0[countLvl0][1]);

                //creating new Google Maps LatLng object with the latitude and longitude obtained above
                coordinatesLvl0[countLvl0] = new google.maps.LatLng(lat, lng);
                countLvl0++;
            }
            else if (pathMarkers[i].level == -1) {
                markerListLvlMin1[countLvlMin1] = pathMarkers[i].marker.position + '';
                markerLvlMin1Ids[countLvlMin1] = pathMarkers[i].id;

                formattedCoordMin1[countLvlMin1] = markerListLvlMin1[countLvlMin1].replace(' ', '');
                formattedCoordMin1[countLvlMin1] = markerListLvlMin1[countLvlMin1].split(', ');
                formattedCoordMin1[countLvlMin1][0] = formattedCoordMin1[countLvlMin1][0].replace('(', '');
                formattedCoordMin1[countLvlMin1][1] = formattedCoordMin1[countLvlMin1][1].replace(')', '');
                lat = parseFloat(formattedCoordMin1[countLvlMin1][0]);
                lng = parseFloat(formattedCoordMin1[countLvlMin1][1]);

                coordinatesLvlMin1[countLvlMin1] = new google.maps.LatLng(lat, lng);
                countLvlMin1++;
            }
        }
        // Writing the path on the HTML page
        document.getElementById('pastePath').innerHTML = markerLvl0Ids + '<br>' + markerLvlMin1Ids;

        // Clearing the path if there already is one
        if (drawPathLvl0 != null) {
            drawPathLvl0.setMap(null);
        }

        // Creating the path object for Level 0 with the obtained coordinates
        drawPathLvl0 = new google.maps.Polyline({
            path: coordinatesLvl0,
            geodesic: true,
            strokeColor: "#FF0000",
            strokeOpacity: 1.0,
            strokeWeight: 2,
        });

        if (drawPathLvlMin1 != null) {
            drawPathLvlMin1.setMap(null);
        }

        drawPathLvlMin1 = new google.maps.Polyline({
            path: coordinatesLvlMin1,
            geodesic: true,
            strokeColor: "#FF0000",
            strokeOpacity: 1.0,
            strokeWeight: 2,
        });

        // Draws the path of the current floor selected
        if (document.getElementById('level 0').checked) {
            drawPathLvlMin1.setMap(null);
            if (drawPathLvl0 != null) {
                drawPathLvl0.setMap(map);
            }
        }

        if (document.getElementById('level -1').checked) {
            drawPathLvl0.setMap(null);
            if (drawPathLvlMin1 != null) {
                drawPathLvlMin1.setMap(map);
            }
        }
    }
}