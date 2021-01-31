import React, { Component } from 'react';
import DisplayFields from './displayFields/DisplayFields';

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
      <div>
        <h1>Properties Table</h1>        
        <DisplayFields/>
      </div>
    );
  }
}
