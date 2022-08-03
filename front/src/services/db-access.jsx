import axios from "../api/axios";

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
