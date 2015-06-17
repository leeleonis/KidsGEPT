//Slidebar //Usage: http://plugins.adchsm.me/slidebars/usage.php
(function($) {
  $(document).ready(function() {
    $.slidebars();
  });
}) (jQuery);

//Sticky //Usage: https://github.com/garand/sticky
$(document).ready(function(){
  $("#sticker").sticky({topSpacing:0});
});


//BxSlider //Usage: http://bxslider.com/options
$('.bxslider').bxSlider({
  speed: 1000,
  mode: 'fade'
});


//
$(document).ready(function(){
  $("#wrapper").css('height', getBrowserHeight());
});

$(window).resize(function(){
  $("#wrapper").css('height', getBrowserHeight());
})
