var app = angular.module('appmodule', []);

app.service('appservice', function ($http) {
    //The following function makes call to WEB API
    //with header as X-Version:ver
    this.get = function (ver) {
        var response = $http({
            url: "http://localhost:43886/api/EmployeeAPI",
            method: "GET",
            headers: {
                "X-Version":ver
            }
        });
        return response;
    };
});

app.controller('appcontroller', function ($scope, appservice) {
    //Version array, the value 0 is for default WEB API
    $scope.Versions = [0, 1, 2];
    $scope.Version = 1;

    $scope.getData = function () {
        var promise = appservice.get($scope.Version);
        promise.then(function (resp) {
            $scope.Employees = resp.data;
        }, function (err) {
            $scope.Message = "Error " + err.status;
        });
    };
});