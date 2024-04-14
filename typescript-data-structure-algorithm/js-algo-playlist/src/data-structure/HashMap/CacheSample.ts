class CacheItem<V> {
    value: V
    expiresAt: number

    constructor(value: V, ttl: number) {
        this.value = value
        this.expiresAt = Date.now() + ttl
    }

    isExpired(): boolean {
        return this.expiresAt < Date.now()
    }
}

class HashMap<K, V> {
    private map: Map<K, CacheItem<V>>
    private ttl: number

    constructor(ttl: number) {
        this.map = new Map<K, CacheItem<V>>()
        this.ttl = ttl
    }

    put(key: K, value: V): void {
        const cacheItem = new CacheItem<V>(value, this.ttl)
        this.map.set(key, cacheItem)
    }

    get(key: K): V | undefined {
        const cacheItem = this.map.get(key)
        if (cacheItem && !cacheItem.isExpired()) {
            return cacheItem.value
        } else {
            this.map.delete(key)
            return undefined
        }
    }

    has(key: K): boolean {
        return this.map.has(key)
    }

    remove(key: K): boolean {
        return this.map.delete(key)
    }

    clear(): void {
        this.map.clear()
    }

    keys(): IterableIterator<K> {
        return this.map.keys()
    }

    values(): IterableIterator<V> {
        return Array.from(this.map.values())
            .filter((item) => !item.isExpired())
            .map((item) => item.value)
            .values()
    }

    entries(): IterableIterator<(K | V)[]> {
        return Array.from(this.map.entries())
            .filter(([_, item]) => !item.isExpired())
            .map(([key, item]) => [key, item.value])
            .values()
    }
}

export abstract class HashMapCacheUsage {
    public static SampleOne(): void {
        console.log('\nHashMap Cache Sample Usage')
        const cache = new HashMap<string, string>(10000)

        cache.put('key1', 'value1')
        cache.put('key2', 'value2')
        cache.put('key3', 'value3')

        // setTimeout(() => {
        //     console.log('key1 value => ', cache.get('key1')) // Output: undefined (expired)
        // }, 5000)

        // setTimeout(() => {
        //     console.log('key2 value => ', cache.get('key2')) // Output: value2 (still valid)
        // }, 15000)

        for (const key of cache.keys()) {
            console.log('keys ', key)
        }

        for (const value of cache.values()) {
            console.log('values ', value)
        }

        for (const [key, value] of cache.entries()) {
            console.log('key, value => ', key + ' ', value)
        }
    }
}
