
angular.module('sysAgenda')
    .config(function ($routeProvider) {
        $routeProvider
            .when('/contatos', {
                templateUrl: 'components/contatos/contatos.html',
                controller: 'ContatosController as cont',
                resolve: {                     //Nome do service
                    registrosReponse: function (ContatosService) {
                        return Contatos.carregarTodos();
                    }
                }
            });
    });