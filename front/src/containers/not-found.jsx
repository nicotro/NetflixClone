import { Header } from "../components/header/header";
import backgroundImage from "./../assets/BG_netflix_large.jpg";
import logo from "./../logo.svg";
import "./../style/not-found.css";

export function NotFound() {
  return (
    <div
      className="notfound-background"
      style={{ backgroundImage: `url(${backgroundImage})` }}
    >
      <Header />
      <div className="notfound-message">
        <h1 className="h1-404">404</h1>
        <img src={logo} className="tmp-logo" alt="logo" />
        <h1 className="h1-notfound">page Not found</h1>
      </div>
    </div>
  );
}
