var contentContainerId = 'page-content';

$(function () {
    navigateToHashAddress();
});

$(window).on('hashchange', function (e) {
    navigateToHashAddress();
});

var navigateToHashAddress = function () {
    var location = window.location;
    if (location.hash != '') {
        location.href = location.protocol + "//" + location.host + location.hash;
        var localAddress = location.hash.replace('#', '');
        $('#' + contentContainerId).load(localAddress);
    }

    console.log('Load ' + localAddress + ' and add it to ' + contentContainerId);
}