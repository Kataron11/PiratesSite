import React, { Component, useEffect, useState } from 'react';
import "./CssFile/Home.css";



function Home() {

    const [account, setAccount] = useState({ Login: '', Password: '' });
    const [responeAccount, setResponseAccount] = useState(false);
    const [passwordValid, setPasswordValid] = useState('');
    const [loginValid, setLoginValid] = useState('');
    const [loginDatabaseValid, setLoginDatabaseVali] = useState('');
    const [buttonLogin, setButtonLogin] = useState(false);
    const [buttonRegister, setButtonRegister] = useState(false);


    const initialValid = () => {
        setLoginValid('');
        setPasswordValid('');
    }

    async function find(event) {
        event.preventDefault();
        const response = await fetch('api/Account/CreateAccount', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json; charset=utf-8'
            },
            body: JSON.stringify({ Login: account.Login, Password: account.Password })
        });

        initialValid();
        const data = await response.json();
        if (data.length != 0 && !response.ok) {
            var password = data.find(e => e.propertyName === 'Password');

            if (password != null)
                setPasswordValid(password.errorMessage);

            var login = data.find(e => e.propertyName === 'Login');

            if (login != null)
                setLoginValid(login.errorMessage);
        }
        else {
            setResponseAccount(true);
            setAccount({ Login: '', Password: '' });
            setButtonRegister(false);
        }


    }

    async function logAccount(event) {
        event.preventDefault();
        const response = await fetch('api/Account/LoginAccount', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json; charset=utf-8'
            },
            body: JSON.stringify({ Login: account.Login, Password: account.Password })
        })

        if (!response.ok) {
            setPasswordValid("B³êdne dane");
        }
        else {
            setResponseAccount(true);
            setAccount({ Login: '', Password: '' });
            setButtonLogin(false);
        }
    }


    const changeLogin = (e) => {
        setAccount({ ...account, Login: e.target.value })
    }

    const changePassword = (e) => {
        setAccount({ ...account, Password: e.target.value })
    }

    const changeLoginButton = (e) => {
        setButtonLogin(true);
        setButtonRegister(false);
    }
    const changeRegisterButton = (e) => {
        setButtonLogin(false);
        setButtonRegister(true);
    }
    return (
         <div>
                <h1>Witaj morski œwiecie!</h1>
            <p>Zapraszamy do zalogowania i wziêcia udzia³u w pirackiej przygodzie.</p>
            <div className="startPage">
                    <button onClick={changeLoginButton}>Logowanie</button>
                </div>
            <div className="startPage" >
                    <button onClick={changeRegisterButton}>Rejestracja</button>
            </div>
            {
                buttonRegister &&
                <div>
                    <form onSubmit={find}>
                        <label>
                            <p>Login</p>
                            <input type="text" onChange={changeLogin} value={account.Login} />
                        </label>
                        {loginValid && <div className="invalid">{loginValid}</div>}
                        <label>
                            <p>Has³o</p>
                            <input type="password" onChange={changePassword} value={account.Password} />
                        </label>
                        {passwordValid && <div className="invalid">{passwordValid}</div>}
                        <div>
                            <button type="submit">Zarejestruj!</button>
                        </div>
                    </form>
                </div>
            }
            {
                buttonLogin &&
                <div>
                    <form onSubmit={logAccount}>
                        <label>
                            <p>Login</p>
                            <input type="text" onChange={changeLogin} value={account.Login} />
                        </label>
                        {loginValid && <div className="invalid">{loginValid}</div>}
                        <label>
                            <p>Has³o</p>
                            <input type="password" onChange={changePassword} value={account.Password} />
                        </label>
                        {passwordValid && <div className="invalid">{passwordValid}</div>}
                        <div>
                            <button type="submit">Zaloguj!</button>
                        </div>
                    </form>
                </div>
            }




            </div >
        );
    

}

export default Home;