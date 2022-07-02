import React from "react";
import ReactDOM from "react-dom/client";
import "./style/index.css";
import "./fonts/NetflixSans_W_Md.woff2";
import "./fonts/NetflixSans_W_Rg.woff2";

import App from "./App.js";
const root = ReactDOM.createRoot(document.getElementById("root"));
root.render(
  <React.StrictMode>
    <App />
  </React.StrictMode>
);
