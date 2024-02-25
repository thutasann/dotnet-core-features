import { IEmployee } from './types'

export const organization: IEmployee = {
    name: 'Alice',
    children: [
        {
            name: 'Bob',
            children: [
                {
                    name: 'Charlie',
                    children: [{ name: 'David' }, { name: 'Eve' }],
                },
                {
                    name: 'Frank',
                    children: [{ name: 'Grace' }],
                },
            ],
        },
        {
            name: 'Helen',
            children: [
                {
                    name: 'Ivan',
                    children: [{ name: 'John' }, { name: 'Kate' }],
                },
            ],
        },
    ],
}
