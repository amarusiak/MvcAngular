//require.config({
//    //baseUrl: 'js/lib',
//    baseUrl: '../Scripts',
//    paths: {
//        // the left side is the module ID,
//        // the right side is the path to
//        // the jQuery file, relative to baseUrl.
//        // Also, the path should NOT include
//        // the '.js' file extension. This example
//        // is using jQuery 1.9.0 located at
//        // js/lib/jquery-1.9.0.js, relative to
//        // the HTML page.

//        //jquery: 'jquery-1.9.0'
//        jquery: 'jquery-1.9.1.min'
//    }
//});


require.config({
    paths: {
        "jquery": 'http://code.jquery.com/jquery-1.9.1'
    }
});

require(["jquery"], function ($) {
    console.log($.fn.jquery);
});

require(
    // ['mymodule', 'jquery'],
    ['mymodule', 'jquery'],
    function (Module, $) {
        $('body').append(Module.foo);
    }
);
