function solve(obj) {
    const requestMethods = ['GET', 'POST', 'DELETE', 'CONNECT'];
    const uriRegex = /^([\w\d\.]+|\*)$/g;
    const httpVersions = ['HTTP/0.9', 'HTTP/1.0', 'HTTP/1.1', 'HTTP/2.0'];
    const messageRegex = /^([^<>\\&'"]*)$/g;

    if (!(requestMethods.includes(obj.method) && obj.hasOwnProperty('method'))) {
        throw new Error('Invalid request header: Invalid Method');
    }

    if (!(uriRegex.test(obj.uri) && obj.hasOwnProperty('uri'))) {
        throw new Error('Invalid request header: Invalid URI');
    }

    if (!(httpVersions.includes(obj.version) && obj.hasOwnProperty('version'))) {
        throw new Error('Invalid request header: Invalid Version');
    }

    if (!(messageRegex.test(obj.message) && obj.hasOwnProperty('message'))) {
        throw new Error('Invalid request header: Invalid Message');
    }
    
    return obj;
}
solve({
    method: 'GET',
    uri: 'svn.public.catalog',
    version: 'HTTP/1.1',
    message: ''
}
);
solve({
    method: 'OPTIONS',
    uri: 'git.master',
    version: 'HTTP/1.1',
    message: '-recursive'
}
);
solve({
    method: 'POST',
    uri: 'home.bash',
    message: 'rm -rf /*'
}
);