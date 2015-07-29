/**
 * Created by IVAN on 7/29/2015.
 */

angular.module("ShopApp", ["ngRoute", "ShopApp.Services", "ShopApp.Controllers"])

.config(["$routeProvider", function($routeProvider){
        $routeProvider
            .when("/shops", {
                templateUrl:"AppUi/Views/shopsView.html",
                controller:"shopsController"
            })
            .when("/shop/:id/products", {
                templateUrl:"AppUi/Views/productsView.html",
                controller:"productsController"
            })
            .otherwise({
                redirectTo:"/shops"
            });
    }]);