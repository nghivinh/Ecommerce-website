import React, { Component } from 'react'
import { Redirect } from 'react-router-dom';
import { EDIT_CATEGORY, GET_CATEGORY } from '../../HTTPServer/httpCategory';

export default class EditCategory extends Component {
    constructor(props) {
        super(props);
        this.state = {
            categoryId: 0,
            name: "",
            description: "",
            redirect: false
        }
    }

    componentDidMount() {
        GET_CATEGORY('Details', this.props.match.params.id)
            .then(category => {
                this.setState({ categoryId: category.data.id });
                this.setState({ name: category.data.name });
                this.setState({ description: category.data.description });
            });
    }

    handleFormSubmit(e) {
        e.preventDefault();

        const category = {
            name: e.target.name.value,
            description: this.n2rn(e.target.description.value),
        }

        EDIT_CATEGORY(`Edit/${this.state.categoryId}`, category)
            .then(response => {
                console.log(category);
                if (response.data === 1) {
                    alert("Cập nhật danh mục thành công");
                    this.setState({ redirect: true });
                } else {
                    alert("Có lỗi xảy ra, vui lòng thử lại sau");
                }
            });
    }

    n2rn(str) {
        return (str).replaceAll('\n', '\r\n');
    }

    render() {
        const redirect = this.state.redirect;
        if (redirect) {
            return <Redirect to='/category' />
        }
        return (
            <form id="formAddCategory" onSubmit={(e) => this.handleFormSubmit(e)}>
                <div class="admin__heading">
                    <h1 class="admin__add-new-title">EDIT CATEGORY</h1>
                    <button class="btn btn--primary">
                        <i class="far fa-save btn--save-icon"></i>
                        Save
                    </button>
                </div>

                <div class="admin__add-new-data">
                    <div class="category-name">
                        <div class="category-name__title">Name</div>
                        <input type="text" class="category-name__input" autoComplete="off"
                            name="name" defaultValue={this.state.name} />
                    </div>
                    <div class="category-description">
                        <p class="category-description__title">Description</p>
                        <textarea type="text" class="category-description__input" rows="6" autoComplete="off"
                            name="description" defaultValue={this.state.description}></textarea>
                    </div>
                </div>
            </form>
        )
    }
}
