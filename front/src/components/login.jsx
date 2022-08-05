import React, { useRef, useState, useEffect } from 'react';
import { Link } from 'react-router-dom';

import axios from '../api/axios';
const loginURL = "/user";

export const Login = () => {
    const [user, setUser] = useState("");
    const [password, setPassword] = useState("");
    const [errorMessage, setErrorMessage] = useState("");

    const userRef = useRef();

    useEffect(() => {
        // set the focus to the user input on component loading
        userRef.current.focus();
    }, []);

    useEffect(() => {
        // reset the error message on new user/password input
        setErrorMessage("");
    }, [user, password]);



    // Check response content !!!

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
            console.log("response:", response);
            console.log("user = ", response.data.firstName);
            console.log("role = ", response.data.role);
            setUser("");
            setPassword("");

        } catch (err) {
            if (!err.response) {
                setErrorMessage("No server response");
            } else switch (err.response.status) {
                case 400:
                    setErrorMessage(err.response.data)
                    break;
                case 401:
                    setErrorMessage("Unauthorized access")
                    break;
                default:
                    setErrorMessage("Login failled")
                    break;
            }
            console.log("Error: ", errorMessage);
        }
    }


    return (
        <section>
            <p className={errorMessage ? "error-message-display" : "error-message-hide"}>{errorMessage}</p>
            <form onSubmit={handleSubmit}>
                <input
                    type="text"
                    id="username"
                    ref={userRef}
                    autoComplete="off"
                    required
                    onChange={(ev) => setUser(ev.target.value)}
                    placeholder="Email or phone number"
                    value={user}
                />
                <input
                    type="paswword"
                    id="password"
                    autoComplete="off"
                    required
                    onChange={(ev) => setPassword(ev.target.value)}
                    placeholder="Password"
                    value={password}
                />
                <button>Sign In</button>
                <p>
                    New to Netflix?
                    <Link to="/register">
                        Sign up now.
                    </Link>
                </p>
            </form>
        </section>
    );
}
