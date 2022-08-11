
export const SetTokenOnLogin = (token) => {
    localStorage.setItem('user', JSON.stringify(token));
}

export const GetTokenFromStorage = () => {
    return JSON.parse(localStorage.getItem('user') || '{}')['token'];
}

export const clearTokenOnLogout = () => {
    localStorage.removeItem('user');
}


export const parseJwt = (token) => {
    if (!token) { return; }
    const base64Url = token.split('.')[1];
    const base64 = base64Url.replace('-', '+').replace('_', '/');
    return JSON.parse(window.atob(base64));
}