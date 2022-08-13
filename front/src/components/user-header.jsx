import logoImage from "./../assets/Logo_netflix.svg";
import { Link } from "react-router-dom";

export function UserHeader({ handleClick, categories, active }) {
    return (
        <div className="usernav-header">
            <Link to="/user">
                <img src={logoImage} alt="Netflix logo" />
            </Link>
            {categories.map((c) => (
                <a className={`usernav-header-categories ${c.id == active && "usernav-header-categories-active"}`} key={c.id} onClick={() => handleClick(c.id)}>
                    {c.name}
                </a>
            ))}
        </div>
    );
}