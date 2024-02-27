export class HashTableSampleOne<T> {
    size: number
    table: Array<T>

    constructor(size: number) {
        this.table = new Array(size)
        this.size = size
    }

    private hash(key: string): number {
        let total: number = 0
        for (let i = 0; i < key.length; i++) {
            total += key.charCodeAt(i)
        }
        return total % this.size
    }

    set(key: string, value: T): void {
        const index = this.hash(key)
        this.table[index] = value
    }

    get(key: string): T {
        const index = this.hash(key)
        return this.table[index]
    }

    remove(Key: string): void {
        const index = this.hash(Key)
        delete this.table[index]
    }

    display(): void {
        for (let i = 0; i < this.table.length; i++) {
            if (this.table[i]) {
                console.log(i, this.table[i])
            }
        }
    }

    getTable(): Array<T> {
        return this.table
    }
}

export class HashTableSampleTwo<T> {
    private table: Array<[string, T]>

    constructor() {
        this.table = []
    }

    // hash function to generate a index for a key
    private hash(key: string): number {
        let total = 0
        for (let i = 0; i < key.length; i++) {
            total = (total << 5) + key.charCodeAt(i)
            total = total & total
            total = Math.abs(total)
        }
        return total % 100
    }

    // Add or update a value for a given key
    set(key: string, value: T): void {
        const index = this.hash(key)
        this.table[index] = [key, value]
    }

    get(key: string): T | undefined {
        const index = this.hash(key)
        const entry = this.table[index]
        console.log('entry', entry)
        return entry ? entry[1] : undefined
    }

    remove(key: string): void {
        const index = this.hash(key)
        delete this.table[index]
    }
}
