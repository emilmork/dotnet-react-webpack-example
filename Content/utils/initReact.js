import React from 'react';
import ReactDOM from 'react-dom';

module.exports = (el, component) => {
    ReactDOM.render(React.createElement(component, null), el);
};