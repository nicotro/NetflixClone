import { Header } from "../components/header";
import { HomeAd1Section } from "../components/home-ad1-section";
import { HomeAd2Section } from "../components/home-ad2-section";
import { HomeFaqSection } from "../components/home-faq-section";
import "./../style/home-container.css";

export function HomeContainer() {
  return (
    <div>
      <Header />
      <HomeAd1Section />
      <HomeAd2Section />
      <HomeFaqSection />
    </div>
  );
}
