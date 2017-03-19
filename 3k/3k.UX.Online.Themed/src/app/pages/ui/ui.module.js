/**
 * @author k.danovsky
 * created on 12.01.2016
 */
(function () {
  'use strict';

  angular.module('3k.pages.ui', [
    '3k.pages.ui.typography',
    '3k.pages.ui.buttons',
    '3k.pages.ui.icons',
    '3k.pages.ui.modals',
    '3k.pages.ui.grid',
    '3k.pages.ui.alerts',
    '3k.pages.ui.progressBars',
    '3k.pages.ui.notifications',
    '3k.pages.ui.tabs',
    '3k.pages.ui.slider',
    '3k.pages.ui.panels',
  ])
      .config(routeConfig);

  /** @ngInject */
  function routeConfig($stateProvider) {
    $stateProvider
        .state('ui', {
          url: '/ui',
          template : '<ui-view  autoscroll="true" autoscroll-body-top></ui-view>',
          abstract: true,
          title: 'UI Features',
          sidebarMeta: {
            icon: 'ion-android-laptop',
            order: 200,
          },
        });
  }

})();
