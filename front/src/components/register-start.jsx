import "./../style/register-start.css";

export function RegisterStart() {
  return (
    <div className="register-start">
      <h3>
        Ready to watch? Enter your email to create or restart your membership.
      </h3>
      <div className="wrap">
        <input
          type="email"
          value=""
          tabindex="0"
          autocomplete="email"
          placeholder="Email address"
          maxlength="50"
          minlength="5"
        ></input>
        <div className="register-start-button">Get Started</div>
      </div>
    </div>
  );
}
