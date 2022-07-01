import './../style/home-container.css'
import backgroundImage from "./../assets/BG_netflix_large.jpg";

export function HomeContainer() {
    return (
        <div className="page" style={{ backgroundImage: `url(${backgroundImage})` }}>
        </div>
    );
}

