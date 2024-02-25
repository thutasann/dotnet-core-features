export type NestedObject = {
    [key: string]: any
}

export interface IEmployee {
    name: string
    children?: IEmployee[]
}
