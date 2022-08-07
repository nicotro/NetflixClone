import { ReactComponent as Arrow } from "./../assets/chevron.svg"
import { Link, useNavigate } from "react-router-dom";
import "./../style/register-start.css";
import { useEffect } from "react";
import { useState } from "react";

export function RegisterStart() {
  const [errorMessage, setErrorMessage] = useState("");
  const [email, setEmail] = useState("");

  useEffect(() => {
    // reset the error message on email input
    setErrorMessage("");
  }, []);

  // Redirect on successful login
  const navigate = useNavigate();

  const handleSubmit = (ev) => {
    ev.preventDefault();
    if (errorMessage === "" && email !== "") {
      navigate('/register', { state: email });
    }
  }

  const validateEmail = (mail) => {
    if (/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/.test(mail)) {
      setErrorMessage("")
    }
    else {
      setErrorMessage("A valid email address is required.")
    }
    setEmail(mail);
  }



  return (
    <div className="register-start">
      <h3>
        Ready to watch? Enter your email to create or restart your membership.
      </h3>
      <div className="wrap">

        <form className='register-start-form' onSubmit={handleSubmit}>
          <div className='register-start-form-float'>
            <input
              type="text"
              autoComplete="off"
              required
              onChange={(ev) => validateEmail(ev.target.value)}
              value={email}
            />
            <label className={email && 'filled'}>Email address</label>
            <div className={errorMessage && 'register-start-error'}>
              {errorMessage}
            </div>
          </div>
          <button className="register-start-button">
            Get Started <Arrow className="register-start-button-arrow" />
          </button>
        </form>


        {/* <input type="email" defaultValue="" tabIndex="0" autoComplete="email" placeholder="Email address" maxLength="50" minLength="5"></input>
        <Link className="register-start-button" to="/register">
          Get Started <Arrow className="register-start-button-arrow"/>
          </Link> */}
      </div>
    </div>
  );
}
