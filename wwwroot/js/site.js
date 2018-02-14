// Write your JavaScript code.

// Initialize Firebase
var config = {
    apiKey: "AIzaSyDJKWHkRz5w0a0OQ8EJI1woyrzv2Y8sSxE",
    authDomain: "final-year-project-188517.firebaseapp.com",
    databaseURL: "https://final-year-project-188517.firebaseio.com",
    projectId: "final-year-project-188517",
    storageBucket: "final-year-project-188517.appspot.com",
    messagingSenderId: "414362957154"
};
firebase.initializeApp(config);


// Get elements
//var object = document.getElementById('myform');
//var list = document.getElementById('list');

// Create Reference

var dbRef = firebase.database().ref().child('Driver');
var dbRef1 = firebase.database().ref().child('Student');
var dbRef2 = firebase.database().ref().child('DriverLocation');
var dbRef3 = firebase.database().ref().child('Feedback');

//var dbList = dbRef.child('yIIYu6SFObWBur1XV5JOAjliO3A3');


//Sync object changes
//dbRef.on('value', snap => object.innerText = JSON.stringify(snap.val(), null, 3));
//dbRef.on('value', snap => object.innerText = snap.val());
//dbRef.on('value', snap => console.log(snap.val()));


//Sync List changes
//dbList.on('child_added', snap => {
//    var li = document.createElement('li');
//    li.innerText = snap.val();
//    li.id = snap.key;
//    list.appendChild(li);
//});

//dbList.on('child_changed', snap => {

//    var liChanged = document.getElementById(snap.key);
//    liChanged.innerText = snap.val();
//});

//dbList.on('child_removed', snap => {
//    var liRemoved = document.getElementById(snap.key);
//    liRemoved.remove();
//});

