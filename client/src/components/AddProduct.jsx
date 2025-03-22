import React, { useState } from 'react';
import axios from 'axios';
import { TextField, Button } from '@mui/material';
import { addProduct } from '../api/usersApi';
import { useNavigate } from 'react-router-dom';

function AddProduct() {
    const [product, setproduct] = useState({ id: '', name: '', price: '', description: '', stockQuantity: '' });
    const navigate = useNavigate();

    const handleChange = (e) => {
        setproduct({ ...product, [e.target.name]: e.target.value });
    };

    const handleSubmit = (e) => {
        e.preventDefault();
        alert("from commp:"+product.id+ " "+product.name+" "+product.description+" "+product.price+" "+product.stockQuantity)
        addProduct(product).then(() => {
            alert('User added successfully!');
            navigate(`/`);
        })
        .catch((e)=>{
            alert("error!!!");
            navigate(`/`);
        });
    };

    return (
        <div>
            <h1>הוספת מוצר</h1>
            <form onSubmit={handleSubmit}>
                <div class="form-group">
                    <TextField name="id" label="id" onChange={handleChange} required />
                </div>
                <div class="form-group">
                    <TextField name="name" label="name" onChange={handleChange} required />
                </div>
                <div class="form-group">
                    <TextField name="price" label="price" onChange={handleChange} required />
                </div>
                <div class="form-group">
                    <TextField name="description" label="description" onChange={handleChange} required />
                </div>
                <div class="form-group">
                    <TextField name="stockQuantity" label="stockQuantity" onChange={handleChange} required />
                </div>
                <div class="form-group">
                    <Button type="submit">Add Product</Button>
                </div>
            </form>
        </div>
    );
}

export default AddProduct;