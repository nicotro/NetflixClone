import React, { useRef, useState, useEffect } from 'react';
import { Link } from 'react-router-dom';
import './../style/register.css';

export const Register = () => {

    const [firstName, setFirstName] = useState("");
    const [lastName, setLastName] = useState("");
    const [email, setEmail] = useState("");
    const [phone, setPhone] = useState("");
    const [password, setPassword] = useState("");

    const nameRef = useRef();

    useEffect(() => {
        // set the focus to the firstname input on component loading
        nameRef.current.focus();
    }, []);

    const handleSubmit = async (ev) => {
        ev.preventDefault();
        setFirstName("");
        setLastName("");
        setEmail("");
        setPhone("");
        setPassword("");
    }

    return (
        <section>
            <div className='register-form-input-container'>
                <form className='register-form' onSubmit={handleSubmit}>
                    <div className='register-form-float'>
                        <input
                            type="text"
                            id="firstname"
                            ref={nameRef}
                            autoComplete="off"
                            required
                            onChange={(ev) => setFirstName(ev.target.value)}
                            value={firstName}
                        />
                        <label className={firstName && 'filled'}>First name</label>
                    </div>
                    <div className='register-form-float'>
                        <input
                            type="text"
                            id="lastname"
                            autoComplete="off"
                            required
                            onChange={(ev) => setLastName(ev.target.value)}
                            value={lastName}
                        />
                        <label className={lastName && 'filled'}>Last name</label>
                    </div>
                    <div className='register-form-float'>
                        <input
                            type="text"
                            id="email"
                            autoComplete="off"
                            required
                            onChange={(ev) => setEmail(ev.target.value)}
                            value={email}
                        />
                        <label className={email && 'filled'}>Email address</label>
                    </div>
                    <div className='register-form-float'>
                        <input
                            type="text"
                            id="phone"
                            autoComplete="off"
                            required
                            onChange={(ev) => setPhone(ev.target.value)}
                            value={phone}
                        />
                        <label className={phone && 'filled'}>Phone number</label>
                    </div>
                    <div className='register-form-float'>
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
