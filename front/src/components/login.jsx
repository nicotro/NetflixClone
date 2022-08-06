import React, { useRef, useState, useEffect } from 'react';
import { Link } from 'react-router-dom';
import "./../style/login.css"

import axios from '../api/axios';
const loginURL = "/user";

export const Login = () => {
    const [user, setUser] = useState("");
    const [password, setPassword] = useState("");
    const [errorMessage, setErrorMessage] = useState("");
    const [errorMessageLink, setErrorMessageLink] = useState(false);

    const userRef = useRef();

    useEffect(() => {
        // set the focus to the user input on component loading
        userRef.current.focus();
    }, []);

    useEffect(() => {
        // reset the error message on new user/password input
        setErrorMessage("");
        setErrorMessageLink(false);
    }, [user, password]);



    // Redirect on successful login

    const handleSubmit = async (ev) => {
        ev.preventDefault();
        try {
            const response = await axios.post(
                loginURL,
                JSON.stringify({ username: user, password }),
                {
                    headers: { "Content-Type": "application/json" },
                    withCredentials: true
                }
            );
            setUser("");
            setPassword("");
        } catch (err) {
            console.log(err.response.data);
            if (!err.response) {
                setErrorMessage("No server response");
            } else switch (err.response.status) {
                case 400:
                    if (err.response.data === "User unknown") {
                        setErrorMessageLink(true);
                        setErrorMessage("Sorry, we can't find an account with this email address. Please try again or ")
                    } else {
                        setErrorMessage("Invalid password, please try again.")
                    }
                    break;
                case 401:
                    setErrorMessage("Unauthorized access")
                    break;
                default:
                    setErrorMessage("Login failled")
                    break;
            }
        }
    }


    return (
        <section>
            <div className={`error-message ${errorMessage ? "error-message-display" : "error-message-hide"}`}>
                {!errorMessageLink
                    ?
                    <p className='error-message-text'>{errorMessage}</p>
                    :
                    <p className='error-message-text'>
                        {errorMessage}
                        <Link className='error-message-link' to="/">
                            create a new account
                        </Link>.
                    </p>
                }
            </div>
            <div className='login-form-input-container'>
                <form className='login-form' onSubmit={handleSubmit}>
                    <div className='login-form-float'>
                        <input
                            type="text"
                            id="username"
                            ref={userRef}
                            autoComplete="off"
                            required
                            onChange={(ev) => setUser(ev.target.value)}
                            value={user}
                        />
                        <label className={user && 'filled'}>Email or phone number</label>
                    </div>
                    <div className='login-form-float'>
                        <input
                            type="password"
                            id="password"
                            autoComplete="off"
                            required
                            onChange={(ev) => setPassword(ev.target.value)}
                            value={password}
                        />
                        <label className={password && 'filled'}>Password</label>
                    </div>
                    <button className='login-form-button'>Sign In</button>
                    <div className='login-signup-container'>
                        <span className='login-signup-now'>
                            New to Netflix?
                        </span>
                        <Link className='login-signup-link' to="/">
                            Sign up now.
                        </Link>
                    </div>
                </form>
            </div>
        </section>
    );
}
