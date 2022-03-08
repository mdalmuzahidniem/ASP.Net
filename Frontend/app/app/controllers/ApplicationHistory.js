app.controller("ApplicationHistory",function($scope,$http,ajax){
    $scope.fname = "Application History";
    ajax.get("api/Employee/Application/Histrory/?id="+localStorage.userId,success,error);
    function success(response){
      $scope.info=response.data;
      console.log(response);
    }
    function error(error){
        
        console.log("No Data found");
    }
});