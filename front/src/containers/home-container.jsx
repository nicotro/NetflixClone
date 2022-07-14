import { HomeHeader } from "../components/home-header";
import { HomeAd1Section } from "../components/home-ad1-section";
import { HomeAd2Section } from "../components/home-ad2-section";
import { HomeFaqSection } from "../components/home-faq-section";
import "./../style/home-container.css";
import { Footer } from "../components/footer";

export function HomeContainer() {
    return (
        <div>
            <HomeHeader />
            <HomeAd1Section />
            <HomeAd2Section />
            <HomeFaqSection />
            <Footer/>
            
        </div>
    );
}
