import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import { HomeContainer } from './containers/home-container';

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <React.StrictMode>
    <HomeContainer />
  </React.StrictMode>
);

