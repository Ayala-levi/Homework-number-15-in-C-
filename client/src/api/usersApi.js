import axios from 'axios';

const PATH = 'https://localhost:7179/api/Product';
export const getAllPoducts = async () => {
    try {
        const response = await axios.get(PATH);
        const products = response.data;
        return products;
    }
    catch (e) {
        console.log(e);
        throw e;
    }
}
export const getProductById = async (id) => {
    try {
        const response = await axios.get(`${PATH}/${id}`)
        const p = response.data;
        return p;
    }
    catch (e) {
        console.log(e);
        throw e;
    }
}

export const addProduct = async (p) => {
    try {
        const response = await axios.post(PATH, p);
        alert("from userapi:"+p.name)
    }
    catch (e) {
        console.log(e);
        throw e;
    }
}
export const updateProduct = async (p) => {
    try {
        const response = await axios.put(`${PATH}/${p.id}`, p)
        console.log(response.data);
    }
    catch (e) {
        console.log(e);
        throw e;
    }
}

export const deleteProduct = async (productCode) => {
    try {
        console.log(productCode)
        const res = await axios.delete(`${PATH}/${productCode}`);
        alert("deleted")
    }
    catch (e) {
        console.log(e);
        alert("errorr")
    }
}