export abstract class RecordSampleOne {
    public static SampleOne(): void {
        console.log('Record Sample Usage ====> ')

        type Fruit = 'apple' | 'banana' | 'orange'
        type Price = number

        const RecordFruits: Record<Fruit, Price> = {
            apple: 0.75,
            banana: 0.75,
            orange: 0.6,
        }

        console.log(RecordFruits.apple)
        console.log(RecordFruits.banana)
        console.log(RecordFruits.orange)
    }
}

export abstract class RecordEcommerceSample {
    public static SampleOne(): void {
        console.log('Record Sample Ecommerce Usage ====> ')
        type OrderId = string
        type OrderStatus = 'pending' | 'processing' | 'shipped' | 'delivered'

        interface IOrder {
            id: OrderId
            status: OrderStatus
            totalPrice: number
        }

        type OrderDictionary = Record<OrderId, IOrder>

        const orders: OrderDictionary = {
            '123': { id: '123', status: 'processing', totalPrice: 50 },
            '456': { id: '456', status: 'shipped', totalPrice: 75 },
            '789': { id: '789', status: 'delivered', totalPrice: 100 },
        }

        console.log('total revenue ....', calculateTotalRevenue(orders))

        function calculateTotalRevenue(orders: OrderDictionary): number {
            let totalRevenue = 0
            for (var orderId in orders) {
                if (orders.hasOwnProperty(orderId)) {
                    totalRevenue += orders[orderId].totalPrice
                }
            }
            return totalRevenue
        }
    }
}

export abstract class GetPropertySample {
    public static SampleOne() {
        const user = {
            name: 'Alice',
            age: 30,
            email: 'alice@gmail.com',
        }

        console.log(this.getProperty(user, 'age'))
        console.log(this.getProperty(user, 'age'))
    }

    private static getProperty<T, K extends keyof T>(obj: T, key: K): T[K] {
        return obj[key]
    }
}
