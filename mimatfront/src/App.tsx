import { Component } from "react";
import "bootstrap/dist/css/bootstrap.min.css";
import logo from './logo.svg';
import './App.css';
import {LOADIPHLPAPI} from "dns";
import Login from "./login/Login";


function App() {
  return (
    <div className="App">
      <header className="App-header">
        <Login></Login>
      </header>
    </div>
  );
}

export default App;
