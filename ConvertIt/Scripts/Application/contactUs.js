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
        $.get('ContactUs/SendEmail?name=' + formName + '&email=' + formEmail + '&subject=' + formSubject + '&message=' + formMessage).then(
            function () {
                $(".modal-body input").val("");
                $(".modal-body textarea").val("");

                $('#contactUsModal').find('.modal-title').html('<h4>Your message was sent!</h4>');
                $('#contactUsModal').find('.modal-body').html('<p>Thank you for contacting convertIt.com You will hear back from us shortly.</p>' +
                '<img src="images/logo.png" width="304" height="auto" />');
                $('#contactUsModal').find('.modal-footer').html('<button type="button" class="btn btn-secondary" data-dismiss="modal" onclick="resetContactForm()">Close</button>');
            });
    }
};

function resetContactForm() {
    $('#contactUsModal').modal('hide');
    $('#contactUsModal').find('.modal-title').html('<h4>Contact Us</h4>');
    $('#contactUsModal').find('.modal-body').html('<input type="text" class="form-control" id="name" placeholder="Name" autofocus>' +
                                                    '<input type="email" class="form-control" id="email" placeholder="Email">' +
                                                    '<input type="text" class="form-control" id="subject" placeholder="Subject">' +
                                                    '<textarea type="text" class="form-control" id="message" placeholder="Message" rows="8"></textarea>');
    $('#contactUsModal').find('.modal-footer').html('<button type="button" class="btn btn-secondary" data-dismiss="modal">Cancel</button>' +
                                                    '<button type="button" class="btn btn-success" onclick="sendEmail()">Submit</button>');
}