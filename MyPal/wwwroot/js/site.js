

/*
// Function to GetAllPinpoints
function GetAllPinpoints() {
    var port = location.port;
    url = "https://localhost:" + port + "/Pinpoints";
    markers = [];
    var iconType;
    var level = 0;

    //sending request to API to retrieve all pinpoints
    var xhttp = new XMLHttpRequest();
    xhttp.open("GET", url + "/GetAllPinpoints", true);
    xhttp.responseType = "text";
    xhttp.send();

    xhttp.onreadystatechange = function () {
        console.log(xhttp.responseText);
        if (this.readyState == 4, this.status == 200) {
            var jsonPinpoints = JSON.parse(xhttp.responseText);
            for (var element in jsonPinpoints) {
                // Setting the floor level
                if (parseInt(element.FloorId) == 2)
                    level = -1
                if (parseInt(element.FloorId) == 3)
                    level = 0;
                //setting the icon type
                if (parseInt(element.PinpointTypesId) == 1)
                    iconType = "Room.png";
                else if (parseInt(element.PinpointTypesId) == 2)
                    iconType = "EntExt.png";
                else if (parseInt(element.PinpointTypesId) == 3)
                    iconType = "Stairs.png";

                var markerObj = {
                    id: element.Id,
                    name: element.Name,
                    level: level,
                    marker: new google.maps.Marker({
                        position: { lat: parseFloat(element.Latitude), lng: parseFloat(element.Longitude) },
                        icon: iconBase + iconType,
                        map
                    })
                };


                // Adding the marker object to the markers array
                markers.push(markerObj);

                // Clicking the no overlay option in order to not show any pinpoints on page load
                document.getElementById('no-overlay').click();
            }
        }
    };
}
*/
    
    



//returning all pinpoints from database
function GetAllPinpoints() {
    var port = location.port;
    url = "https://localhost:" + port + "/Pinpoints";
    var iconType;
    var level = 0;
    var iconType;
    var pinpnt;
    var long;
    var lat;

    map = new google.maps.Map(document.getElementById("map"), {
        center: { lat: parseFloat(35.901810199007215), lng: parseFloat(14.485197413626922) },
        zoom: 19,
        gestureHandling: "greedy",
        mapTypeId: 'satellite',
        tilt: 0
    });

    //sending request to API to retrieve all pinpoints
    var xhttp = new XMLHttpRequest();
    xhttp.open("GET", url + "/GetAllPinpoints", true);
    xhttp.responseType = "text";
    xhttp.send();

    xhttp.onreadystatechange = function () {
        if (this.readyState == 4, this.status == 200) {
            if (this.responseText != "") {
                pinpnt = JSON.parse(this.responseText);
                console.log(pinpnt);
                pinpnt.forEach(function (data, index) {

                    console.log(data);
                    //setting the floor level
                    if (data.floorId == 2)
                        level = -1
                    if (data.floorId == 3)
                        level = 0;
                    //setting the icon type
                    if (data.pinpointTypesId == 1)
                        iconType = "Room.png";
                    else if (data.pinpointTypesId == 2)
                        iconType = "EntExt.png";
                    else if (data.pinpointTypesId == 3)
                        iconType = "Stairs.png";
                    else if (data.pinpointTypesId == 4)
                        iconType = "";

                    long = parseFloat(data.longitude);
                    lat = parseFloat(data.latitude);

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

                    console.log(long + " " + lat);

                    /*
                    //adding event listener for double-clicking to show pinpoint name
                    markerObj.marker.addListener("dblclick", function () {
                        const coordInfoWindow = new google.maps.InfoWindow();
                        coordInfoWindow.setContent(String(data.pinpointName));
                        coordInfoWindow.setPosition(markerObj.marker.position);
                        coordInfoWindow.open(map);

                    });

                    //adding event listener to set the clicked pinpoint as the start point
                    markerObj.marker.addListener("click", function () {

                        document.getElementById("startPointName").value = markerObj.name;
                        document.getElementById("startId").value = markerObj.id;
                    });

                    ////adding event listener to set the right-clicked pinpoint as the end point
                    markerObj.marker.addListener("rightclick", function () {

                        document.getElementById("endPointName").value = markerObj.name;
                        document.getElementById("endId").value = markerObj.id;
                        savePinpointAsSession("EndLocation", data);
                    });
                    */

                    //adding the marker object to the markers array
                    markers.push(markerObj);
                    //clicking the no overlay option in order to not show any pinpoints on page load
                    document.getElementById('no-overlay').click();
                });
            }
        }
    };
}