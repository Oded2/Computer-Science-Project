/**
 * The function validates a signup form by checking if certain fields are empty or contain specific
 * characters.
 * @returns The function `validateSignupForm()` returns a boolean value, which is the result of the
 * logical AND operation between the results of several calls to the `validateText()` function. The
 * `validateText()` function also returns a boolean value, which is either `true` if the input value
 * passes all the validation checks, or `false` if it fails any of them.
 */
function validateSignupForm() {
    let b = true;
    b = b && validateText("ID", document.getElementById("id"));
    b = b && validateText("First name", document.getElementById("fname"));
    b = b && validateText("Last name", document.getElementById("lname"));
    b = b && validateText("Address", document.getElementById("address"));
    b = b && validateText("Password", document.getElementById("password"));
    b = b && validateText("Birthday", document.getElementById("dob"));
    return b;
}

//powers the validate signup form
function validateText(name, val) {
    og = val;
    val = val.value;

    if (!val || val.length == 0) {
        og.style.border = "3px solid red";
        setTimeout(function () {
            alert(name + " cannot be empty");
        }, 10);
        og.focus();
        return false;
    }
    if (val.indexOf("@") > 0) {
        og.style.border = "3px solid red";
        setTimeout(function () {
            alert(name + " cannot contain a strudle");
        }, 10);
        og.focus();
        return false;
    }
    if (val.indexOf("#") > 0) {
        og.style.border = "3px solid red";
        setTimeout(function () {
            alert(name + " cannot contain a hashtag");
        }, 10);
        og.focus();
        return false;
    }
    if (val.indexOf("%") > 0) {
        og.style.border = "2px solid red";
        setTimeout(function () {
            alert(name + " cannot contain a percentage sign");
        }, 10);
        og.focus();
        return false;
    }
    if (val.indexOf("*") > 0) {
        og.style.border = "3px solid red";
        setTimeout(function () {
            alert(name + " cannot contain an asterisk");
        }, 10);
        og.focus();
        return false;
    }
    if (val.indexOf("'") > 0) {

        og.style.border = "3px solid red";
        setTimeout(function () {
            alert(name + " cannot contain an apostrophe");
        }, 10);
        og.focus();
        return false;
    }

    return true;
}

/**
 * The function sets the maximum date for a date input field to the current date.
 */
function maxDay() {
    var currentDate = new Date();
    var formattedDate = currentDate.toISOString().split("T")[0];
    document.getElementById("logDate").max = formattedDate;
}

/**
 * The function validates the input fields for a flight log form.
 * @returns a boolean value, which is the result of validating various input fields in a flight log
 * form. If all the input fields pass validation, the function returns `true`, otherwise it returns
 * `false`.
 */
function validateFlightLog() {
    let b = true;
    b = b && validateText("Date", document.getElementById("logDate"));
    b = b && validateText("Callsign", document.getElementById("callsign"));
    b =
        b &&
        validateText("Time of Departure", document.getElementById("logTakeoff"));
    b =
        b &&
        validateText(
            "Airport of Departure",
            document.getElementById("logAirportTakeoff")
        );
    b =
        b && validateText("Time of Landing", document.getElementById("logLanding"));
    b =
        b &&
        validateText(
            "Airport of Destination",
            document.getElementById("logAirportLanding")
        );
    b =
        b && validateText("Model of Aircraft", document.getElementById("logModel"));
    return b;
}

/**
 * The function redirects the user to an email address when the "contact us" button is clicked.
 */
function contactUs() {
    document.location.href = "mailto:oded@benamotz.com";
}

/**
 * The function prompts the user to confirm the deletion of a flight and redirects to a page with the
 * corresponding flight ID and action.
 * @param id - The id parameter is the unique identifier of the flight that needs to be deleted.
 * @returns a boolean value of false if the user cancels the confirmation prompt, and it is returning
 * false again after setting the document location to a specific URL.
 */
function deleteFlight(id) {
    if (!confirm("Are you sure you want to delete this flight?")) {
        return false;
    }

    document.location.href = `flight.aspx?id=${id}&action=del`;
    return false;
}

/**
 * The function validates user edits and prompts for confirmation before deleting a user.
 * @returns a boolean value. If the user has checked the "userDel" checkbox and has confirmed twice
 * that they want to delete the user, then the function will return true. Otherwise, if the user
 * cancels either confirmation prompt, the function will return false.
 */
function validateUserEdit() {
    if (document.getElementById("ContentPlaceHolder1_userDel").checked) {
        if (!confirm("Are you sure you want to DELETE the user?")) {
            return false;
        }
        if (
            !confirm("Double checking: Are you sure you want to DELETE the user?")
        ) {
            return false;
        }
    }

    return true;
}
