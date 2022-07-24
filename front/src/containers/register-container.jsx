import { AuthHeader } from "../components/auth-header";
import { RegisterSection } from "./../components/register-section";
import { Footer } from "../components/footer";
import "./../style/register-container.css";

export function RegisterContainer() {
  return (
    <div>
      <AuthHeader />
      <RegisterSection />
      <Footer />
    </div>
  );
}
