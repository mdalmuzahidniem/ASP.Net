app.factory("interCeptor",function($location){
    return{
        'request': function(config){
            console.log("intercepted");
            config.headers.Authorization=localStorage.getItem('token');
            return config;
        },
        'responseError': function(rejection){
            $location.path("/Login");
        }
    }
});