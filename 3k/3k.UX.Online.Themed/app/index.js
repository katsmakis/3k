var config = require("app.config");

module.exports = angular.module('3k', [
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
.run(_3kAppRun)
.config(_3kAppConfig)
.constants("spa.config",
{
url: {
    login: "/login",
    root: "/index",
    unauthorized: "/unauthorized"
}
});

_3kAppRun.$inject = ["$rooteScope","$state","$stateParams","$location", "spa.config"];

function _3kAppRun(
    $rooteScope,
    $state,
    $stateParams,
    $location,
    spaConfig
    )
    {
    if ($lacation.$$path === ""){
        $state.transitionTo("app.index");
    }
};