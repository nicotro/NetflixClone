import { HomeContainer } from './containers/home-container';
import logo from './logo.svg'
import './style/App.css';

function App() {
  return (
    <div className="App">
      <HomeContainer/>
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
      </header>
    </div>
  );
}

export default App;
