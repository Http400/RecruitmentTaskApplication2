(function () {
    'use strict';

    angular
        .module('app')
        .service('reservationService', reservationService);

    reservationService.$inject = ['$http'];

    function reservationService($http) {
        return {
            getReservations: _getReservations
        }

        function _getReservations() {
            return $http.get('/api/Reservation/GetReservations');
        }
    }
})();