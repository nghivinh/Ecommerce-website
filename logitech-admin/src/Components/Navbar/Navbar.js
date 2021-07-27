import React, { Component } from 'react'
import { Link } from 'react-router-dom';
import './Navbar.css';

export default class Navbar extends Component {
    render() {
        return (
            <div className="container__menu">
                <nav className="menu">
                    <div className="header__logo">
                        <Link to="/" className="header__logo-link">
                            <img src="./assets/img/logitech-logo.png" alt="Vivian Cosmetic"
                                className="header__logo-img" />
                        </Link>
                    </div>
                    <ul className="menu-list">
                        <li className="menu-item">
                            <Link to="/category" className="menu-item__link">Categories</Link>
                        </li>
                        <li className="menu-item">
                            <Link to="/product" className="menu-item__link">Products</Link>
                        </li>
                        <li className="menu-item">
                            <Link to="/customer" className="menu-item__link">Customers</Link>
                        </li>
                    </ul>
                </nav>
            </div>
        )
    }
}

