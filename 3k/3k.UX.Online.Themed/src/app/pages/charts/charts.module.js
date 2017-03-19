/**
 * @author v.lugovsky
 * created on 16.12.2015
 */
(function () {
  'use strict';

  angular.module('3k.pages.charts', [
      '3k.pages.charts.amCharts',
      '3k.pages.charts.chartJs',
      '3k.pages.charts.chartist',
      '3k.pages.charts.morris'
  ])
      .config(routeConfig);

  /** @ngInject */
  function routeConfig($stateProvider) {
    $stateProvider
        .state('charts', {
          url: '/charts',
          abstract: true,
          template: '<div ui-view  autoscroll="true" autoscroll-body-top></div>',
          title: 'Charts',
          sidebarMeta: {
            icon: 'ion-stats-bars',
            order: 150,
          },
        });
  }

})();
