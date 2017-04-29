'use strict';

module.exports = angular.module('k3k.shell', [
    'ui.router',
])

.controller('HeaderController', require('./header.controller.js'))
.controller('MainController', require('./main.controller.js'))
.controller('LeftPanelController', require('./left-panel.controller.js'))
.config(k3kAppShellConfig);

k3kAppShellConfig.$inject = ['$stateProvider'];

function k3kAppShellConfig($stateProvider) {
    $stateProvider
        .state('app', {
            url: '',
            views: {
                '@': {
                    templateUrl: 'sections/shell/shell.html',
                    controller: 'MainController as ctrl'
                },
                'header@app': {
                    templateUrl: 'sections/shell/header.html'
                },
                'leftpanel@app': {
                    templateUrl: 'sections/shell/left-panel.html'
                },
                'rightpanel@app': {
                    templateUrl: 'sections/shell/right-panel.html'
                }
            }
        })
        .state('unauthorized', {
            url: '/unauthorized',
            views: {
                '@': {
                    templateUrl: 'sections/shell/unauthorized.html'
                }
            }
        })
}