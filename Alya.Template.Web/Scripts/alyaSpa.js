var contentContainerId = 'page-content';

$(window).on('hashchange', function (e) {
    var localAddress = window.location.hash.replace('#','');
    $('#' + contentContainerId).load(localAddress);

    console.log('Load ' + localAddress + ' and add it to ' + contentContainerId);
});