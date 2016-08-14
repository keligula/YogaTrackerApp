
(function () {
    "use strict";

    angular.module(appName)
             .controller('practiceListController', PracticeListController);

    PracticeListController.$inject = ['$scope', '$baseController', '$yogaService'];

    function PracticeListController($scope, $baseController, $yogaService) {

        var vm = this;
        vm.practices = null;
        
        //vm.yogiOptions = [{ YogiId: 1, YogiName: "Kelly" }, { YogiId: 2, YogiName: "Anthony" }];

        vm.$scope = $scope;
        vm.$yogaService = $yogaService;
    
        $baseController.merge(vm, $baseController);


        render();

        function render() {
            console.log("This is my list of yoga practices.")
            vm.$yogaService.getAllPractices(_onGetAllPracticesSuccess, _onGetAllPracticesError);

        };

        function _onGetAllPracticesSuccess(response) {
            vm.practices = response.data.items;
            console.log("this is", vm.practices);
        };

        function _onGetAllPracticesError(jqXhr, error) {
            vm.$alertService.error();
        };

        //function _getPracticesByYogi(yogiId) {
        //    console.log("Button is working");
        //    vm.$yogaService.getPracticeByYogiId(yogiId, _onGetByYogiSuccess, _onGetByYogiError);

        //};
       
        //function _onGetByYogiSuccess() {
        //    vm.practices = data.items;
        //    console.log("on get success", data)
        //};

        //function _onGetByYogiError(jqXhr, error) {
        //    vm.$alertService.error();
        //};

        //function _getAllPractices() {
        //    console.log("Button is working");
        //    vm.$yogaService.getAllPractices(_onGetAllPracticesSuccess, _onGetAllPracticesError);

        //};

        //function _onGetAllPracticesSuccess(data) {
        //    vm.practices = data.items;
        //    console.log("on get success", data)
        //};

        //function _onGetAllPracticesError(jqXhr, error) {
        //    vm.$alertService.error();
        //};


    }
})();
