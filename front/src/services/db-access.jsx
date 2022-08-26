import axiosResource from "../api/axios-resource";
import axiosUser from "../api/axios-user";
import { GetTokenFromStorage } from "../api/token-user";

// export const getAll = async () => {
//     return await axios.get(loginURL);
// }

export const loginAPI = async (loginURL, username, password) => {
    return await axiosUser.post(
        loginURL,
        JSON.stringify({ username, password }),
        {
            headers: { "Content-Type": "application/json" },
            withCredentials: true
        }
    );
}

export const isLoggedAPI = async (loggedURL) => {
    return axiosUser.get(loggedURL, { headers: { "Authorization": "Bearer " + GetTokenFromStorage() } })
}

export const getCategories = async (categoryURL) => {
    return axiosResource.get(categoryURL, { headers: { "Authorization": "Bearer " + GetTokenFromStorage() } })
}

export const getGenres = async (genreURL) => {
    return axiosResource.get(genreURL, { headers: { "Authorization": "Bearer " + GetTokenFromStorage() } })
}

