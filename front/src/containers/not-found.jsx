import { Link } from "react-router-dom";
import backgroundImage from "./../assets/bg-lost-in-space.png";
import logoImage from "./../assets/Logo_netflix.svg";
import "./../style/not-found.css";

export function NotFound() {
  return (
    <div className="not-found">
      <div className="not-found-header">
        <div className="not-found-logo">
          <Link className="not-found-link" style={{ backgroundImage: `url(${logoImage})` }} to="/">
            NETFLIX
          </Link>
        </div>
      </div>
      <div className="not-found-content" style={{ backgroundImage: `url(${backgroundImage})` }}>
        <div className="not-found-content-message">
          <h1 className="not-found-content-title">Lost your way?</h1>
          <div className="not-found-content-body">
            <p>
              Sorry, we can't find that page. You'll find lots to explore on the home page.
            </p>
            <Link to={"/"} className="not-found-content-button">
              Netflix Home
            </Link>
            <div className="not-found-content-404">
              <span>
                Code d'erreur&nbsp;: <strong>NSES-404</strong>
              </span>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
}
