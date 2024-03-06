/**
 * # Map Data Structure
 * - data structure to store key-value pairs where both the keys and values can be of any type
 */
export class MapDataStructure {
    private objKey = { name: 'Thuta' }

    public SampleOne(): void {
        const map = new Map()
        map.set('key1', 'value1')
        map.set(2, 'value2')
        map.set(this.objKey, 'value3')

        console.log(`map.get("key1")`, map.get('key1'))
        console.log(`map.get(2)`, map.get(2))
        console.log(`map.get(this.objKey)`, map.get(this.objKey))

        console.log(map.has('key1')) // Output: true

        map.forEach((value, key) => {
            console.log(`Key: ${key}, Value: ${value}`)
        })

        console.log('size ', map.size)
    }
}
