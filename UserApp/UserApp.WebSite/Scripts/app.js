var loader = {
    settings: {},

    init: function () {
        this.bindUIElements();
        this.bindUIActions();
    },

    bindUIElements: function () {
        this.settings = {
            loaderDiv: $('.loader')
        }
    },

    bindUIActions: function () {
    },

    show: function () {
        this.settings.loaderDiv.show();
    },

    hide: function () {
        this.settings.loaderDiv.hide();
    },

};

var signin = {
    settings: {},

    init: function () {
        this.bindUIElements();
        this.bindUIActions();
    },

    bindUIElements: function () {
        this.settings = {
            signinForm: $('#signin-form'),
            emailInput: $('#email-input'),
            passwordInput: $('#password-input'),
            signinButton: $("#signin-button"),
            errorSpan: $('#login-error'),
        }
    },

    bindUIActions: function () {
        this.settings.signinForm.off().on("keyup", $.proxy(this.keyupAction, this));
        this.settings.signinButton.off().on("click", $.proxy(this.signinAction, this));
        this.settings.signinForm.validate();
    },

    keyupAction: function (e) {
        if (e.keyCode == 13) {
            this.signinAction(e);
        }
    },

    signinAction: function (e) {
        e.preventDefault();
        if (this.settings.signinForm.valid()) {
            loader.show();

            var input = {
                email: this.settings.emailInput.val(),
                password: this.settings.passwordInput.val()
            };
            $.ajax({
                headers: { "Token": $("input[name='__RequestVerificationToken']").val() },
                url: '/User/SignIn',
                type: 'POST',
                data: JSON.stringify(input),
                contentType: "application/json; charset=utf-8"
            }).done(function (result) {
                loader.hide();
                alert(result);
            });
        }
    },
};

$(document).ready(function () {
    loader.init();
    signin.init();
});