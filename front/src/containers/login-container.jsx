import { AuthHeader } from "../components/auth-header";
import { Footer } from "../components/footer";
import { LoginSection } from "../components/login-section";

export function LoginContainer() {
  return (
    <div>
      <AuthHeader />
      <LoginSection />
      <Footer />
    </div>
  );
}
