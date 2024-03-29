type KeyProps = 'firstName' | 'lastName'

type IPerson = {
    [key in KeyProps]: string
}

export class HashTableSampleOne {
    public table = new Array(3)
    private numItems: number = 0

    /** key value pair sample */
    public Intro(): void {
        const person: IPerson = {
            firstName: '',
            lastName: '',
        }
        person['firstName'] = 'Thuta'
        person['lastName'] = 'Sann'

        console.log('person =>', person)
    }

    /** get item with key */
    public getItem(key: string): string | null {
        const idx = this.hashStringToInt(key, this.table.length)
        if (!this.table[idx]) return null
        return this.table[idx].find((x) => x[0] === key)[1]
    }

    /** set key with value */
    public setItem(key: string, value: string): void {
        this.numItems++
        const loadFactor: number = this.numItems / this.table.length
        if (loadFactor > 0.8) {
            console.log('resizing....')
            this.resize()
        }
        const idx = this.hashStringToInt(key, this.table.length)
        if (this.table[idx]) {
            this.table[idx].push([key, value])
        } else {
            this.table[idx] = [[key, value]]
        }
    }

    /** hash fnc */
    private hashStringToInt(key: string, tableSize: number): number {
        let hash = 17

        for (let i = 0; i < key.length; i++) {
            hash = (12 * hash * key.charCodeAt(i)) % tableSize
        }
        return hash
    }

    /** resize fnc */
    private resize(): void {
        const newTable = new Array(this.table.length * 2)
        this.table.forEach((item) => {
            if (item) {
                item.forEach(([key, value]) => {
                    const idx = this.hashStringToInt(key, newTable.length)
                    if (newTable[idx]) {
                        newTable[idx].push([key, value])
                    }
                    newTable[idx] = value
                })
            }
        })
        this.table = newTable
    }
}
