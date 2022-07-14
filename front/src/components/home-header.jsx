import { Navbar } from "./navbar";
import backgroundImage from "./../assets/BG_netflix_large.jpg";
import "./../style/header.css";
import { RegisterStart } from "./register-start";

export function HomeHeader() {
  return (
    <div
      className="bg-header"
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
