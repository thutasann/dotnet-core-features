class HashMap<K, V> {
    private map: Map<number, Array<[K, V]>>
    private capacity: number

    constructor(capacity: number = 10) {
        this.capacity = capacity
        this.map = new Map<number, Array<[K, V]>>()
        for (let i = 0; i < this.capacity; i++) {
            this.map.set(i, [])
        }
    }

    private hash(key: K): number {
        if (typeof key === 'string') {
            let hashValue = 0
            for (let i = 0; i < key.length; i++) {
                hashValue += key.charCodeAt(i)
            }
            return hashValue % this.capacity
        } else if (typeof key === 'number') {
            return key % this.capacity
        } else {
            throw new Error('Unsupported key type')
        }
    }

    public put(key: K, value: V): void {
        const index = this.hash(key)
        const bucket = this.map.get(index)
        if (bucket) {
            for (const pair of bucket) {
                if (pair[0] === key) {
                    pair[1] = value
                    return
                }
            }
            bucket.push([key, value])
        }
    }

    public get(key: K): V | undefined {
        const index = this.hash(key)
        const bucket = this.map.get(index)
        if (bucket) {
            for (const pair of bucket) {
                if (pair[0] === key) {
                    return pair[1]
                }
            }
        }
        return undefined
    }

    public remove(key: K): void {
        const index = this.hash(key)
        const bucket = this.map.get(index)
        if (bucket) {
            this.map.set(
                index,
                bucket.filter((pair) => pair[0] !== key)
            )
        }
    }

    public getMap() {
        return this.map
    }
}

export abstract class HashMapUsageSampleOne {
    public static SampleOne(): void {
        console.log('\nHashMap Usage Sample One ==> ')
        const map = new HashMap<string, number>()
        map.put('a', 1)
        map.put('b', 2)
        map.put('c', 3)
        map.put('d', 4)

        console.log('a value => ', map.get('a'))
        console.log('b value => ', map.get('b'))
    }
}
