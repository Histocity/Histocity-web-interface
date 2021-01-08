// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

  var checkConfirmPassword = function () {
            if (document.getElementById('password').value ==
                document.getElementById('confirmPassword').value) {
                document.getElementById('passwordError').hidden = true;
                document.getElementById('submitUserButton').disabled = false;
            } else {
                document.getElementById('passwordError').hidden = false;
                document.getElementById('submitUserButton').disabled = true;
            }
        }