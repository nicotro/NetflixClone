import React, { useRef, useState, useEffect } from 'react';
import { Link, Navigate, useLocation, useNavigate } from 'react-router-dom';
import axios from '../api/axios-user';
import './../style/register.css';

export const Register = () => {

    // get email from navigation param
    const { state } = useLocation();

    const [firstName, setFirstName] = useState("");
    const [firstNameError, setFirstNameError] = useState("");
    const [lastName, setLastName] = useState("");
    const [lastNameError, setLastNameError] = useState("");
    const [email, setEmail] = useState(state);
    const [emailError, setEmailError] = useState("");
    const [phone, setPhone] = useState("");
    const [phoneError, setPhoneError] = useState("");
    const [password, setPassword] = useState("");
    const [passwordError, setPasswordError] = useState("");

    const [errorMessage, setErrorMessage] = useState("");

    const nameRef = useRef();

    const registerURL = "/signup"
    const NAMES_REGEX = /^[A-z][A-z0-9-]{3,23}$/;
    const PHONE_REGEX = /^[0-9]{10}$/;
    const EMAIL_REGEX = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;
    const PASSWORD_REGEX = /^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%_-]).{8,24}$/;

    useEffect(() => {
        // set the focus to the firstname input on component loading
        nameRef.current.focus();
    }, []);


    const validateFirstname = (input) => {
        if (NAMES_REGEX.test(input)) {
            setFirstNameError("");
        }
        else {
            setFirstNameError("A-z, 0-9, -, 4 to 24 letters.");
        }
        setFirstName(input);
    }

    const validateLastname = (input) => {
        if (NAMES_REGEX.test(input)) {
            setLastNameError("");
        }
        else {
            setLastNameError("A-z, 0-9, -, 4 to 24 letters.");
        }
        setLastName(input);
    }

    const validateEmail = (input) => {
        if (EMAIL_REGEX.test(input)) {
            setEmailError("")
        }
        else {
            setEmailError("A valid email address is required.")
        }
        setEmail(input);
    }

    const validatePhone = (input) => {
        if (PHONE_REGEX.test(input)) {
            setPhoneError("");
        }
        else {
            setPhoneError("A valid 10-digit phone number is required.");
        }
        setPhone(input);
    }

    const validatePassword = (input) => {
        if (PASSWORD_REGEX.test(input)) {
            setPasswordError("");
        }
        else {
            setPasswordError("8 to 24 characters combination of upper and lowercase letters, digits and special characters.");
        }
        setPassword(input);
    }

    // Redirect on successful registration
    const navigate = useNavigate();

    const handleSubmit = async (ev) => {
        ev.preventDefault();
        try {
            const response = await axios.post(
                registerURL,
                JSON.stringify({ firstName, lastName, email, phone, password }),
                {
                    headers: { "Content-Type": "application/json" },
                    withCredentials: true
                }
            );
            setErrorMessage("");
            setFirstName("");
            setLastName("");
            setEmail("");
            setPhone("");
            setPassword("");
            // navigate to user or login ?
            navigate('/user');
        } catch (err) {
            console.log(err.response);
            if (err.response.data === undefined) {
                setErrorMessage("No server response");
            }
            else switch (err.response.status) {
                case 400:
                    setErrorMessage(err.response.data);
                    break;
                case 401:
                    setErrorMessage("Unauthorized access");
                    break;
                default:
                    setErrorMessage("Registration failled")
                    break;
            }
        }
    }

    return (
        <section>
            <div className={errorMessage && "signup-error-message"}>
                <p className='signup-error-message-text'>{errorMessage}</p>
            </div>

            <div className='register-form-input-container'>
                <form className='register-form' onSubmit={handleSubmit}>
                    <div className='register-form-float'>
                        <input
                            type="text"
                            id="firstname"
                            ref={nameRef}
                            autoComplete="off"
                            required
                            onChange={(ev) => validateFirstname(ev.target.value)}
                            value={firstName}
                        />
                        <label className={firstName && 'filled'}>First name</label>
                    </div>
                    <div className={firstNameError && 'register-input-error'}>
                        {firstNameError}
                    </div>

                    <div className='register-form-float'>
                        <input
                            type="text"
                            id="lastname"
                            autoComplete="off"
                            required
                            onChange={(ev) => validateLastname(ev.target.value)}
                            value={lastName}
                        />
                        <label className={lastName && 'filled'}>Last name</label>
                    </div>
                    <div className={lastNameError && 'register-input-error'}>
                        {lastNameError}
                    </div>

                    <div className='register-form-float'>
                        <input
                            type="text"
                            id="email"
                            autoComplete="off"
                            required
                            onChange={(ev) => validateEmail(ev.target.value)}
                            value={email}
                        />
                        <label className={email && 'filled'}>Email address</label>
                    </div>
                    <div className={emailError && 'register-input-error'}>
                        {emailError}
                    </div>

                    <div className='register-form-float'>
                        <input
                            type="text"
                            id="phone"
                            autoComplete="off"
                            required
                            onChange={(ev) => validatePhone(ev.target.value)}
                            value={phone}
                        />
                        <label className={phone && 'filled'}>Phone number</label>
                    </div>
                    <div className={phoneError && 'register-input-error'}>
                        {phoneError}
                    </div>

                    <div className='register-form-float'>
                        <input
                            type="password"
                            id="password"
                            autoComplete="off"
                            required
                            onChange={(ev) => validatePassword(ev.target.value)}
                            value={password}
                        />
                        <label className={password && 'filled'}>Password</label>
                    </div>
                    <div className={passwordError && 'register-input-error'}>
                        {passwordError}
                    </div>

                    <button className='register-form-button'>Register</button>
                    <div className='register-signup-container'>
                        <span className='register-signup-now'>
                            Already have an account?
                        </span>
                        <Link className='register-signup-link' to="/login">
                            Sign in.
                        </Link>
                    </div>
                </form>
            </div>
        </section>
    );
}
