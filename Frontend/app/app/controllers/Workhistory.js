app.controller("Workhistory",function($scope,$http,ajax){
    $scope.fname = "Work history";
    ajax.get("api/Employee/CompletedWork/?id="+localStorage.userId,success,error);
    function success(response){
      $scope.products=response.data;
      console.log(response);
    }
    function error(error){
        $scope.msg="No data found";
        console.log(msg);
    }

});
