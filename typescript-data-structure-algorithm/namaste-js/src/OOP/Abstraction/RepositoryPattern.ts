interface IRepository<T> {
    getAll(): Promise<T[]>
    getById(id: number): Promise<T | undefined>
    create(item: T): Promise<void>
    update(item: T): Promise<void>
    delete(id: number): Promise<void>
}

interface IProduct {
    id: number
    name: string
    price: number
}

export class ProductRepository implements IRepository<IProduct> {
    private products: IProduct[] = []

    async getAll(): Promise<IProduct[]> {
        return this.products
    }

    async getById(id: number): Promise<IProduct | undefined> {
        return this.products.find((p) => p.id === id)
    }

    async create(item: IProduct): Promise<void> {
        this.products.push(item)
    }

    async update(item: IProduct): Promise<void> {
        const index = this.products.findIndex((p) => p.id === item.id)
        if (index !== -1) {
            this.products[index] = item
        }
    }

    async delete(id: number): Promise<void> {
        this.products = this.products.filter((p) => p.id !== id)
    }
}

/**
 * # Repository Patterrn
 * @description
 * - The Repository Pattern is a design pattern commonly used in software development to abstract the data access layer from the rest of the application
 * - It provides a way to centralize data access logic and encapsulate the details of how data is fetched, stored, and manipulated.
 */
export async function testRepositoryPattern() {
    console.log('------>> Repositoyr Pattern Sample  🚀 ')

    const productRepository = new ProductRepository()

    await productRepository.create({ id: 1, name: 'Product 1', price: 100 })

    console.log(productRepository.getAll())

    // Get product by ID
    const productById = await productRepository.getById(1)
    console.log('Product by ID:', productById)

    // Update a product
    if (productById) {
        productById.price = 20
        await productRepository.update(productById)
    }

    console.log('after update', productRepository.getAll())
}
