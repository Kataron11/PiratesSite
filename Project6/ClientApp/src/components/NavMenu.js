import React, { Component } from 'react';
import { Collapse, Container, Navbar, NavbarBrand, NavbarToggler, NavItem, NavLink } from 'reactstrap';
import { Link } from 'react-router-dom';
import './NavMenu.css';

export class NavMenu extends Component {
    static displayName = NavMenu.name;

    constructor(props) {
        super(props);

        this.toggleNavbar = this.toggleNavbar.bind(this);
        this.logoutNav = this.logoutNav.bind(this);
        this.state = {
            collapsed: true,
            login: localStorage.getItem('myData')
        };
    }

    toggleNavbar() {
        this.setState({
            collapsed: !this.state.collapsed
        });
  
    }

    logoutNav() {
        this.setState({ login: localStorage.setItem('myData', false) })
    }

    render() {
        return (
            <header>
                <Navbar className="navbar-expand-sm navbar-toggleable-sm ng-white border-bottom box-shadow mb-3" light>
                   
                        <NavbarBrand tag={Link} to="/">Statki Pirackie the Game</NavbarBrand>
                        <NavbarToggler onClick={this.toggleNavbar} className="mr-2" />
                        <Collapse className="d-sm-inline-flex flex-sm-row-reverse" isOpen={!this.state.collapsed} navbar>
                            <ul className="navbar-nav flex-grow">
                                <NavItem>
                                    <NavLink tag={Link} className="text-dark" to="/boats">Statki do kupna</NavLink>
                                </NavItem>
                                <NavItem>
                                    <NavLink tag={Link} className="text-dark" to="/MyBoats">Moje statki</NavLink>
                            </NavItem>
                            {this.state.login == "true" && 
                                <NavItem>
                                <NavLink onClick={this.logoutNav} tag={Link} className="text-dark" to="/Home">Wyloguj</NavLink>
                                </NavItem>
                            }
                            {this.state.login == "false" &&
                                <NavItem>
                                    <NavLink tag={Link} className="text-dark" to="/Home">Zaloguj/Zajerestruj</NavLink>
                                </NavItem>
                            }

                            </ul>
                    </Collapse>
                    
                        
                    
                    
                </Navbar>
            </header>
        );
    }
}
