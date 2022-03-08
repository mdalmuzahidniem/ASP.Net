app.controller("Login",function($scope,$http,$location){
    $scope.fname = "Login";

    $scope.login=function(){
        $http.post("https://localhost:44300/api/Login",$scope.data)
        .then(function(resp){
            console.log(resp.data);
            localStorage.setItem("token",resp.data.accessToken);
            localStorage.setItem("userId", resp.data.userId);

            $location.path("/Dashboard");

        },function(err){
            console.log(err);
            console.log("Error");
        });
    };
});