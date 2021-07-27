import React, { Component } from 'react'
import { Link } from 'react-router-dom';
import "./Product.css";
import { GET_ALL_PRODUCTS, DELETE_PRODUCT } from '../../HTTPServer/httpProduct.js';

export default class Product extends Component {
    constructor(props) {
        super(props);
        this.state = {
            productList: [],
        }
    }

    componentDidMount() {
        GET_ALL_PRODUCTS('Index')
            .then(response => {
                this.setState({ productList: response.data });
            });
    }

    handleDelete(id) {
        if (window.confirm('Có chắc bạn muốn xóa sản phẩm này?')) {
            DELETE_PRODUCT(`Delete/${id}`)
                .then(response => {
                    console.log(response.data);
                    this.setState({ productList: this.state.productList.filter(item => item.id !== id) });
                });
        } else {
            console.log('Chưa xóa');
        }
    }

    convertCurrentDate(_date) {
        var date = _date.substr(8, 2) + '/' + _date.substr(5, 2) + '/' + _date.substr(0, 4);
        var time = _date.substr(11, 2) + ':' + _date.substr(14, 2) + ':' + _date.substr(17, 2);

        return date + '\r\n' + time;
    }

    render() {
        return (
            <div>
                <div className="admin__heading">
                    <h1 className="products__title">PRODUCT</h1>
                    <button className="btn btn--primary">
                        <Link to="/product/add" className="btn-add-new">
                            <i className="fas fa-plus-square btn--icon--add-new"></i>
                            Add new
                        </Link>
                    </button>
                </div>

                <div className="admin__body">
                    <table className="products-table">
                        <thead>
                            <tr className="products-table__title">
                                <th className="edit--title products-table__title--th">Action</th>
                                <th className="products-table__title--th">Id</th>
                                <th className="products-table__title--th">Image</th>
                                <th className="products-table__title--th">Name</th>
                                <th className="products-table__title--th">Description</th>
                                <th className="products-table__title--th">Price (VND)</th>
                                <th className="products-table__title--th">Discount (%)</th>
                                <th className="products-table__title--th">Store</th>
                                <th className="products-table__title--th">Sold</th>
                                <th className="products-table__title--th">Featured</th>
                                <th className="products-table__title--th">CreateDate</th>
                                <th className="products-table__title--th">UpdateDate</th>
                                <th className="products-table__title--th">Category</th>
                            </tr>
                        </thead>
                        <tbody>
                            {
                                this.state.productList.map((product) => (
                                    <tr className="products-table__data" key={product.id}>
                                        <td className="btn btn--edit">
                                            <Link to={`/product/edit/${product.id}`} className="btn--edit-product">
                                                <i className="fas fa-pencil-alt btn--edit-icon"></i>
                                                Edit
                                            </Link>
                                        </td>
                                        <td className="btn btn--delete btn--delete-product"
                                            onClick={() => this.handleDelete(product.id)}>
                                            <i className="far fa-trash-alt btn--delete-icon"></i>
                                            Delete
                                        </td>
                                        <td className="products-table__data--td">{product.id}</td>
                                        <td className="products-table__data--td">
                                            <img className="products-table__data-img"
                                                src={`${product.image}`} alt="sản phẩm" />
                                        </td>
                                        <td className="products-table__data--td">
                                            <div className="product-table__data--name">
                                                {product.name}
                                            </div>
                                        </td>
                                        <td className="products-table__data--td ">
                                            <div className="product-table__data--description">
                                                {product.description}
                                            </div>
                                        </td>
                                        <td className="products-table__data--td">{product.price}</td>
                                        <td className="products-table__data--td">{product.saleOff}</td>
                                        <td className="products-table__data--td">{product.store}</td>
                                        <td className="products-table__data--td">{product.sold}</td>
                                        <td className="products-table__data--td products-table__icon-decoration">
                                            {product.featured === true
                                                ? <i className="fas fa-check products-table__data--icon-check"></i>
                                                : <i className="fas fa-times products-table__data--icon-cross"></i>}
                                        </td>
                                        <td className="products-table__data--td">{this.convertCurrentDate(product.createdDate)}</td>
                                        <td className="products-table__data--td">{this.convertCurrentDate(product.updatedDate)}</td>
                                        <td className="products-table__data--td">{product.category.name}</td>
                                    </tr>
                                ))
                            }
                        </tbody>
                    </table>
                </div>
            </div>


        )
    }
}
