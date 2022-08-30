import { HomeHeader } from "../components/home-header";
import { HomeAdSection } from "../components/home-ad-section";
import { HomeFaqSection } from "../components/home-faq-section";
import { Footer } from "../components/footer";
import "./../style/home-container.css";

export function HomeContainer() {
    return (
        <div>
            <HomeHeader />
            <HomeAdSection />
            <HomeFaqSection />
            <Footer />

        </div>
    );
}
