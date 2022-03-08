app.controller("products",function($scope,$http,ajax){
    ajax.get("",success,error);
    function success(response){
      $scope.products=response.data;
    }
    function error(error){

    }

});
