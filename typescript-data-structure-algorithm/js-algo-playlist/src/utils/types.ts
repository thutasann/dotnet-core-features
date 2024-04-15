export interface ICategory {
    id: number
    name: string
    subcategories?: ICategory[]
    products?: number // Number of products in the category
}

export interface INestedObject {
    [key: string]: any
}

export interface IRandomUser {
    id: number
    name: string
    nicename: string
    displayname: string
}
