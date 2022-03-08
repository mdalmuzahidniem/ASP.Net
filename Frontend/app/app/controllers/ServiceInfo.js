app.controller("ServiceInfo",function($scope,$http,ajax){
    $scope.fname = "personal Info";
    ajax.get("api/Employee/Service/Catagory/?id="+localStorage.userId,success,error);
    function success(response){
      $scope.info=response.data;
      console.log(response);
    }
    function error(error){
        $scope.msg="No data found";
        console.log(msg);
    }
    
    $scope.submit=function(){
      //alert("Submitted");
      
      var data={
        sta: $scope.status,

      
      };
      ajax.get("api/Employee/WorkStatus/Change/?id="+localStorage.userId+"&status="+data.sta,success,error);
      console.log(data.sta);
      function success(response){
        $scope.info=response.data;
      }
      function error(error){
        $scope.msg="No data found";
        console.log(msg);
      }
    };

});
