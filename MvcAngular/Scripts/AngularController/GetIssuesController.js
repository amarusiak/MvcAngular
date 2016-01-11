//here I am separating each angular controller to separate file for make it manageable 

//extending from previously created angular module in the previous part
angular.module('MyApp')
.controller('GetIssuesController', function ($scope, GetIssuesService) { //inject GetIssuesService
    $scope.Contact = null;
    GetIssuesService.GetIssues().then(function (d) {
        $scope.IssueList = d.data; // Success
    }, function () {
        alert('Failed'); // Failed
    });
})

 // here I have created a factory which is a popular way to create and configure services
.factory('GetIssuesService', function ($http) {
    var fac = {};
    fac.GetIssues = function () {
        return $http.get('/Issue/GetIssues');
    }
    return fac;
});