(function() {
  'use strict';

  angular
    .module('3k')
    .run(runBlock);

  /** @ngInject */
  function runBlock($log) {

    $log.debug('runBlock end');
  }

})();
