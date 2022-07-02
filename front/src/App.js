import { BrowserRouter, Route, Routes } from "react-router-dom";
import { createBrowserHistory } from "history";
import { HomeContainer } from "./containers/home-container";
import { LoginContainer } from "./containers/login-container";
import { RegisterContainer } from "./containers/register-container";
import { NotFound } from "./containers/not-found";
import "./style/App.css";

function App() {
  const hist = createBrowserHistory();
  return (
    <BrowserRouter history={hist}>
      <Routes>
        <Route exact path="/" element={<HomeContainer />} />
        <Route path="/login" element={<LoginContainer />} />
        <Route path="/register" element={<RegisterContainer />} />
        <Route path="*" element={<NotFound />} />
      </Routes>
    </BrowserRouter>
  );
}

export default App;
