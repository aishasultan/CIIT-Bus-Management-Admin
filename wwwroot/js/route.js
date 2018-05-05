function initMap() {
    latlng = { lat: 33.6500053, lng: 73.1556737 };

    map = new google.maps.Map(document.getElementById('map'), {

        zoom: 10,
        center: latlng
    });
}