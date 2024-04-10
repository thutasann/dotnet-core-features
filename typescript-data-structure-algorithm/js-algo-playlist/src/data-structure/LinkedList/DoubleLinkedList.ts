export class Node<T> {
    public data: T
    public prev: Node<T> | null
    public next: Node<T> | null

    constructor(data: T) {
        this.data = data
        this.prev = null
        this.next = null
    }
}

class DoublyLinkedList<T> {
    public head: Node<T> | null
    public tail: Node<T> | null
    private size: number

    constructor() {
        this.head = null
        this.tail = null
        this.size = 0
    }

    public append(data: T): void {
        const newNode = new Node(data)
        if (!this.head) {
            this.head = newNode
            this.tail = newNode
        } else {
            newNode.prev = this.tail
            this.tail!.next = newNode
            this.tail = newNode
        }
        this.size++
    }

    public prepend(data: T): void {
        const newNode = new Node(data)
        if (!this.head) {
            this.head = newNode
            this.tail = newNode
        } else {
            newNode.next = this.head
            this.head!.prev = newNode
            this.head = newNode
        }
        this.size++
    }

    public print(): void {
        let current = this.head
        while (current) {
            console.log('current.data ', current.data)
            current = current.next
        }
    }

    public printReverse(): void {
        let current = this.tail
        while (current) {
            console.log('current.data reverse ', current.data)
            current = current.prev
        }
    }

    public getSize(): number {
        return this.size
    }
}

export abstract class DoublyLinkedListUsage {
    public static SampleOne(): void {
        console.log('\nDoubly Linked List Usage ==>')
        const list = new DoublyLinkedList<number>()
        list.append(1)
        list.append(2)
        list.append(3)
        list.prepend(0)

        console.log('Forward traversal:')
        list.print()

        console.log('Reverse traversal:')
        list.printReverse()

        console.log('Size of the list:', list.getSize())
    }
}
