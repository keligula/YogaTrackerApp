(function () {
    "use strict";

    angular.module(appName)
             .factory('$yogaService', yogaServiceFactory);

    yogaServiceFactory.$inject = ['$http', '$baseService'];

    function yogaServiceFactory($http, $baseService) {

        var svc = this;
        $.extend(svc, $baseService);
        svc.test = _test;

        svc.addPractice = _addPractice;
        svc.updatePracticeById = _updatePracticeById;
        svc.getPracticeByYogiId = _getPracticeByYogiId;
        svc.getAllPractices = _getAllPractices;

        
        // POST: Ajax call to add practice
        function _addPractice(payload, onAddSuccess, onAddError) {

            $http.post("/api/yoga/practices/", payload).then(onAddSuccess, onAddError);
        };

        // PUT: Ajax call to update practice
        function _updatePracticeById(payload, practiceId, onUpdateSuccess, onUpdateError) {

            $http.put("/api/yoga/" + practiceId, payload, practiceId).then(onUpdateSuccess, onUpdateError);
        };

        // GET: All Practices by YogiId
        function _getPracticeByYogiId(yogiId, onGetByYogiSuccess, onGetByYogiError) {

            $http.get("/api/yoga" + yogiId).then(onGetByYogiSuccess, onGetByYogiError);
        };

        // GET: All Practices / Full Index
        function _getAllPractices(onGetAllPracticesSuccess, onGetAllPracticesError) {

            $http.get("/api/yoga").then(onGetAllPracticesSuccess, onGetAllPracticesError);
        };

        return svc;


    }
})();
