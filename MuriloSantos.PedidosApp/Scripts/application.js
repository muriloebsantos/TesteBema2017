var myApp = angular.module('PedidosApp', []);

myApp.controller('CriarPedidoController', function ($scope, $http) {
    $scope.produtoId = '';
    $scope.pedido = {
        DataEntrega : '',
        Itens : { }
    };

    $scope.init = function () {
        $scope.carregarClientes();
        $scope.carregarProdutos();
    };

    $scope.carregarClientes = function () {
        $http.get('/api/clientes')
            .then(function successCallback(response) {
                $scope.clientes = response.data;
            }
           );
    };

    $scope.carregarProdutos = function () {
        $http.get('/api/produtos')
            .then(function successCallback(response) {
                $scope.produtos = response.data;
            }
           );
    };

    $scope.addItem = function () {
        var config = {
            method: "PUT",
            url: '/api/pedidos/' + $scope.produtoId,
            data: $scope.pedido,
            headers: {
                'Content-Type': 'application/json; charset=utf-8'
            }
        };

         $http(config).then(function successCallback(response) {
             $scope.pedido = response.data;
             $scope.validationResult = undefined;
         });
    };

    $scope.removeItem = function (id) {
        if (!confirm("Deseja realmente remover esse produto?"))
            return;

        var config = {
            method: "DELETE",
            url: '/api/pedidos/' + id,
            data: $scope.pedido,
            headers: {
                'Content-Type': 'application/json; charset=utf-8'
            }
        };

        $http(config).then(function successCallback(response) {
            $scope.pedido = response.data;
        });
    };

     $scope.save = function () {
        var config = {
            method: "POST",
            url: '/api/pedidos/',
            data: $scope.pedido,
            headers: {
                'Content-Type': 'application/json; charset=utf-8'
            }
        };

         $http(config).then(function successCallback(response) {
             $scope.validationResult = response.data;

             if ($scope.validationResult.IsValid) {
                 alert("Pedido salvo com sucesso");
                 $scope.pedido = { };
             }
         });
    };

    $scope.init();

});

