interface IUser {
    id: number
    name: string
    email: string
}

/** Fetch User simulate */
abstract class FetchUsers {
    public static async FetchUsers(): Promise<IUser[]> {
        return new Promise((resolve) => {
            setTimeout(() => {
                let users: IUser[] = []
                for (let i = 0; i < 60; i++) {
                    users.push({
                        id: i,
                        name: `User ${i}`,
                        email: `user${i}@gmail.com`,
                    })
                }
                resolve(users)
            }, 1000)
        })
    }
}

/** HashMap */
class FetchCacheHashMap<K, V> {
    private map: Map<K, V>

    constructor() {
        this.map = new Map<K, V>()
    }

    set(key: K, value: V): void {
        this.map.set(key, value)
    }

    get(key: K): V | undefined {
        return this.map.get(key)
    }

    getMap() {
        return this.map
    }

    has(key: K): boolean {
        return this.map.has(key)
    }
}

/** Cache */
class UserCache<T> {
    private data: FetchCacheHashMap<string, T>

    constructor() {
        this.data = new FetchCacheHashMap<string, T>()
    }

    setData(key: string, data: T): void {
        this.data.set(key, data)
    }

    getData(key: string): T | undefined {
        const map = this.data.getMap()
        console.log('map', map)
        return this.data.get(key)
    }

    hasData(key: string): boolean {
        return this.data.has(key)
    }
}

/** Get users */
const userCache = new UserCache<IUser[]>()
async function getUsers(): Promise<IUser[]> {
    const cacheKey = 'users' // Cache key for storing users
    if (userCache.hasData(cacheKey)) {
        console.log('Fetching users from cache...')
        return userCache.getData(cacheKey)!
    } else {
        console.log('Fetching users from API...')
        const users = await FetchUsers.FetchUsers()
        userCache.setData(cacheKey, users)
        return users
    }
}

// Example usage
export async function fetchCacheSample() {
    const users1 = await getUsers() // Fetches from API
    console.log('First fetch:', users1.length)

    const users2 = await getUsers() // Fetches from cache
    console.log('Second fetch:', users2.length)
}
