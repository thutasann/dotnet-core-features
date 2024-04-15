import { GenerateRandomUsers } from '../../utils/generate-random-string'
import { IRandomUser } from '../../utils/types'

class HashTableOne<K, V> {
    private readonly capacity: number
    public readonly table: Array<Array<[K, V]>>

    constructor(capacity: number = 10) {
        this.capacity = capacity
        this.table = new Array<Array<[K, V]>>()
    }

    public set(key: K, value: V): void {
        const index = this.hash(key)
        if (!this.table[index]) {
            this.table[index] = []
        }

        // check if the key alrdy exists, if so, update the value
        for (const pair of this.table[index]) {
            if (pair[0] === key) {
                pair[1] = value
                return
            }
        }
        this.table[index].push([key, value])
    }

    public get(key: K): V | undefined {
        const index = this.hash(key)
        if (!this.table[index]) return undefined
        for (const pair of this.table[index]) {
            if (pair[0] === key) {
                return pair[1]
            }
        }
        return undefined
    }

    public getTable() {
        return this.table
    }

    public remove(key: K): void {
        const index = this.hash(key)
        if (!this.table[index]) return
        this.table[index] = this.table[index].filter((pair) => pair[0] !== key)
    }

    public has(key: K): boolean {
        const index = this.hash(key)
        if (!this.table[index]) return false
        for (const pair of this.table[index]) {
            if (pair[0] === key) {
                return true
            }
        }
        return false
    }

    private hash(key: K): number {
        const hashString = String(key)
        let hash = 0
        for (let i = 0; i < hashString.length; i++) {
            hash += hashString.charCodeAt(i) * (i + 1)
        }
        return hash % this.capacity
    }
}

export abstract class HashTableUsageOne {
    public static SampleOne(): void {
        console.log('\nHashTable Usage One : ')
        const hashTable = new HashTableOne<string, IRandomUser>()
        const users = GenerateRandomUsers.generateUserArray(4)
        users.forEach((u) => {
            hashTable.set(u.id.toString(), u)
        })
        console.log(
            'Hash Table => ',
            hashTable.table.flatMap((u) => u)
        )
        console.log('2 user => ', hashTable.get('2'))
    }
}
