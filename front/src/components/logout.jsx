import { useNavigate } from 'react-router-dom';
import { useDispatch } from 'react-redux';
import { clearTokenOnLogout } from '../api/token-user';

const logoutURL = "/";

export const Logout = () => {
    // Redux 
    const dispatch = useDispatch();
    const navigate = useNavigate();

    const handleSignOutClick = (e) => {
        console.log("test sign out");
        // Redirect on logout
        dispatch({
            type: "LOGOUT",
        });

        // Remove token from local storage
        clearTokenOnLogout();
        navigate(logoutURL);
    }

    return (
        <button className="usernav-header-button" onClick={handleSignOutClick}>
            Sign out
        </button>
    );
}
