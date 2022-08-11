import { useEffect } from "react";
import { useDispatch, useSelector } from "react-redux";
import { useNavigate } from "react-router-dom";
import { isLoggedAPI } from "../services/db-access";

export function UserContainer() {
  const { firstName, role, loggedIn } = useSelector((state) => ({
    ...state.userReducer,
  }));

  const navigate = useNavigate();
  const loggedURL = "/signedin";
  let userLoggedIn = false;
  useEffect(() => {
    console.log("useEffect in");
    //console.log(firstName, role, loggedIn);
    isLoggedAPI(loggedURL)
      .then(res => {
        console.log("response:", res.statusText);
        userLoggedIn = true;
      })
      .catch(err => {
        console.log("nope!", err.message);
        userLoggedIn = false;
        navigate('/login');
      });
  }, []);


  return (
    <>
      < div className="debug-white-text">
        <h1>User logged in</h1>
        <p>First name: {firstName} - Role: {role}</p>
      </div>
    </>
  )
}
