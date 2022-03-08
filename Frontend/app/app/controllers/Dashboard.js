app.controller("Dashboard",function($scope,$http,ajax){
    $scope.fname = "Dashboard";
    ajax.get("api/Employee/AssignWorks/?id="+localStorage.userId,success,error);
    function success(response){
      $scope.products=response.data;
      console.log(response);
    }
    function error(error){
        $scope.msg="No data found";
        console.log(msg);
    }

});