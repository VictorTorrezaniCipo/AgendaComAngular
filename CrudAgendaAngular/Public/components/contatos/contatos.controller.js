
angular.module('sysAgenda')
    .controller('ContatosController', function (registrosResponse, ContatosServices) {

        this.registros = registrosResponse.data;
    });