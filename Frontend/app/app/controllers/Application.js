app.controller("Application",function($scope,$http,ajax,$window){
    $scope.fname = "Application";
    
    ajax.get("api/view/application",success,error);
    function success(response){
      console.log(response);
    }
    function error(error){
        console.log(error);
    }
    $scope.submit=function(){
        
        $scope.data.employee_id=localStorage.userId;

        $http.post("https://localhost:44300/api/Employee/Application/Send",$scope.data)
        .then(function(resp){
            console.log(resp);
            $window.location.reload();
        } ,function(error){
        console.log(error);
        });

    };
});