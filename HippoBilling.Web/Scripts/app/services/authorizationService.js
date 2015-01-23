app.service("authorizationService", [
    "$q", "$http",function ($q, $http) {
        var service = {
            searchPatients: function (practiceId, keyword) {
                var defer = $q.defer();
                $http.get("/patients/search-patients?practiceId=" + practiceId + "&keyword=" + keyword)
                    .success(function (data) {
                        defer.resolve(data);
                    }).error(function (data) {
                        console.log("get patients error");
                    });
                return defer.promise;
            },
        };

        return service;
    }
]);