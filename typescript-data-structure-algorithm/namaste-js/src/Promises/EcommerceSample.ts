interface Product {
    id: number
    name: string
    price: number
}

function runImmediately() {
    console.log('Function that runs immediately')
}

function fetchProducts(callback: (error: Error | null, products?: Product[]) => void): void {
    setTimeout(() => {
        // Assuming the API call is successful
        const products: Product[] = [
            { id: 1, name: 'Product 1', price: 10 },
            { id: 2, name: 'Product 2', price: 20 },
            { id: 3, name: 'Product 3', price: 30 },
        ]

        callback(null, products)
    }, 1000)
}

function fetchProductsPromise(): Promise<Product[]> {
    return new Promise((resolve, reject) => {
        fetchProducts((error, products) => {
            if (error) {
                reject(error)
            } else {
                if (products) resolve(products!)
            }
        })
    })
}

fetchProductsPromise()
    .then((products) => {
        console.log('products => ', products)
    })
    .catch((error) => {
        console.error('Error fetching products:', error.message)
    })

runImmediately()
