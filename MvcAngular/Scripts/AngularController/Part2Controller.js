//here I am separating each angular controller to separate file for make it manageable 

//extending from previously created angular module in the previous part
angular.module('MyApp') 
.controller('Part2Controller', function ($scope, ContactService) { //inject ContactService
    $scope.Contact = null;
    ContactService.GetLastContact().then(function (d) {
        $scope.Contact = d.data; // Success
    }, function () {
        alert('Failed'); // Failed
    });
})

 // here I have created a factory which is a popular way to create and configure services
.factory('ContactService', function ($http) { 
    var fac = {};
    fac.GetLastContact = function () {
        return $http.get('/Data/GetLastContact');
    }
    return fac;
});