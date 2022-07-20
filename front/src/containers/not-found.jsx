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
      <div className="not-found-content" style={{ backgroundImage: `url(${backgroundImage})`}}>
        <h1 className="not-found-content-title">Lost your way?</h1>
        <div className="not-found-content-body">
          <p>
          Sorry, we can't find that page. You'll find lots to explore on the home page. 
          </p>
          <div className="not-found-content-message">

          </div>
        </div>
      </div>
    </div>
    // <div
    //   className="notfound-background"
    //   style={{ backgroundImage: `url(${backgroundImage})` }}
    // >
    //   <div>
    //     <div className="notfound-message">
    //       <h1 className="h1-404">404</h1>
    //       <img src={logo} className="tmp-logo" alt="logo" />
    //       <h1 className="h1-notfound">page Not found</h1>
    //     </div>
    //   </div>
    // </div>
  );
}
