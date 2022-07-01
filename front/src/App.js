import { HomeContainer } from './containers/home-container';
import logo from './logo.svg'
import './style/App.css';

function App() {
  return (
    <div>
      <HomeContainer/>
      <img src={logo} className="App-logo" alt="logo" />
    </div>
  );
}

export default App;
