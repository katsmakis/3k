﻿'use strict';

module.exports = angular.module('k3k.configuration', [])
.config(appConfigConfigure);

var config = require('app.config');

appConfigConfigure.$inject = ['appConfigProvider'];

function appConfigConfigure(appConfigProvider) {
    appConfigProvider.config = config;

   
}

require('./app-config.js');