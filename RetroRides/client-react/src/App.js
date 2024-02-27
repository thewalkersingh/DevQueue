import React from "react";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import NavigationBar from "./components/Home";
import Home from "./components/Home";
import Bikes from "./components/Bikes";
import Cars from "./components/Cars";
import Services from "./components/Services";
import AboutUs from "./components/AboutUs";
import Signup from "./components/Signup";
import Login from "./components/Login";

function App() {
  return (
    <Router>
      <NavigationBar />
      <Routes>
        <Route path="/" element={<Home />} />
        <Route path="/bikes" element={<Bikes />} />
        <Route path="/cars" element={<Cars />} />
        <Route path="/services" element={<Services />} />
        <Route path="/about" element={<AboutUs />} />
        <Route path="/about" element={<Signup />} />
        <Route path="/about" element={<Login />} />
      </Routes>
    </Router>
  );
}

export default App;
