import { ICategory } from './types'

export const category: ICategory = {
    id: 1,
    name: 'Electronics',
    subcategories: [
        {
            id: 2,
            name: 'Laptops',
            products: 50,
        },
        {
            id: 3,
            name: 'Smartphones',
            subcategories: [
                {
                    id: 4,
                    name: 'Android Phones',
                    products: 30,
                },
                {
                    id: 5,
                    name: 'iOS Phones',
                    products: 20,
                },
            ],
        },
    ],
}
