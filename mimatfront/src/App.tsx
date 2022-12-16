import { Component } from "react";
import "bootstrap/dist/css/bootstrap.min.css";
import logo from './logo.svg';
import './App.css';
import {LOADIPHLPAPI} from "dns";
import Login from "./login/Login";
import Navbar from './Navbar/Navbar';
import TextTitle from "./utils/TextTitle";
import Table from "./Table/Table";


function App() {
  return (
   <>

    <Navbar></Navbar>


      <header className="App-header">
      
      <Table></Table>

     </header>
      
    </>
  );
}

export default App;
