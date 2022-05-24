var port = location.port;
var markers = [];
var level = 0;
var id = 0;
const iconBase = "../images/MarkerIcons/";
var map;
var canEditMap = false;
var markerAlreadySet = false;

// Function to initialise the map
function initMap() {

    // Creating the map centred over UOM with default zoom level 19 and the necessary settings
    map = new google.maps.Map(document.getElementById("map"), {
        center: { lat: parseFloat(35.901810199007215), lng: parseFloat(14.485197413626922) },
        zoom: 19,
        gestureHandling: "greedy",
        mapTypeId: 'satellite',
        tilt: 0
    });

    google.maps.event.addListener(map, "click", function (e) {
        if (canEditMap === true) {
            // lat and lng is available in e object
            document.getElementById('lat').value = e.latLng.lat()
            document.getElementById('long').value = e.latLng.lng()

            // Logic so that not all maps can be clicked and pinpoints are added
            if (markerAlreadySet === false) {
                markerAlreadySet = true;
                marker = new google.maps.Marker({
                    position: e.latLng,
                    map,
                });
            } else {
                marker.setMap(null);
                marker = new google.maps.Marker({
                    position: e.latLng,
                    map,
                });
            }
        }
    });

    // Setting the bounds of UOM. Bounds [zoom][coord.x][coord.y]
    // Bounds are generated from map tiler folder structure when tiles are created
    const bounds = {
        18: [
            [141619, 141620],
            [103028, 103028],
        ],
        19: [
            [283239, 283240],
            [206056, 206057],
        ],
        20: [
            [566478, 566480],
            [412112, 412115],
        ],
        21: [
            [1132956, 1132961],
            [824225, 824231],
        ],
        22: [
            [2265913, 2265922],
            [1648450, 1648462],
        ],
    };


    // Creating the ImageMapType for the image to be overlayed over the map
    const ictLvlMinOne = new google.maps.ImageMapType({
        getTileUrl: function (coord, zoom) {
            // If statement to not render the image if outside the bounds or outside the max/min zoom levels
            if (
                zoom < 18 ||
                zoom > 22 ||
                bounds[zoom][0][0] > coord.x ||
                coord.x > bounds[zoom][0][1] ||
                bounds[zoom][1][0] > coord.y ||
                coord.y > bounds[zoom][1][1]
            ) {
                return "";
            }
            // Returning the required tiles (map images) by requesting the specific png images
            // Link is according to the port being used 
            return [
                "https://localhost:",
                port,
                "/images/Level-1/",
                zoom,
                "/",
                coord.x,
                "/",
                coord.y,
                ".png",
            ].join("");
        },
        tileSize: new google.maps.Size(256, 256),
    });

    const ictLvlZero = new google.maps.ImageMapType({
        getTileUrl: function (coord, zoom) {
            if (
                zoom < 18 ||
                zoom > 22 ||
                bounds[zoom][0][0] > coord.x ||
                coord.x > bounds[zoom][0][1] ||
                bounds[zoom][1][0] > coord.y ||
                coord.y > bounds[zoom][1][1]
            ) {
                return "";
            }
            return [
                "https://localhost:",
                port,
                "/images/Level0/",
                zoom,
                "/",
                coord.x,
                "/",
                coord.y,
                ".png",
            ].join("");
        },
        tileSize: new google.maps.Size(256, 256),
    });

    const ictLvlMinTwo = new google.maps.ImageMapType({
        getTileUrl: function (coord, zoom) {
            // If statement to not render the image if outside the bounds or outside the max/min zoom levels
            if (
                zoom < 18 ||
                zoom > 22 ||
                bounds[zoom][0][0] > coord.x ||
                coord.x > bounds[zoom][0][1] ||
                bounds[zoom][1][0] > coord.y ||
                coord.y > bounds[zoom][1][1]
            ) {
                return "";
            }
            // Returning the required tiles (map images) by requesting the specific png images
            // Link is according to the port being used 
            return [
                "https://localhost:",
                port,
                "/images/Level-2/",
                zoom,
                "/",
                coord.x,
                "/",
                coord.y,
                ".png",
            ].join("");
        },
        tileSize: new google.maps.Size(256, 256),
    });

    const ictLvlOne = new google.maps.ImageMapType({
        getTileUrl: function (coord, zoom) {
            if (
                zoom < 18 ||
                zoom > 22 ||
                bounds[zoom][0][0] > coord.x ||
                coord.x > bounds[zoom][0][1] ||
                bounds[zoom][1][0] > coord.y ||
                coord.y > bounds[zoom][1][1]
            ) {
                return "";
            }
            return [
                "https://localhost:",
                port,
                "/images/Level1/",
                zoom,
                "/",
                coord.x,
                "/",
                coord.y,
                ".png",
            ].join("");
        },
        tileSize: new google.maps.Size(256, 256),
    });

    // Storing index.html radio buttons
    var radio = document.forms["level-selector"].elements["level"];
    // Looping through radio buttons to know when clicked
    for (var i = 0; i < radio.length; i++) {
        radio[i].onclick = function () {

            // If Level -2 is selected
            if (document.getElementById('level -2').checked) {
                // Setting level variable to current level
                level = -2;

                // Clear and change the overlay to display level -2 and write "Level -2 Parking" to let user know
                map.overlayMapTypes.clear();
                map.overlayMapTypes.push(ictLvlMinTwo);
                document.getElementById('status').innerHTML = "Level -2 Parking";

                // Show appropriate markers
                for (let j = 0; j < markers.length; j++) {
                    if (markers[j].level == -2) {
                        markers[j].marker.setMap(map);
                    } else {
                        markers[j].marker.setMap(null);
                    }
                }
            }
            if (document.getElementById('level -1').checked) {
                level = -1;

                // Showing the path on the current level only

                if (drawPathLvl0 != null) {
                    drawPathLvl0.setMap(null);
                }
                if (drawPathLvlMin1 != null) {
                    drawPathLvlMin1.setMap(map);
                }


                // Clear and change the overlay to display level -2 and write "Level -2 Parking" to let user know
                map.overlayMapTypes.clear();
                map.overlayMapTypes.push(ictLvlMinOne);
                document.getElementById('status').innerHTML = "Level -1";

                for (let j = 0; j < markers.length; j++) {
                    if (markers[j].level == -1) {
                        markers[j].marker.setMap(map);
                    } else {
                        markers[j].marker.setMap(null);
                    }
                }

            }
            if (document.getElementById('level 0').checked) {
                level = 0;

                // Showing the path on the current level only

                if (drawPathLvlMin1 != null) {
                    drawPathLvlMin1.setMap(null);
                }
                if (drawPathLvl0 != null) {
                    drawPathLvl0.setMap(map);
                }


                map.overlayMapTypes.clear();
                map.overlayMapTypes.push(ictLvlZero);
                document.getElementById('status').innerHTML = "Level 0";

                for (let j = 0; j < markers.length; j++) {
                    if (markers[j].level == 0) {
                        markers[j].marker.setMap(map);
                    } else {
                        markers[j].marker.setMap(null);
                    }
                }

            }

            if (document.getElementById('level 1').checked) {
                level = 1;

                map.overlayMapTypes.clear();
                map.overlayMapTypes.push(ictLvlOne);
                document.getElementById('status').innerHTML = "Level 1";

                for (let j = 0; j < markers.length; j++) {
                    if (markers[j].level == 1) {
                        markers[j].marker.setMap(map);
                    } else {
                        markers[j].marker.setMap(null);
                    }
                }
            }

            if (document.getElementById('no-overlay').checked) {
                level = -999;

                // Clearing the markers and overlay

                for (let j = 0; j < markers.length; j++) {
                    markers[j].marker.setMap(null);
                }
                map.overlayMapTypes.clear();
                document.getElementById('status').innerHTML = "No Overlay";
            }
            console.log(markers.length);
        }
    }
}

function addPinpoint() {
    // Sending request to API to retrieve all pinpoints
    var xhttp = new XMLHttpRequest();
    var url = "https://localhost:" + port + "/Pinpoints";
    xhttp.open("GET", url + "/GetAllPinpoints", true);
    xhttp.responseType = "text";
    xhttp.send();


    xhttp.onreadystatechange = function () {
        if (this.readyState == 4, this.status == 200) {
            if (this.responseText != "") {
                pinpnt = JSON.parse(this.responseText);

                pinpnt.forEach(function (data, index) {

                    console.log(data);
                    // Setting the floor level
                    if (data.floorId == 2)
                        level = -1
                    if (data.floorId == 3)
                        level = 0;
                    // Setting the icon type
                    if (data.pinpointTypesId == 1)
                        iconType = "Room.png";
                    else if (data.pinpointTypesId == 2)
                        iconType = "EntExt.png";
                    else if (data.pinpointTypesId == 3)
                        iconType = "Stairs.png";
                    else if (data.pinpointTypesId == 4)
                        iconType = "NavNode.png";
                    else if (data.pinpointTypesId == 5)
                        iconType = "Stairs.png";

                    long = parseFloat(data.longitude);
                    lat = parseFloat(data.latitude);

                    if (data.floorId == 3) {
                        var markerObj = {
                            id: data.id,
                            name: data.name,
                            level: level,
                            marker: new google.maps.Marker({
                                position: { lat: lat, lng: long },
                                icon: iconBase + iconType,
                                map
                            })
                        };

                        // Adding event listener for double-clicking to show pinpoint name
                        markerObj.marker.addListener("dblclick", function () {
                            // Showing pinpoint name on map
                            const coordInfoWindow = new google.maps.InfoWindow();
                            coordInfoWindow.setContent(String(data.id));
                            coordInfoWindow.setPosition(markerObj.marker.position);
                            coordInfoWindow.open(map);

                        });


                        // Adding the marker object to the markers array
                        markers.push(markerObj);
                    }
                       
                });
            }
        }
    };

    // Getting input from the map

    canEditMap = true;
    var latIn = document.getElementById('lat').value
    var lngIn = document.getElementById('long').value
    console.log(latIn);
    console.log(lngIn);
    var loc = new google.maps.Marker({
        position: { lat: parseFloat(latIn), lng: parseFloat(lngIn) },
        map,
    });

    
    
    window.onbeforeunload = confirmExit;
    function confirmExit() {
        canEditMap = false;
    }
}