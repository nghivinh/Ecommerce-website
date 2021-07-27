import React, { Component } from 'react'
import "./Category.css";
import { DELETE_CATEGORY, GET_ALL_CATEGORIES } from '../../HTTPServer/httpCategory.js';
import { Link } from 'react-router-dom';

export default class Category extends Component {
    constructor(props) {
        super(props);
        this.state = {
            categoryList: [],
        }
    }

    componentDidMount() {
        GET_ALL_CATEGORIES('Index')
            .then(response => {
                this.setState({ categoryList: response.data });
            });
    }

    handleDelete(id) {
        if (window.confirm('Có chắc bạn muốn xóa danh mục này?')) {
            DELETE_CATEGORY(`Delete/${id}`)
                .then(response => {
                    console.log(response.data);
                    this.setState({ categoryList: this.state.categoryList.filter(item => item.id !== id) });
                });
        } else {
            console.log('Chưa xóa');
        }
    }

    render() {
        return (
            <div>
                <div className="admin__heading">
                    <h1 className="categories__title">CATEGORIES</h1>
                    <button className="btn btn--primary">
                        <Link to="/category/add" className="btn-add-new">
                            <i className="fas fa-plus-square btn--icon--add-new"></i>
                            Add new
                        </Link>
                    </button>
                </div>
                <div className="admin__body">
                    <table className="categories-table">
                        <thead>
                            <tr className="categories-table__title">
                                <th className="categories-table__title--th categories__action">Action</th>
                                <th className="categories-table__title--th categories__id">Id</th>
                                <th className="categories-table__title--th categories__name">Name</th>
                                <th className="categories-table__title--th categories__desc">Description</th>
                            </tr>
                        </thead>
                        <tbody>
                            {
                                this.state.categoryList.map((category) => (
                                    <tr className="categories-table__data" key={category.id}>
                                        <td className="btn btn--edit">
                                            <Link to={`/category/edit/${category.id}`} className="btn--edit-product">
                                                <i className="fas fa-pencil-alt btn--edit-icon"></i>
                                                Edit
                                            </Link>
                                        </td>
                                        <td className="btn btn--normal btn--delete"
                                            onClick={() => this.handleDelete(category.id)}>
                                            <i className="far fa-trash-alt btn--delete-icon"></i>
                                            Delete
                                        </td>
                                        <td className="categories-table__data--td text--center">{category.id}</td>
                                        <td className="categories-table__data--td">{category.name}</td>
                                        <td className="categories-table__data--td">{category.description}</td>
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
