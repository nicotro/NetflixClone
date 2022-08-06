import { AuthHeader } from "../components/auth-header";
import { RegisterSection } from "./../components/register-section";
import { Footer } from "../components/footer";

export function RegisterContainer() {
  return (
    <div>
      <AuthHeader />
      <RegisterSection />
      <Footer />
    </div>
  );
}
