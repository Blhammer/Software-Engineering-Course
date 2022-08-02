function solve(inputArr) {
    let result = [];

    for (const iterator of inputArr) {
        let [townName, productName, productPrice] = iterator.split(' | ');
        productPrice = Number(productPrice);
    
        if(result.filter(x => x.productName === productName).length > 0) {
            let obj = result.find(x => x.productName === productName);

            if(obj.productPrice > productPrice) {
                obj.productPrice = productPrice;
                obj.townName = townName;
            }

        } else {
                let obj = {townName, productName, productPrice};
                result.push(obj);
            }
    }
    
    for (const product of result) {
        console.log(`${product.productName} -> ${product.productPrice} (${product.townName})`);
    }
}
solve(['Sample Town | Sample Product | 1000',
    'Sample Town | Orange | 2',
    'Sample Town | Peach | 1',
    'Sofia | Orange | 3',
    'Sofia | Peach | 2',
    'New York | Sample Product | 1000.1',
    'New York | Burger | 10']
);