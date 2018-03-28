
var driversMap = {};
var markersMap = {};
var latlng = {};
var locations = {};
var marker;
var markers;

function drivers(lat, lng) {
    definePopupClass();
    var dbRef = firebase.database().ref().child('DriverLocation');   
    
    latlng = { lat: 33.6500053, lng: 73.1556737  };

    var map = new google.maps.Map(document.getElementById('map'), {

        zoom: 10,
        center: latlng
    });
    var infowindow = new google.maps.InfoWindow();

    dbRef.on("child_added", function (snapshot) {
        //console.log(snapshot.val());

        var childKey = snapshot.key;
         locations = snapshot.val().l;
        
        console.log("Locations " + locations[0]+","+locations[1] + " size " + locations.length);
        //    console.log(latitude);
        driversMap[childKey] = locations;

        var nmarker = new google.maps.Marker({
            position: new google.maps.LatLng(locations[0], locations[1]),
            map: map,
            id: childKey
        });
        markers[childKey] = nmarker;
        
        console.log("marker added");

        popup = new Popup(
            new google.maps.LatLng(-33.866, 151.196),
            document.getElementById('content'));
        popup.setMap(map);

        //markersMap[marker.id] = marker;
        //var marker, i;

        //for (i = 0; i < locations.length; i++) {
        //    marker = new google.maps.Marker({
        //        position: new google.maps.LatLng(locations[i][1], locations[i][2]),
        //        map: map
        //    });
        //}
            //var marker = new google.maps.Marker({
            //    position: latlng,
            //    map: map,
            //    animation: google.maps.Animation.DROP,
            //    // icon: 'img/goodambulance.png',
            //    id: childKey
            //});
            // markersMap[marker.id] = marker;
        
    });

    dbRef.on("child_changed", function (snapshot) {
        var childData = snapshot.val();
        console.log(childData);
        var childKey = snapshot.key;
        var longitude = snapshot.val().l[0];
        var latitude = snapshot.val().l[1];
        //if (childKey in driversMap && childKey in markers) {
        //    delete driversMap[childKey];
        //    driversMap[childKey] = childData;
        //    var latlng = {
        //        lat: longitude, lng: latitude
        //    };
        //    markersMap[childKey].setPosition(latlng);
        //    delete markersMap[childKey];
        //    drivers(latitude, longitude);
        //    console.log(latlng);
        //}
        //var nmarker = new google.maps.Marker({
        //    position: new google.maps.LatLng(latitude, longitude),
        //    map: map,
        //    id: childKey
        //});
        //markers[childKey].setMap(null);
       // markers[childKey] = nmarker;
    });
}

//function initMap(lat, lng) {
    
    
//        var map = new google.maps.Map(document.getElementById('map'), {

//            zoom: 10,
//            center: latlng
//        });

//        var marker = new google.maps.Marker({
//            position: latlng,
//            map: map,
//            animation: google.maps.Animation.DROP,
//            // icon: 'img/goodambulance.png',
//            id: childKey
//        });
//        markersMap[marker.id] = marker;
//}


/** Defines the Popup class. */
function definePopupClass() {
    /**
     * A customized popup on the map.
     * @param {!google.maps.LatLng} position
     * @param {!Element} content
     * @constructor
     * @extends {google.maps.OverlayView}
     */
    Popup = function (position, content) {
        this.position = position;

        content.classList.add('popup-bubble-content');

        var pixelOffset = document.createElement('div');
        pixelOffset.classList.add('popup-bubble-anchor');
        pixelOffset.appendChild(content);

        this.anchor = document.createElement('div');
        this.anchor.classList.add('popup-tip-anchor');
        this.anchor.appendChild(pixelOffset);

        // Optionally stop clicks, etc., from bubbling up to the map.
        this.stopEventPropagation();
    };
    // NOTE: google.maps.OverlayView is only defined once the Maps API has
    // loaded. That is why Popup is defined inside initMap().
    Popup.prototype = Object.create(google.maps.OverlayView.prototype);

    /** Called when the popup is added to the map. */
    Popup.prototype.onAdd = function () {
        this.getPanes().floatPane.appendChild(this.anchor);
    };

    /** Called when the popup is removed from the map. */
    Popup.prototype.onRemove = function () {
        if (this.anchor.parentElement) {
            this.anchor.parentElement.removeChild(this.anchor);
        }
    };

    /** Called when the popup needs to draw itself. */
    Popup.prototype.draw = function () {
        var divPosition = this.getProjection().fromLatLngToDivPixel(this.position);
        // Hide the popup when it is far out of view.
        var display =
            Math.abs(divPosition.x) < 4000 && Math.abs(divPosition.y) < 4000 ?
                'block' :
                'none';

        if (display === 'block') {
            this.anchor.style.left = divPosition.x + 'px';
            this.anchor.style.top = divPosition.y + 'px';
        }
        if (this.anchor.style.display !== display) {
            this.anchor.style.display = display;
        }
    };

    /** Stops clicks/drags from bubbling up to the map. */
    Popup.prototype.stopEventPropagation = function () {
        var anchor = this.anchor;
        anchor.style.cursor = 'auto';

        ['click', 'dblclick', 'contextmenu', 'wheel', 'mousedown', 'touchstart',
            'pointerdown']
            .forEach(function (event) {
                anchor.addEventListener(event, function (e) {
                    e.stopPropagation();
                });
            });
    };
}