app.controller("Project",function($scope){
    //$scope.fname = "Tanvir";
    $http.get("https://localhost:44301/api/Project/all").
    then(function(resp){
        $scope.Project=resp.data;
    });
});