'use strict';

angular.module('k3k.shell')

MainController.$inject = ['$scope', '$http', '$state', '$interval', '$rootScope'];

function MainController($scope, $http, $state, $interval, $rootScope) {
    var ctrl = this;

    ctrl.main = {
        title: 'k3k'

    }
}