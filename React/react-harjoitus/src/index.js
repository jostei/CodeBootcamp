import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import App from './App';
import reportWebVitals from './reportWebVitals';
import IpsumKomponentti from './IpsumKomponentti';
import UusiProppi from './UusiProppi';
import LuokkaMuotoinen from './LuokkaMuotoinen';
/*import Taulukko from './Taulukko';*/
import ApiConnect from './ApiConnect';

ReactDOM.render(
  <React.StrictMode>
    <App />
    <UusiProppi />
    <ApiConnect id={2} url="https://jsonplaceholder.typicode.com/todos/" />
    <IpsumKomponentti  />
    <LuokkaMuotoinen />
  </React.StrictMode>,
  document.getElementById('root')
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
