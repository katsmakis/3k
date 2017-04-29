'use strict';

angular.module('k3k.configuration')
    .provider('appConfig', appConfigProvider);

function appConfigProvider() {
    var provider = this;
    provider.config = {};

    this.$get = appConfig;

    function appConfig() {
        return provider.config;
    }
}