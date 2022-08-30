import { NavbarSimple } from "./navbar-simple";
import backgroundImage from "./../assets/BG_netflix_large.jpg";
import "./../style/auth-header.css";

export function AuthHeader() {
    return (
        <div
            className="auth-section"
            style={{ backgroundImage: `url(${backgroundImage})` }}
        >
            <NavbarSimple />
        </div>
    );
}
