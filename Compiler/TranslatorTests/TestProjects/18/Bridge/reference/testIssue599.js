﻿(function (globals) {
    "use strict";

    Bridge.define('TestIssue599.Issue599', {
        statics: {
            config: {
                init: function () {
                    Bridge.ready(this.main);
                }
            },
            main: function () {
                Bridge.Console.log(new TestIssue599.Issue599()._something);
            }
        },
        _something: "HI!"
    });
    
    
    
    Bridge.init();
})(this);
