app.controller("OpenProject",function($scope){
    //$scope.fname = "Tanvir";
    $http.get("https://localhost:44301/api/Project/open").
    then(function(resp){
        $scope.Project=resp.data;
    });
});