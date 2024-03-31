interface IStack<T> {
    push(item: T): void
    pop(): T | undefined
    peek(): T | undefined
    isEmpty(): boolean
    size(): number
    clear(): void
    print(): void
}

export class Stack<T> implements IStack<T> {
    private items: T[]

    constructor() {
        this.items = []
    }

    push(item: T): void {
        this.items.push(item)
    }

    pop(): T | undefined {
        return this.items.pop()
    }

    peek(): T | undefined {
        return this.items[this.items.length - 1]
    }

    isEmpty(): boolean {
        return this.items.length === 0
    }

    size(): number {
        return this.items.length
    }

    clear(): void {
        this.items = []
    }

    print(): void {
        console.log('items', this.items)
    }
}

export abstract class StackUsage {
    public static SampleOne(): void {
        console.log('Stack Usage ===> ')
        const stack = new Stack<number>()

        stack.push(1)
        stack.push(2)
        stack.push(3)

        stack.print()

        console.log('Popped item => ', stack.pop())
        console.log('Peek after pop => ', stack.peek())

        console.log('Stack size => ', stack.size())
        console.log('Is Empty => ', stack.isEmpty())
    }
}
