
(function () {
    "use strict";

    angular.module(appName)
             .controller('kController', KController);

    KController.$inject = ['$scope', '$baseController', '$yogaService'];

    function KController($scope, $baseController, $yogaService) {

        var vm = this;
        $baseController.merge(vm, $baseController);
        vm.yogiOptions = [{ YogiId: 1, YogiName: "Kelly" }, { YogiId: 2, YogiName: "Anthony" }];

        vm.$scope = $scope;
        vm.$yogaService = $yogaService;

        vm.yogaForm = {};
        vm.yogaPractice = null;
        vm.rate = 2;
        vm.max = 5;
        //vm.percent = null;
        vm.isReadonly = false;
        //vm.overStar = null;

        vm.addYogaPractice = _addYogaPractice;
        vm.hoveringOver = _hoveringOver;
        vm.ratingStates = _ratingStates;


        render();

        function render() {
            console.log("This is my yoga site.")

        }

        //POST: add practice upon clicking Submit button on modal form
        function _addYogaPractice() {
            vm.showYogaPracticeErrors = true;

            var payload = vm.yogaPractice;

            if (vm.yogaForm.$valid) {

                vm.$yogaService.addPractice(payload, _onAddSuccess, _onAddError);
                console.log("Practice was added successfully with Ajax");

            } else {

                console.log("practice not added");
            }

        };

        // Something fishy with response.data.item and reloading of the modal //
        function _onAddSuccess(response) {
            vm.yogaPractice = response.item;
            console.log("practice is added!", vm.yogaPractice)
            //vm.yogaForm.$setPristine();
        };

        2
        function _onAddError(jqXhr, error) {
            vm.$alertService.error();
        };

        // Star Rating inside Practice Form Submit
        function _hoveringOver(value) {
            vm.overStar = value;
            vm.percent = 100 * (value / vm.max);
        };

        function _ratingStates() {
            [
            { stateOn: 'glyphicon-star', stateOff: 'glyphicon-star-empty' },
            { stateOff: 'glyphicon-off' }
            ]
        };
               

    }
})();
