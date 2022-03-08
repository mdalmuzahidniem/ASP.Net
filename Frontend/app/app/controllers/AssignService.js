app.controller("AssignService",function($scope,$http,ajax,$routeParams){
    $scope.fname = "Assign Service Details";
    ajax.get("api/Employee/Assign/ServiceInfo/?id="+$routeParams.id,success,error);
    function success(response){
      $scope.products=response;
      console.log(response);
      console.log($routeParams.id);
    }
    function error(error){
        $scope.msg="No data found";
        console.log(msg);
    }

});