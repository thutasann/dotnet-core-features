/**
 * # Map Data Structure
 * - data structure to store key-value pairs where both the keys and values can be of any type
 */
export abstract class MapDataStructure {
    private static objKey = { name: 'Thuta' }

    public static SampleOne(): void {
        console.log('\nMap Sample One: ')
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

export abstract class NestedMap {
    public static SampleOne(): void {
        console.log('\nNested Map Sample One')
        const nestedMap: Map<string, Map<string, number>> = new Map()

        nestedMap.set(
            'outerKey1',
            new Map([
                ['innerKey1', 10],
                ['innerKey2', 20],
            ])
        )

        nestedMap.set(
            'outerKey2',
            new Map([
                ['innerKey3', 30],
                ['innerKey4', 40],
            ])
        )

        console.log('nestedMap access val => ', nestedMap.get('outerKey1')?.get('innerKey1'))

        nestedMap.forEach((innerMap, outerKey) => {
            innerMap.forEach((value, innerKey) => {
                console.log(`Outer Key: ${outerKey}, Inner Key: ${innerKey}, Value: ${value}`)
            })
        })
    }
}
