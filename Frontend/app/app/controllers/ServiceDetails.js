app.controller("ServiceDetails",function($scope,$http,ajax,$routeParams){
    $scope.fname = "Service Details";
    ajax.get("api/Order/ServiceDetails/?id="+$routeParams.id,success,error);
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