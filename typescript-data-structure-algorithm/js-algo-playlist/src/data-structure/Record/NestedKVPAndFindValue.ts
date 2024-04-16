interface INestedObject {
    [key: string]: INestedObject | string | number
}

const nestedObject: INestedObject = {
    key1: {
        nestedKey1: 'value1',
        nestedKey2: 'value2',
    },
    key2: {
        nestedKey3: {
            nestedNestedKey: 'value3',
        },
        nestedKey4: 'value4',
    },
    key3: 'value5',
    key4: 123,
}

export abstract class NestedKVPAndFindValue {
    public static SampleOne() {
        const searchKey = 'nestedNestedKey'
        console.log('\nNested KVP and Find Value by key')
        const foundValue = this.FindValueByKey(nestedObject, searchKey)
        if (foundValue !== undefined) {
            console.log(`Value for key '${searchKey}':`, foundValue)
        } else {
            console.log(`Key '${searchKey}' not found in the nested object.`)
        }
    }

    private static FindValueByKey(obj: INestedObject, key: string) {
        if (obj.hasOwnProperty(key)) {
            return obj[key]
        }
        for (const nestedKey in obj) {
            if (typeof obj[nestedKey] === 'object') {
                const nestedValue = this.FindValueByKey(obj[nestedKey] as INestedObject, key)
                if (nestedValue !== undefined) {
                    return nestedValue
                }
            }
        }
    }
}
