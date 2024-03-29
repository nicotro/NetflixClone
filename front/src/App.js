import { BrowserRouter, Route, Routes } from "react-router-dom";
import { createBrowserHistory } from "history";
import { HomeContainer } from "./containers/home-container";
import { LoginContainer } from "./containers/login-container";
import { RegisterContainer } from "./containers/register-container";
import { UserContainer } from "./containers/user-container";
import { NotFound } from "./containers/not-found";
import "./style/App.css";

function App() {
  const hist = createBrowserHistory();
  return (
    <BrowserRouter history={hist}>
      <Routes>
        <Route path="NetflixClone" element={<HomeContainer />} />
        <Route path="/" element={<HomeContainer />} />
        <Route path="/login" element={<LoginContainer />} />
        <Route path="/register" element={<RegisterContainer />} />
        <Route path="/user" element={<UserContainer />} />
        <Route path="*" element={<NotFound />} />
      </Routes>
    </BrowserRouter>
  );
}

export default App;
