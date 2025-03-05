
import React, { useEffect, useState } from 'react';
import axios from 'axios';
import { TextField, Button } from '@mui/material';
import { useNavigate, useParams } from 'react-router-dom';
import { getProductById, updateProduct } from '../api/usersApi';

function UpdateProduct() {
    const { id } = useParams();
    const navigate = useNavigate();
    const [product, setproduct] = useState({ id: '', name: '', price: '', description: '', stockQuantity: '' });

    useEffect(() => {
        getProductById(id).then(response => {
            setproduct({ ...product, id: response.id })
            setproduct({ ...product, name: response.name })
            setproduct({ ...product, price: response.price })
            setproduct({ ...product, description: response.description })
            setproduct({ ...product, stockQuantity: response.stockQuantity })
            // setproduct(response.data));
        })
    }, [id]);

    const handleChange = (e) => {
        setproduct({ ...product, [e.target.name]: e.target.value });
    };

    const handleSubmit = (e) => {
        e.preventDefault();
        product.id = id;
        updateProduct(product).then(() => {
            alert('Product updated successfully!');
            navigate(`/`);
        });
    };

    return (
        <div>
            <h1>עדכון מוצר</h1>
            <form onSubmit={handleSubmit}>
                <div class="form-group">
                    <TextField name="id" label="id" value={product.id} onChange={handleChange} required />
                </div>
                <div class="form-group">
                    <TextField name="name" label="name" value={product.name} onChange={handleChange} required />
                </div>
                <div class="form-group">
                    <TextField name="price" label="price" value={product.price} onChange={handleChange} required />
                </div>
                <div class="form-group">
                    <TextField name="description" label="description" value={product.description} onChange={handleChange} required />
                </div>
                <div class="form-group">
                    <Button type="submit">Update Product</Button>
                </div>
            </form>
        </div>)
}

export default UpdateProduct;