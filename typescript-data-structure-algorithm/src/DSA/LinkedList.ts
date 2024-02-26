/** List Node */
class ListNode<T> {
    data: T
    next: ListNode<T> | null

    constructor(data: T) {
        this.data = data
        this.next = null
    }
}

interface ILinkedList<T> {
    isEmpty(): boolean
    getSize(): number
    add(data: T): void
    print(): void
}

/**
 * ## Linked List
 * @description
 * A linear Data Structure that includes a series of connected nodes.
 * Each node consists of a data value and a pointer that points to the next node.
 * Advantage : The list elements can be easily inserted or removed without reallocation or reorganization of the entire structure. The items need not be stored continuously in the memory.
 * Drawback : Random access of elements is not feasible and accessing an element has linear time complexity
 */
export class LinkedList<T> implements ILinkedList<T> {
    head: ListNode<T> | null
    size: number

    constructor() {
        this.head = null
        this.size = 0
    }

    isEmpty(): boolean {
        return this.size === 0
    }

    getSize(): number {
        return this.size
    }

    add(data: T): void {
        const newNode = new ListNode(data)
        if (!this.head) {
            this.head = newNode
        } else {
            let current = this.head
            while (current.next) {
                current = current.next
            }
            current.next = newNode
        }
        this.size++
    }

    print(): void {
        let current = this.head
        while (current) {
            console.log('current.data', current.data)
            current = current.next
        }
    }
}
