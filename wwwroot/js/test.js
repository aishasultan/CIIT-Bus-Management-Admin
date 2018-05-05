
var driversMap = {};
var markersMap = {};
var latlng = {};
var locations = {};
var marker;
var markers;
var map;
var driver;
var driverLocation;

function drivers(lat, lng) {
    var dbRef = firebase.database().ref().child('DriverLocation');   
    var dbRef1 = firebase.database().ref().child('Driver');
    latlng = { lat: 33.6500053, lng: 73.1556737  };

  map = new google.maps.Map(document.getElementById('map'), {

        zoom: 10,
        center: latlng
    });

  var trafficLayer = new google.maps.TrafficLayer();
  trafficLayer.setMap(map);

    // Driver Location
    dbRef.on("child_added", function (snapshot) {
        
        var childKey = snapshot.key;
        locations = snapshot.val().l;
        driversMap[childKey] = locations;

        var infowindow = new google.maps.InfoWindow({
            content: "abc"
        });
        
        var marker = new google.maps.Marker({
            test: "(" + locations[0] + ", " + locations[1] + ")",
            position: new google.maps.LatLng(locations[0], locations[1]),
            title: "Latitude:" + locations[0] + " | Longitude:" + locations[1],
            map: map,
            id: childKey
        });
        console.log(locations[0]);
        console.log(locations[1]);
        markersMap[marker.id] = marker;
        console.log(markersMap[marker.id]);

        marker.addListener('click', function () {
            
            driverLocation.forEach(function (driverlocation) {
                driver.forEach(function (driver) {
                    var x = "(" + driverlocation.val().l[0] + ", " + driverlocation.val().l[1] + ")";
                    var display = "Driver: " + driver.val().username + "<br/>"+
                        "Bus: " + driver.val().busnumber + "<br/>" +
                        "Phone: " + driver.val().phonenumber;
                    if (driver.key === driverlocation.key && marker.test === x) {
                        console.log(marker.test);
                        console.log(x);
                  
                        new google.maps.InfoWindow({
                            content: display
                        }).open(map, marker);
                    }
                });
            });
           
        });
        
        console.log("marker added");

        dbRef.once("value", function (snapshot) {
            var data = snapshot;
            driverLocation = data;

            dbRef1.once('value', function (snapshot) {
                // Driver
                var data = snapshot;
                driver = data;
                
            });
        });
    });

    dbRef.on("child_changed", function (snapshot) {
        console.log("child change");
        console.log(markersMap);

        var childData = snapshot.val();
        console.log(childData);
        var childKey = snapshot.key;
        var longitude = snapshot.val().l[0];
        
        var latitude = snapshot.val().l[1];
        console.log(longitude + "" + latitude);
        if (childKey in driversMap && childKey in markersMap) {
            console.log(markersMap);
            console.log(driversMap);
            delete driversMap[childKey];
          
            driversMap[childKey] = childData;
            var latlng = {
                lat: longitude, lng: latitude
            };
           delete markersMap[childKey];
            drivers(latitude, longitude);
            console.log(latlng);
        }
    });
}

