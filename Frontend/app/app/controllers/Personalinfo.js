app.controller("Personalinfo",function($scope,$http,ajax){
    $scope.fname = "personal Info";
    ajax.get("api/Employee/Profile/?id="+localStorage.userId,success,error);
    function success(response){
      
      $scope.info=response.data;
      console.log(response);
    }
    function error(error){
        console.log(error);
    }
    //console.log(response.data.id);
    
    
    $scope.submit=function(){
      
      $scope.info.id=localStorage.userId;

      $http.post("https://localhost:44300/api/Employee/Profile/Edit",$scope.info)
      .then(function(resp){
          console.log(resp);
      } ,function(error){
      console.log(error);
      });

    };

});


