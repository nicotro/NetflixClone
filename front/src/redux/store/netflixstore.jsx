import { configureStore } from "@reduxjs/toolkit";
import userReducer from './../reducer/user-reducer';
import { combineReducers } from "redux";


const rootReducer = combineReducers({
    userReducer
})
export const netflixstore = configureStore({ reducer: rootReducer });

