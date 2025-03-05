import React from 'react';
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import Login from './components/Login';
import ProductList from './components/ProductList';
import AddProduct from './components/AddProduct';
import UpdateProduct from './components/UpdateProduct';

function App() {
    return (
        <Router>
            <div>
                <Routes>
                    <Route path="/" element={<ProductList />} />
                    <Route path="/add" element={<AddProduct />} />
                    <Route path="/login" element={<Login />} />
                    <Route path="/update/:id" element={<UpdateProduct />} />
                </Routes>
            </div>
        </Router>
    );
}

export default App;