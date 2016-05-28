$('.circle').click(function() {
    $('#video')[0].play();
    $('.circle').hide();
    $('#video').attr('controls', true);
});

$('#video').click(function() {
    $('#video')[0].pause();
    $('.circle').show();
    $('#video').attr('controls', false);
});