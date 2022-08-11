import axios from "../api/axios-user";
import { GetTokenFromStorage } from "../api/token-user";

// export const getAll = async () => {
//     return await axios.get(loginURL);
// }

export const loginAPI = async (loginURL, username, password) => {
    return await axios.post(
        loginURL,
        JSON.stringify({ username, password }),
        {
            headers: { "Content-Type": "application/json" },
            withCredentials: true
        }
    );
}

export const isLoggedAPI = async (loggedURL) => {
    return axios.get(loggedURL, { headers: { "Authorization": "Bearer " + GetTokenFromStorage() } })
    // .then((res) => {
    //     console.log("API access OK", res);
    //     return "OK";
    // })
    // .catch((err) => {
    //     console.log("API access error: ", err);
    //     return "";
    // });
}

