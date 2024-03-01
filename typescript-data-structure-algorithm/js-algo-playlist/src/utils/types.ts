export interface ICategory {
    id: number
    name: string
    subcategories?: ICategory[]
    products?: number // Number of products in the category
}
