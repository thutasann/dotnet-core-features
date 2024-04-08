export class Node<T> {
    data: T
    prev: Node<T> | null
    next: Node<T> | null

    constructor(data: T) {
        this.data = data
        this.prev = null
        this.next = null
    }
}

export class UndoRedo<T> {
    current: Node<T> | null
    head: Node<T> | null

    constructor() {
        this.current = null
        this.head = null
    }

    // add a new action to the history
    addAction(data: T): void {
        const newNode = new Node(data)
        if (!this.current) {
            this.head = newNode
        } else {
            newNode.prev = this.current
            this.current.next = newNode
        }
        this.current = newNode
    }

    // undo the last action
    undo(): T | undefined {
        if (this.current && this.current.prev) {
            this.current = this.current.prev
            return this.current.data
        }
        return undefined
    }

    // redo the last undone action
    redo(): T | undefined {
        if (this.current && this.current.next) {
            this.current = this.current.next
            return this.current.data
        }
        return undefined
    }

    printHistory(): void {
        let current = this.head
        while (current) {
            console.log('actions => ', current.data)
            current = current.next
        }
    }
}

export abstract class UndoRedoLinkedListUsage {
    public static SampleOne() {
        console.log('\nUndo Redo Usage Sample ==> ')
        const undoRedo = new UndoRedo<string>()
        undoRedo.addAction('Action 1')
        undoRedo.addAction('Action 2')
        undoRedo.addAction('Action 3')
        undoRedo.printHistory()

        console.log('Undo: ', undoRedo.undo()) // Action 2
        console.log('Undo: ', undoRedo.undo()) // Action 1

        console.log('redo: ', undoRedo.redo()) // Action 2
        console.log('After undo redo: ')
        undoRedo.printHistory()
    }
}
