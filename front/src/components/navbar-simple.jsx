import { Link } from "react-router-dom";
import logoImage from "./../assets/Logo_netflix.svg";
import "./../style/navbar.css";

export function NavbarSimple() {
    return (
        <div className="nav-header">
            <Link to="/">
                <img src={logoImage} alt="Netflix logo" />
            </Link>
        </div>
    );
}
