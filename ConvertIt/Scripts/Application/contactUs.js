function sendEmail() {
    var formName = $("#name")[0].value;
    var formEmail = $("#email")[0].value;
    var formSubject = $("#subject")[0].value;
    var formMessage = $("#message")[0].value.replace(/\n/g, '---');

    var emailFilter = /^[\w\-\.\+]+\@[a-zA-Z0-9\.\-]+\.[a-zA-z0-9]{2,4}$/;

    if (formName.length == 0 || formEmail.length == 0 || formSubject.length == 0 || !emailFilter.test(formEmail)) {
        if (formName.length == 0)
        {
            var $el = $("#name");
            $el.addClass("error");
        }
        else {
            var $el = $("#name");
            $el.removeClass("error");
        }
        if (formEmail.length == 0 || !emailFilter.test(formEmail)) {
            var $el = $("#email");
            $el.addClass("error");
        }
        else {
            var $el = $("#email");
            $el.removeClass("error");
        }
        if (formSubject.length == 0) {
            var $el = $("#subject");
            $el.addClass("error");
        }
        else {
            var $el = $("#subject");
            $el.removeClass("error");
        }
    }
    else {
        //$("#name").innerHTML = "";
        //$("#email").innerHTML = "";
        //$("#subject").innerHTML = "";
        //$("#message").innerHTML = "";

        //$(".modal-body input").val("");

        $.get('ContactUs/SendEmail?name=' + formName + '&email=' + formEmail + '&subject=' + formSubject + '&message=' + formMessage);
       
       
        //$('#contactUsModal').find('#modal-title').html('<h4>Your message was sent!</h4>');
        //$('#contactUsModal').find('#modal-body').html('<p>Thank you for contacting convertIt.com You will hear back from us shortly.</p>' +
		//'<img src="images/convertItNoBkgd.PNG" class="center-block img-rounded" alt="Cinque Terre" width="304" height="auto" style="background-color: black;"><br>' +
		//'<button type="button" class="btn btn-default center-block"  data-dismiss="modal" id="close-confirm" onclick="resetContactForm()">Close</button>');

    }




};

//var resetContactForm = function () {

//    $("#modalContact .close").click();

//    $('#modalContact').find('#modal-title').html('<h4>Contact Us</h4>');

//    $('#modalContact').find('#modal-body').html('<div class="form-group">' +
//													'<div class="col-md-8"> ' +
//														'<input type="text" id="varName" class="form-control" name="name" placeholder= "Name" />' +
//													'</div>' +
//													'<div class="col-md-4"><span id="nameErr" class="contactError" style="color: red" > <label style=" width: 100px"></label> </span></div></div>' +
//												'<div class="form-group" style="padding-top: 20px;">' +
//													'<div class="col-md-8">' +
//														'<input type="email" id="varEmail" class="form-control" name="email" placeholder="Email" />' +
//													'</div>' +
//												'<div class="col-md-4">' +
//													'<span id="emailErr" class="contactError" style="color: red"> <label style="width: 100px;"></label> </span></div>' +
//												'</div>' +
//												'<div class="form-group" style="padding-top: 20px;">' +
//												'<div class="col-md-8">' +
//													'<input type="text" id="varSubject" class="form-control" name="subject" placeholder="Subject" />' +
//												'</div>' +
//												'<div class="col-md-4"><span id="subjectErr" class="contactError" style="color: red"> <label style="width: 100px"></label> </span></div></div>' +
//												'<div class="form-group" style="padding-top: 20px;">' +
//												'<div class="col-md-12"><textarea type="text" id="varMessage" class="form-control" name="detail" placeholder="Message" ></textarea></div></div>' +
//												'<div class="form-group" style="padding-top: 75px; margin-bottom: -5px"><button type="button" id= "submit_button" class="btn btn-success center-block" onclick="sendEmail()">Submit</button></div>');


//};