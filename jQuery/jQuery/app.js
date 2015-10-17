$(document).ready(function ()
{
  //  $("#flip").click(function () { $("#panel").slideDown("slow"); });
  //  $("#flip").click(function () { $("#panel").slideUp("slow"); });
    $("#flip").click(function () { $("#panel").slideToggle("slow"); });

    $("button").click(function () { $("p").hide(); });
    $("button").click(function () { $("#test").hide(); });
    $("button").click(function () { $(".test").hide(); });
    $("#hide").click(function () { $("h3").hide(500); });
    $("#show").click(function () { $("h3").show(300); });
    $("#toggle").click(function () { $("h4").toggle(300); });
    $("#fadi").click(function () {
        $("#div1").fadeIn();
        $("#div2").fadeIn("slow");
        $("#div3").fadeIn(3000);
    });

    $("#fado").click(function () {
        $("#div1").fadeOut();
        $("#div2").fadeOut("slow");
        $("#div3").fadeOut(3000);
    });
    $("#fadt").click(function () {
        $("#div1").fadeToggle();
        $("#div2").fadeToggle("slow");
        $("#div3").fadeToggle(3000);
    });
    $("#fadto").click(function () {
        $("#div1").fadeTo("slow", 0.15);
        $("#div2").fadeTo("slow", 0.4);
        $("#div3").fadeTo("slow", 0.7);
    });


    
    //vercnum e button@, ev clickov kanchum funkcia, vor@ hide-jnjum e 'p' teger@
    //vercnum e button@, ev clickov kanchum funkcia, vor@ hide-jnjum e 'test' id-ov dasht@


});


//jQuery Selectors

//Selects - @ntrel
//$("*")	 amboxj html ej@
//$(this)	 henc nran um vra click enq arel
//$("p.intro")	 ayn, ov uni 'intro' class@
//$("p:first")	 html-um handipox arajin 'p' element@
//$("ul li:first")	arajin 'u'-i arajin 'li'-n
//$("ul li:first-child")	amen 'ul'- arajin 'li'-n
//$("[href]")	bolor 'href' atributov elementner@
//$("a[target='_blank']")	ayn 'a' elementner@, vortex target='_blank'
//$("a[target!='_blank']")	ayn 'a' elementner@, vortex target!='_blank'
//$(":button")	ayn <button> ev <input> elemetner@ voronc type="button"
//$("tr:even")	bolor zuyg <tr> elementner@
//$("tr:odd")	bolor kent <tr> elementner@


//Mouse Events

//click
//dblclick
//mouseenter
//mouseleave
//mousedown
//mouseup
//hover
//focus
//blur
//on


//jQuery Fading Methods

//fadeIn()
//fadeOut()
//fadeToggle()
//fadeTo()


//jQuery Sliding Methods

//slideDown()
//slideUp()
//slideToggle()


//jQuery Animations
//jQuery Stop Animations
//jQuery Callback Functions
//jQuery - Chaining

//
//
//