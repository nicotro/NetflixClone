import backgroundImage from "./../assets/BG_netflix_large.jpg";
import { Navbar } from "./navbar";
import { RegisterStart } from "./register-start";
import "./../style/header.css";

export function HomeHeader() {
  return (
    <div
      className="bg-header home-section"
      style={{ backgroundImage: `url(${backgroundImage})` }}
    >
      <div className="bg-fade" />
      <Navbar />
      <h1>Unlimited movies, TV shows, and more.</h1>
      <h2>Watch anywhere. Cancel anytime.</h2>
      <RegisterStart />
    </div>
  );
}
