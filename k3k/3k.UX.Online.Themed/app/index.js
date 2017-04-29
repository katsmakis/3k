var config = require("app.config");

module.exports = angular.module('k3k', [
  'ngAnimate',
  'ui.bootstrap',
  'ui.sortable',
  'ui.router',
  'ngTouch',
  'toastr',
  'smart-table',
  "xeditable",
  'ui.slimscroll',
  'ngJsTree',
  'angular-progress-button-styles',
  require("./sections/configuration/config.module.js").name,
  require("./sections/shell/shell.module.js").name
  //require("./sections/configuration/config.module.js").name,
  //require("./sections/configuration/config.module.js").name,
])
.run(k3kAppRun)
.config(k3kAppConfig)
.constants("spa.config",
{
url: {
    login: "/login",
    root: "/index",
    unauthorized: "/unauthorized"
}
});

k3kAppRun.$inject = ["$rooteScope","$state","$stateParams","$location", "spa.config", "$window"];

function k3kAppRun(
    $rooteScope,
    $state,
    $stateParams,
    $location,
    spaConfig,
    $window
    )
    {
    if ($lacation.$$path === ""){
        $state.transitionTo("app.index");
    }

    $root.$state = $state;
    $root.$stateParams = $stateParams;
    $rooteScope.$on("$stateChangedSuccess",
        function (event, toState) {
            
            validateLocation();
            if ($window.ga) {
                $window.ga('send', 'pageview', { page: $location.path() });
            }
            event.targetScope.$watch("$viewContentLoaded",
                function() {

                    angular.element("html, body, #content").animate({ scrollTop: 0 }, 200);

                    setTimeout(function() {
                        angular.element("#wrap").css("visibility", "visible");

                        if (!angular.element(".dropdown").hasClass("open")) {
                            angular.element(".dropdown").find(" > ul").slideUp();
                        }
                    },
                    200);
                });
            $rootScope.containerClass = toState.containerClass;
        });

        

        function validateLocation() {

            var locationPath = $location.path(),
                currentStateName = $state.current.name,
                loginUrl = spaConfig.url.login,
                unauthorizedUrl = spaConfig.url.unauthorized,
                rootUrl = spaConfig.url.root;

            if (locationPath != loginUrl) {
                $log.debug("session is invalid - routing to '{", loginUrl, "}' ");
                $location.path(loginUrl).replace();
                return;
            }
        }
    }


    k3kAppConfig.$inject = [
        "$urlRouterProvider", "spa.config", "$httpProvider", "dialogsProvider", "toastrConfig"
    ];

    function k3kAppConfig($urlRouterProvider,
        spaConfig,
        $httpProvider,

        dialogsProvider,
        toastrConfig) {
        $urlRouterProvider.otherwise(spaConfig.url.root);

        //$httpProvider.interceptors.push("httpInterceptorService");


        dialogsProvider.useBackdrop("static");
        dialogsProvider.useEscClose(true);


        angular.extend(toastrConfig,
        {
            closeButton: true,
            autoDismiss: false,
            progressBar: true,
            maxOpened: 0,
            newestOnTop: true,
            positionClass: "toast-bottom-right"
        });
    }