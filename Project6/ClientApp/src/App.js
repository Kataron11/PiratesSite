import React, { Component } from 'react';
import { Route } from 'react-router-dom';
import { Layout } from './components/Layout';

import { Counter } from './components/Counter';
import { MyBoats } from './components/StartPage/MyBoats';
import { Boats } from './components/StartPage/Boats';
import './custom.css'
import Home from './components/Home';


function App() {

        return (
            <Layout>
                <Route exact path='/StartPage/Boats' component={Boats} />
                <Route path='/StartPage/MyBoats' component={MyBoats} />
            </Layout>
        );
    
}
  
export default App;
