import React from "react";
import ReactDOM from "react-dom/client";
import { Provider } from "react-redux";
import { netflixstore } from "./redux/store/netflixstore";
import App from "./App.js";
import "./style/index.css";
import "./fonts/NetflixSans_W_Md.woff2";
import "./fonts/NetflixSans_W_Rg.woff2";

const root = ReactDOM.createRoot(document.getElementById("root"));
root.render(
  <Provider store = {netflixstore}>
    <App />
  </Provider>
);
