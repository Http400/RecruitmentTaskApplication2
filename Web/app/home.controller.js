(function () {
    "use strict";

    angular
		.module('app')
		.controller('homeController', homeController);

    homeController.$inject = ['reservationService'];

    function homeController(reservationService) {
        var vm = this;
        vm.reservations = [];

        initController();

        function initController() {
            reservationService.getReservations()
                .then(function (response) {
                    console.log(response);
                    vm.reservations = response.data;
                }).catch(function (error) {
                    console.log(error);
                });
        }
    }

}());