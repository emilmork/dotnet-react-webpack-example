var path = require('path');

module.exports = {
    context: path.join(__dirname, 'Content'),
    entry: {
        'server': './server',
        'client-index': './client-index',
        'client-about': './client-about'
    },
    output: {
        path: path.join(__dirname, 'Scripts'),
        filename: '[name].bundle.js'
    },
    module: {
        loaders: [
            {
                test: /\.jsx?$/,
                exclude: /node_modules/,
                loader: 'babel'
            }
        ],
    },
    resolve: {
        extensions: ['', '.js', '.jsx']
    }
};