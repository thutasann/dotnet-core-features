// Interface representing a product
interface Product {
    id: number
    name: string
    price: number
}

// Interface representing a user
interface User {
    id: number
    username: string
    email: string
}

// Interface representing an order
interface Order {
    id: number
    user: User
    products: Product[]
    totalPrice: number
    status: string
}

interface IPaymentMethod {
    /** Order Pay method */
    pay(order: Order): void
}

/** Abstract base PaymentGateway class */
abstract class PaymentGateway implements IPaymentMethod {
    abstract pay(order: Order): void
}

/** Concrete implmentation of `PaymentGateway` for credit card payments */
export class CreditCardPayment extends PaymentGateway {
    pay(order: Order): void {
        console.log(`Processing credit card payment for order ${order.id}`)
    }
}

/** Concrete implementation of `PaymentGateway` for PayPal payment */
class PaypalPayment extends PaymentGateway {
    pay(order: Order): void {
        console.log(`Processing Paypal Payment for order ${order.id}`)
    }
}

export class AbstractOrderService {
    constructor(private paymentMethod: IPaymentMethod) {}

    checkout(order: Order): void {
        console.log(`Processing order ${order.id} checkout...`)

        this.paymentMethod.pay(order)

        order.status = 'paid'
        console.log(`Order ${order.id} successfully paid`)
    }
}

export const abstractUser: User = { id: 1, username: 'user1', email: 'user1@example.com' }
export const abstractProducts: Product[] = [
    { id: 1, name: 'Product 1', price: 10 },
    { id: 2, name: 'Product 2', price: 20 },
]
export const abstractOrder: Order = {
    id: 1,
    user: abstractUser,
    products: abstractProducts,
    totalPrice: 30,
    status: 'Pending',
}
