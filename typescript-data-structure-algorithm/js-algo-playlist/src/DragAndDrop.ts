interface IProduct {
    id: number
    name: string
}

export let products: IProduct[] = [
    { id: 1, name: 'Product 1' },
    { id: 2, name: 'Product 2' },
    { id: 3, name: 'Product 3' },
]

let draggedItem: IProduct | null = null

export function handleDragStart(item: IProduct): void {
    draggedItem = item
}

export function handleDragStop(index: number): void {
    if (draggedItem) {
        const draggedIdex = products.indexOf(draggedItem)
        if (draggedIdex !== -1) {
            // remove the dragged item from its original position
            products.splice(draggedIdex, 1)

            // insert the dragged item at the new position
            products.splice(index, 0, draggedItem)

            draggedItem = null
        }
    }
}
