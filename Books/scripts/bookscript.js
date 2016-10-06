var app = angular.module('booksModule', []);

app.controller('BooksController', ['$scope', '$http', function ($scope, $http) {
    const uri = "api/Books";
                
    $http.get(uri).success(function (data) {
        $scope.books = JSON.parse(data);
    });  

    $scope.update = function () {
        $http.get(uri).success(function (data) {
            $scope.books = JSON.parse(data);
        });  
    };

    $scope.addBook = function () {
        var bookName = $("#bookNameField").val();
        var authorName = $("#authorNameField").val();

        if (bookName === "" || authorName === "") {
            alert("Fields must be filled.");
        }

        var data = {
            'bookName': bookName,
            'authorName': authorName
        }
                    
        var config = {
            headers: {
                'Content-Type': 'application/json'
            }
        };

        $http.post("api/Books", JSON.stringify(data), config)
            .success(function () {
                $scope.update();
            })
            .error(function () {
                alert("Error.");
            });
    };
                
}]);