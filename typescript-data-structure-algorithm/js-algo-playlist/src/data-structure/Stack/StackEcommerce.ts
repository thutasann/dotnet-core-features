interface IProduct {
    id: number
    name: string
    price: number
}

interface IEcommerceStack<T> {
    push(item: T): void
    pop(): T | undefined
    peek(): T | undefined
    isEmpty(): boolean
}

interface IShoppingCart<T> {
    addToCart(product: T): void
    checkout(): void
}

class EcommerceStack<T> implements IEcommerceStack<T> {
    private items: T[]

    constructor() {
        this.items = []
    }

    push(item: T): void {
        this.items.push(item)
    }

    pop(): T | undefined {
        return this.items.pop()
    }

    peek(): T | undefined {
        return this.items[this.items.length - 1]
    }

    isEmpty(): boolean {
        return this.items.length === 0
    }
}

export class StackShoppingCart implements IShoppingCart<IProduct> {
    private stack: EcommerceStack<IProduct>

    constructor() {
        this.stack = new EcommerceStack<IProduct>()
    }

    public addToCart(product: IProduct): void {
        this.stack.push(product)
    }

    public checkout(): void {
        while (!this.stack.isEmpty()) {
            const product = this.stack.pop()
            if (product) {
                console.log(`${product.name} removed from cart. Price: $${product.price}`)
            }
        }
        console.log('Checkout completed.')
    }
}

/**
 * ----------- Stack Ecommerce Usage -----------
 */
export abstract class StackEcommerceUsage {
    public static SampleOne() {
        console.log('StackEcommerceUsage ===>')
        const cart = new StackShoppingCart()
        cart.addToCart({ id: 1, name: 'Laptop', price: 999 })
        cart.addToCart({ id: 2, name: 'Mouse', price: 20 })
        cart.addToCart({ id: 3, name: 'Keyboard', price: 50 })

        cart.checkout()
    }
}
