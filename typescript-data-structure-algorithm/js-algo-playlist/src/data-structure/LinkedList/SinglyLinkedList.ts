class Node<T> {
    data: T
    next: Node<T> | null

    constructor(data: T) {
        this.data = data
        this.next = null
    }
}

/**
 * Singly Linked List Sample One
 */
export class SinglyLinkedList<T> {
    head: Node<T> | null
    size: number

    constructor() {
        this.head = null
        this.size = 0
    }

    public append(data: T): void {
        const newNode = new Node(data)
        if (!this.head) {
            this.head = newNode
        } else {
            let current = this.head
            while (current.next) {
                current = current.next
                console.log('current', current)
            }
            current.next = newNode
        }
        this.size++
    }

    print(): void {
        let current = this.head
        while (current) {
            console.log(current.data)
            current = current.next
        }
    }
}

/**
 * Singly Linked List Sample Two
 */
export class SinglyLinkedListTwo<T> {
    head: Node<T> | null
    size: number

    constructor() {
        this.head = null
        this.size = 0
    }

    append(data: T): void {
        const newNode = new Node(data)
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

    insertAt(data: T, position: number): void {
        if (position < 0 || position > this.size) {
            throw new Error('Invalid position')
        }

        const newNode = new Node(data)
        if (position === 0) {
            newNode.next = this.head
        } else {
            let current = this.head
            let prev: Node<T> | null = null
            for (let i = 0; i < position; i++) {
                prev = current
                current = current!.next
            }
            newNode.next = current
            if (prev) {
                prev.next = newNode
            }
        }
        this.size++
    }

    removeAt(position: number): T | undefined {
        if (position < 0 || position >= this.size) {
            throw new Error('Invalid position')
        }

        let removedData: T | undefined
        if (position == 0) {
            removedData = this.head!.data
            this.head = this.head!.next
        } else {
            let current = this.head
            let prev: Node<T> | null = null
            for (let i = 0; i < position; i++) {
                prev = current
                current = current!.next
            }
            removedData = current!.data
            if (prev) {
                prev.next = current!.next
            }
        }
        this.size--
        return removedData
    }

    getAt(position: number): T | undefined {
        if (position < 0 || position >= this.size) {
            throw new Error('Invalid position')
        }
        let current = this.head
        for (let i = 0; i < position; i++) {
            current = current!.next
        }
        return current!.data
    }

    print(): void {
        let current = this.head
        while (current) {
            console.log(current.data)
            current = current.next
        }
    }
}

/**
 * Singly LinkedList Usage
 */
export abstract class SinglyLinkedListUsage {
    public static SampleOne() {
        console.log('\nSingly LinkedList Usage One ===> ')
        const list = new SinglyLinkedList<number>()
        list.append(1)
        list.append(2)
        list.append(3)
        console.log('size => ', list.size)
        console.log('head => ', list.head)
    }

    public static SampleTwo() {
        console.log('\nSingly LinkedList Usage Two ===> ')
        const list = new SinglyLinkedListTwo<number>()
        list.append(1)
        list.append(2)
        list.append(3)
        list.insertAt(4, 1)
        console.log('getAt => ', list.getAt(1))
        list.print()
    }
}
