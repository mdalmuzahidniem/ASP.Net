app.controller("Wallet",function($scope,$http,ajax){
    
    ajax.get("api/Employee/wallet/?id="+localStorage.userId,success,error);
    function success(response){
      $scope.products=response.data;
      
    }
    function error(error){
        $scope.msg="No data found";
        console.log(msg);
    }

});