
const INITIAL_STATE = {
    firstName: "",
    role: "",
    loggedIn: false,
};

export default function userReducer(state = INITIAL_STATE, action) {
    switch (action.type) {
        case "LOGIN": {
            console.log("login state : ", state);
            console.log("payload : ", action.payload);
            return {
                ...state,
                firstName: action.payload.firstName,
                role: action.payload.role,
                loggedIn: true
            };
        }
        case "LOGOUT": {
            return {
                ...state,
                firstName: "",
                role: "",
                loggedIn: false
            }
        }
        default:
            break;
    }
    return state;
}


