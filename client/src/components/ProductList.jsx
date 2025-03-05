import React, { useEffect, useState } from 'react';
import axios from 'axios';
import { Button, List, ListItem } from '@mui/material';
import { useNavigate } from 'react-router-dom';
import { deleteProduct, getAllPoducts } from '../api/usersApi';

function ProductList() {
    const [products, setProducts] = useState([]);
    const navigate = useNavigate();

    useEffect(() => {
        getAllPoducts().then(data =>
            setProducts(data));
    }, []);

    const handleDelete = (code) => {
        deleteProduct(code).then(() => {
            setProducts(products.filter(p => p.id != code));
        }).catch(e =>
            console.log(e))

    };

    return (
        <div>
            <h1>רשימת מוצרים</h1>
            {!products || products.length === 0 ? (
                <div className="loading">טוען....</div>
            ) : (<div>
                <div class="myDiv">
                    <Button class="btn" href="/add">Add Product</Button>
                    <Button class="btn" href="/login">Login</Button>
                </div>
                <div className="product-list">
                    {products.map((x, i) => (
                        <div className="product-card" key={i}>
                            <h3>{x.name}</h3>
                            <p>{x.description}</p>
                            <p>מחיר: {x.price}</p>
                            <p>מלאי: {x.stockQuantity}</p>
                            <Button onClick={() => handleDelete(x.id)}>Delete</Button>
                            <Button onClick={() => {navigate(`/update/${x.id}`);alert(x.id+" "+x.name)}}>Update</Button>
                        </div>
                    ))}

                </div>
            </div>
            )}
        </div>
    );
}

export default ProductList;