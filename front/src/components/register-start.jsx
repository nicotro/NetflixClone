import { Link } from "react-router-dom";
import "./../style/register-start.css";

export function RegisterStart() {
  return (
    <div className="register-start">
      <h3>
        Ready to watch? Enter your email to create or restart your membership.
      </h3>
      <div className="wrap">
        <input type="email" defaultValue="" tabIndex="0" autoComplete="email" placeholder="Email address" maxLength="50" minLength="5"></input>
        <Link className="register-start-button" to="/register">Get Started</Link>
      </div>
    </div>
  );
}
