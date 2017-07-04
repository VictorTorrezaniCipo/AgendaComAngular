
angular.module('sysAgenda')
    .service('ContatosService', function ($http, apiBaseUrl) {

        this.carregarTodos = function () {
            return $http({
                method: 'GET',
                url: apiBaseUrl + 'Contatos'
            });
        };

    });