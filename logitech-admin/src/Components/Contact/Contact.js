import axios from 'axios';
import React, { Component } from 'react';
import "./Contact.css";
import {GET_ALL_PRODUCTS} from 'D:/Nam4/ReactJS App/logitech-admin/src/HTTPServer/httpProduct.js';

export default class Contact extends Component {
    state = {
        userList: [],
    };

    componentDidMount() {
        GET_ALL_PRODUCTS('Index')
            .then(response => {
            this.setState({userList: response.data});
        });
    }

    // addNewContact(e) {
    //     e.preventDefault();
    //     console.log(e.target.name.value)
    //     console.log(e.target.email.value)
    // }
    
    // handleDeleteProduct(id) {
    //     alert("Có chắc bạn muốn xóa sản phẩm này");
    //     if (confirm('Có chắc bạn muốn xóa sản phẩm này?')) {
            
    //     } else {
    //         console.log('Thing was not saved to the database.');
    //     }

    //     fetch('https://jsonplaceholder.typicode.com/users/'+id, {
    //         method: "DELETE"
    //     })
    //         .then((response) => response.json())
    //         .then((response) => {
    //             console.log(response);
    //         });
    // }

    render() {
        return (
            <>
            <form onSubmit={e => this.addNewContact(e)}>
               <label >Name: </label>
               <input type="text" id="name" />
  
               <label >Email: </label>
               <input type="email" id="email" />
  
               <button type="submit">Submit</button>
           </form>

            <table id="table">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Name</th>
                        <th>Price</th>
                        <th>Action</th>
                    </tr>
                </thead>
                <tbody>
                    {
                        this.state.userList.map((user) => (
                            <tr key={user.id}>
                                <td>{user.id}</td>
                                <td>{user.name}</td>
                                <td>{user.category.name}</td>
                                <td>
                                    <button onClick={() => this.handleDeleteProduct(user.id)}>Delete</button>
                                </td>
                            </tr>
                        ))
                    }
                </tbody>
            </table>
            </>
        )
    }
}
