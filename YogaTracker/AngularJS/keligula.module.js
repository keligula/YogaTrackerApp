(function (moduleOptions) {
    "use strict";

    var defaultDependencies = [
        'ui.bootstrap',
        'ngRoute',
        'ngAnimate',
        'toastr'
    ];

    var arrOfDep = getModuleDependencies(moduleOptions, defaultDependencies);
    var app = angular.module(appName, arrOfDep);

    if (moduleOptions) {
        processModuleOptions(moduleOptions, app);
    }


    function getModuleDependencies(opts, defaults) {
        if (opts && opts.extraModuleDependencies) {
            var newItems = defaults.concat(opts.extraModuleDependencies);
            return newItems;
        }
        return defaults;
    }

    function processModuleOptions(opts, clientApp) {
        if (!opts) {
            return;
        }

        if (opts.runners) {
            for (var i = 0; i < opts.runners.length; i++) {
                var runner = opts.runners[i];
                clientApp.run(runner);
            }
        }

    }

})("Keligula");
