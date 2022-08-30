import { Link } from "react-router-dom";
import logoImage from "./../assets/Logo_netflix.svg";
import "./../style/navbar.css";

export function Navbar() {
  return (
    <div className="nav-header">
      <Link to="/">
        <img src={logoImage} alt="Netflix logo" />
      </Link>
      <Link className="nav-header-button" to="/login">
        Sign in
      </Link>
    </div>
  );
}
