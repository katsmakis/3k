'use strict';

angular.module('3k.configuration')
    .provider('appConfig', appConfigProvider);

function appConfigProvider() {
    var provider = this;
    provider.config = {};

    this.$get = appConfig;

    function appConfig() {
        return provider.config;
    }
}