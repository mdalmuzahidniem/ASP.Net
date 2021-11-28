app.controller("EnrollRequests",function($scope){
    //$scope.fname = "Tanvir";
    $http.get("https://localhost:44301/api/Project/Request").
    then(function(resp){
        $scope.Project=resp.data;
    });
});