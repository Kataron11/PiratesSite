import React, { Component } from 'react';
import { Route } from 'react-router-dom';
import { Layout } from './components/Layout';
import './custom.css'
import Home from './components/Home';
import Boats from './components/StartPage/Boats';


function App() {

        return (
            <Layout>
                <Route path='' component={Home} />
                <Route path='/boats' component={Boats} />
            </Layout>
        );
    
}
  
export default App;
