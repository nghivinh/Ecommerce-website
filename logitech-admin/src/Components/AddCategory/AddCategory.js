import React, { Component } from 'react'
import { Redirect } from 'react-router-dom';
import { ADD_CATEGORY } from '../../HTTPServer/httpCategory';
import "./AddCategory.css";

export default class AddCategory extends Component {
    constructor(props) {
        super(props);
        this.state = {
            redirect: false
        }
    }

    handleFormSubmit(e) {
        e.preventDefault();

        const category = {
            name: e.target.name.value,
            description: this.n2rn(e.target.description.value)
        }

        ADD_CATEGORY('Create', category)
            .then(response => {
                console.log(category);
                if (response.data === 1) {
                    alert("Thêm danh mục mới thành công");
                    this.setState({redirect: true});
                } else {
                    alert("Có lỗi xảy ra, vui lòng thử lại sau");
                }
            });
    }

    n2rn (str) {
        return (str).replaceAll('\n','\r\n');
    }

    render() {
        const redirect = this.state.redirect;
        if(redirect) {
            return <Redirect to='/category'/>
        }
        return (
            <form id="formAddCategory" onSubmit={(e) => this.handleFormSubmit(e)}>
                <div class="admin__heading">
                    <h1 class="admin__add-new-title">ADD CATEGORY</h1>
                    <button class="btn btn--primary">
                        <i class="far fa-save btn--save-icon"></i>
                        Save
                    </button>
                </div>

                <div class="admin__add-new-data">
                    <div class="category-name">
                        <div class="category-name__title">Name</div>
                        <input type="text" name="name" class="category-name__input" autoComplete="off"/>
                    </div>
                    <div class="category-description">
                        <p class="category-description__title">Description</p>
                        <textarea type="text" name="description" class="category-description__input" rows="6" autoComplete="off"></textarea>
                    </div>
                </div>
            </form>
        )
    }
}
