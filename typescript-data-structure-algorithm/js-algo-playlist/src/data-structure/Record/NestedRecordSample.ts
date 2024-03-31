type User = {
    id: number
    name: string
}
type RolesProps = 'admin' | 'moderator'
type UsersByRole = Record<RolesProps, Record<number, User>>

type Product = {
    id: number
    name: string
    price: number
}
type Category = Record<string, Record<string, Record<number, Product>>>

export abstract class NestedRecordSampleOne {
    public static SampleOne() {
        console.log('Nested Record Sample One ==> ')
        const usersByRole: UsersByRole = {
            admin: {
                1: { id: 1, name: 'Admin 1' },
                2: { id: 2, name: 'admin 2' },
            },
            moderator: {
                1: { id: 1, name: 'Moderator 1' },
                2: { id: 2, name: 'Moderator 2' },
            },
        }

        console.log(usersByRole.admin[1])

        const user = this.FindUser(usersByRole, 'admin', 1)
        if (user) console.log('find user result => ', user)
        console.log('user not found')
    }

    public static SampleTwo() {
        console.log('Nested Record Sample Two ==> ')

        const productsByCategory: Category = {
            electronics: {
                phones: {
                    1: { id: 1, name: 'iPhone', price: 999 },
                    2: { id: 2, name: 'Samsung Galaxy', price: 899 },
                },
                laptops: {
                    1: { id: 1, name: 'MacBook Pro', price: 1499 },
                    2: { id: 2, name: 'Dell XPS', price: 1299 },
                },
            },
            clothing: {
                shirts: {
                    1: { id: 1, name: 'T-Shirt', price: 19.99 },
                    2: { id: 2, name: 'Polo Shirt', price: 29.99 },
                },
                pants: {
                    1: { id: 1, name: 'Jeans', price: 39.99 },
                    2: { id: 2, name: 'Chinos', price: 49.99 },
                },
            },
        }
        console.log(productsByCategory.electronics.phones[1])
    }

    private static FindUser(user: UsersByRole, role: string, id: number): User | undefined {
        return user[role]?.[id]
    }
}
