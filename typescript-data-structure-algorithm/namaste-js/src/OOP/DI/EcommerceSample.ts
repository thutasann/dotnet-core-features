interface IProduct {
    id: number
    name: string
    price: number
}

export class ShoppingCart {
    private items: IProduct[] = []

    addItems(item: IProduct): void {
        this.items.push(item)
    }

    getItems(): IProduct[] {
        return this.items
    }
}

export class OrderService {
    constructor(private shoppingCart: ShoppingCart) {}

    placeOrder(): void {
        const items = this.shoppingCart.getItems()
        console.log('Order placed with items =>', items)
    }
}

/** Depedency Injection Container */
export class DIContainer {
    private instances: Map<string, any> = new Map()

    register(key: string, instance: any): void {
        this.instances.set(key, instance)
    }

    resolve<T>(key: string): T {
        if (!this.instances.has(key)) {
            throw new Error(`Dependency ${key} is not registered.`)
        }
        return this.instances.get(key)
    }
}
