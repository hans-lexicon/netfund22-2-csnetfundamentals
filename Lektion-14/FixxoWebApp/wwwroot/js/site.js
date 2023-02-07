const validate_firstname = (e) => {
    const regex = /^[a-zA-Z]+$/

    if (regex.test(e.target.value)) {
        document.querySelectorAll('[data-valmsg-For="FirstName"]')[0].innerHTML = ""
    }
    else {
        document.querySelectorAll('[data-valmsg-For="FirstName"]')[0].innerHTML = "Must be a valid name"
    }
}

const validate_lastname = (e) => {
    const regex = /^[a-zA-Z]+$/

    if (regex.test(e.target.value)) {
        document.querySelectorAll('[data-valmsg-For="LastName"]')[0].innerHTML = ""
    }
    else {
        document.querySelectorAll('[data-valmsg-For="LastName"]')[0].innerHTML = "Must be a valid name"
    }
}

const validate_email = (e) => {
    const regex_email = /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/

    if (regex_email.test(e.target.value)) {
        document.querySelectorAll('[data-valmsg-For="Email"]')[0].innerHTML = ""
    }
    else {
        document.querySelectorAll('[data-valmsg-For="Email"]')[0].innerHTML = "Must be an valid email address"
    }
}

const validate_password = (e) => {
    const regex_email = /^(?=.*[0-9])(?=.*[!@#$%^&*])[a-zA-Z0-9!@#$%^&*]{8,}$/

    if (regex_email.test(e.target.value)) {
        document.querySelectorAll('[data-valmsg-For="Password"]')[0].innerHTML = ""
    }
    else {
        document.querySelectorAll('[data-valmsg-For="Password"]')[0].innerHTML = "Must be a strong password"
    }
}