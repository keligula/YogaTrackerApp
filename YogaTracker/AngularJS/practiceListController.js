
(function () {
    "use strict";

    angular.module(appName)
             .controller('practiceListController', PracticeListController);

    PracticeListController.$inject = ['$scope', '$baseController', '$yogaService'];

    function PracticeListController($scope, $baseController, $yogaService) {

        var vm = this;
        vm.practices = null;
        
        vm.$scope = $scope;
        vm.$yogaService = $yogaService;
    
        $baseController.merge(vm, $baseController);

        render();

        function render() {
            console.log("This is the list of all yoga practices.")
            vm.$yogaService.getAllPractices(_onGetAllPracticesSuccess, _onGetAllPracticesError);
        };

        function _onGetAllPracticesSuccess(response) {
            vm.practices = response.data.items;
            console.log("this is", vm.practices);
        };

        function _onGetAllPracticesError(jqXhr, error) {
            vm.$alertService.error();
        };

    }
})();
