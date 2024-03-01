import { ICategory, INestedObject } from './types'

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

export const nestedObj: INestedObject = {
    a: 1,
    b: {
        c: 2,
        d: {
            e: 3,
            f: {
                g: 4,
                h: [5, 6, 7],
            },
        },
    },
    i: [8, 9, 10],
}

export const flatNestedObj: INestedObject = {
    a: 1,
    b: {
        c: 2,
        d: {
            e: 3,
            f: {
                g: 4,
            },
        },
    },
    h: [5, 6, 7],
}
