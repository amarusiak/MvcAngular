/// <reference path="angular.min.js" />

(function () {
    //Create a Module 
    // Will use ['ng-Route'] when we will implement routing
    var app = angular.module('MyApp', ['ngRoute']);

    //Create a Controller
    app.controller('HomeController',
        function ($scope) {  // here $scope is used for share data between view and controller
            // $scope.Message = " Part1 Message .";
            $scope.Message = " Part1 : Work Message. ";
        });
})();