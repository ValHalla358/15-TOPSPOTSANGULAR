(function() {
    'use strict';

    angular
        .module('myApp')
        .factory('TopSpotsFactory', TopSpotsFactory);

    TopSpotsFactory.$inject = ['$http', '$q'];

    /* @ngInject */
    function TopSpotsFactory($http, $q) {
        var service = {
            getTopSpots: getTopSpots,
            postTopSpot: postTopSpot
        };
        return service;

        ////////////////

        function getTopSpots() {

            var defer = $q.defer();
            // Get json file and alerting out if no data present
            $http({
                method: 'GET',
                url: 'http://localhost:56262/api/TopSpots'
            }).then(function(response) {
                if (typeof response.data === 'object') {
                    defer.resolve(response);
                } else {
                    defer.reject('no data found :(')
                }

                // error codeg
            }, function(error) {
                console.log(error);
                defer.reject(error);

            });

            return defer.promise;

        }

        function postTopSpot() {
            var defer = $q.defer();
            $http({
                method: 'POST',
                url: 'http://localhost:56262/api/TopSpots'
            }).then(function(response) {
                if (typeof response.data === 'object') {
                    defer.resolve(response);
                } else {
                    defer.reject('no data not added :(')
                }

                // error codeg
            }, function(error) {
                console.log(error);
                defer.reject(error);

            });
            return defer.promise;
        }
    }
})();

//reviewed by SS and GB
