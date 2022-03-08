var app = angular.module("myApp", ["ngRoute"]);
app.config(["$routeProvider","$locationProvider",function($routeProvider,$locationProvider) {

    $routeProvider
    .when("/", {
        templateUrl : "views/pages/Login.html",
        controller: 'Login'
    })
    .when("/demo", {
        templateUrl : "views/pages/demopage.html",
        controller: 'demo'
    })
    .when("/demo2", {
        templateUrl : "views/pages/demo2.html",
          controller: 'demo2'
    })
    .when("/products", {
        templateUrl : "views/pages/products.html",
        controller: 'products'
    })
    .when("/post", {
        templateUrl : "views/pages/Post.html",
        controller: 'Post'
    })
    .when("/Dashboard", {
        templateUrl : "views/pages/Dashboard.html",
        controller: 'Dashboard'
    })
    .when("/Workhistory", {
        templateUrl : "views/pages/Workhistory.html",
        controller: 'Workhistory'
    })
    .when("/Wallet", {
        templateUrl : "views/pages/Wallet.html",
        controller: 'Wallet'
    })
    .when("/Application", {
        templateUrl : "views/pages/Application.html",
        controller: 'Application'
    })
    .when("/ApplicationHistory", {
        templateUrl : "views/pages/ApplicationHistory.html",
        controller: 'ApplicationHistory'
    })
    .when("/Profile", {
        templateUrl : "views/pages/Personalinfo.html",
        controller: 'Personalinfo'
    })
    .when("/ServiceInfo", {
        templateUrl : "views/pages/ServiceInfo.html",
        controller: 'ServiceInfo'
    })
    .when("/AssignService/:id", {
        templateUrl : "views/pages/AssignService.html",
        controller: 'AssignService'
    })
    .when("/ServiceDetails/:id", {
        templateUrl : "views/pages/ServiceDetails.html",
        controller: 'ServiceDetails'
    })
    .when("/Login", {
        templateUrl : "views/pages/Login.html",
        controller: 'Login'
    })
    .when("/Logout", {
        templateUrl : "views/pages/Login.html",
        controller: 'Logout'
    })
    .otherwise({
        redirectTo:"/"
    });
      //$locationProvider.html5Mode(true);
      //$locationProvider.hashPrefix('');
      //if(window.history && window.history.pushState){
      //$locationProvider.html5Mode(true);
  //}

}]);

app.config(function($httpProvider){
    $httpProvider.interceptors.push('interCeptor');
})