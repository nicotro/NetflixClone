import { useState, useEffect } from "react";
import { useDispatch, useSelector } from "react-redux";
import { useNavigate } from "react-router-dom";
import { UserHeader } from "../components/user-header";
import { UserSection } from "../components/user-section";
import { getCategories, isLoggedAPI } from "../services/db-access";
import "../style/user-header.css"

export function UserContainer() {
  const [loaded, setLoaded] = useState(false);
  const [category, setCategory] = useState("");
  const [categories, setCategories] = useState([]);
  
  const { firstName, role, loggedIn } = useSelector((state) => ({
    ...state.userReducer,
  }));

  const navigate = useNavigate();
  const loggedURL = "/signedin";
  const categoryURL = "/category";
  let userLoggedIn = false;
  useEffect(() => {
    //console.log("useEffect in");
    //console.log(firstName, role, loggedIn);
    if (loaded === false) {
      isLoggedAPI(loggedURL)
        .then(res => {
          userLoggedIn = true;
          setLoaded(true);
          getCategories(categoryURL)
            .then(res => {
              setCategories(res.data);
            })
            .catch(err => {
              console.log("error", err);
            })
        })
        .catch(err => {
          userLoggedIn = false;
          navigate('/login');
        });
    }
  }, [loaded]);

  const handleClick = (category) => {
    setCategory(category);
  }

  return (
    <>
      {loaded
        ?
        <div className="user-section">
          <UserHeader handleClick={handleClick} categories={categories} active={category} />
          <UserSection category={category} />
        </div>
        :
        < div className="debug-white-text">
          <p>Loading...</p>
        </div>
      }
    </>
  )
}
