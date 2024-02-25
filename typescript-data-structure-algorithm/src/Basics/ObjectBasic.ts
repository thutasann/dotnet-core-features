import { NestedObject } from '../utils/types'
import { UtilFunctions } from '../utils'

export class ObjectBasic {
    private utils = new UtilFunctions()

    /**
     * Shallow Copy Sample
     */
    public ShallowCopySample(): void {
        console.log('------>> Shallow Copy Sample')
        const originalObj = {
            a: 1,
            b: {
                c: 2,
            },
        }
        const shallowCopyOne = Object.assign({}, originalObj)
        const shallowCopyTwo = { ...originalObj }

        shallowCopyOne.a = 10
        shallowCopyTwo.b.c = 4

        console.log('originalObj', originalObj)
        console.log('shallowCopyOne', shallowCopyOne)
        console.log('shallowCopyTwo', shallowCopyTwo)
    }

    /**
     * Deep Copy Sample
     */
    public DeepCopySample(): void {
        console.log('------>> Deep Copy Sample')
        const originalObj = {
            a: 1,
            b: {
                c: 2,
            },
        }

        const deepCloneObj = this.utils.DeepCloneFnc(originalObj)

        deepCloneObj.a = 10
        deepCloneObj.b.c = 4

        console.log('Original Obj => ', originalObj)
        console.log('DeepClone Obj', deepCloneObj)
    }

    /**
     * HashMap Sample
     */
    public HashMapSample(userInput: string): void {
        console.log('------>> HashMap Sample')

        type HashMapType = {
            [key: string]: boolean
        }

        const arrString = this.utils.CreateArrayOfString(100, 5)
        const hashMap: HashMapType = {}

        arrString.forEach((arr) => {
            hashMap[arr] = true
        })
        if (hashMap[userInput]) {
            console.log('string exist')
        } else {
            console.log("string doesn't exist")
        }
    }

    /**
     * Nested Object
     */
    public NestedObjectSample(): void {
        const nestedObject: NestedObject = {
            a: 1,
            b: {
                c: 2,
                d: {
                    e: 3,
                },
            },
            f: {
                g: 4,
            },
        }

        const keyToFind = 'g'
        const value = this.utils.FindNestedObjectValueByKey(nestedObject, keyToFind)
        if (value !== undefined) {
            console.log(`Value for key ${keyToFind} is ${value}`)
        } else {
            console.log(`Key ${keyToFind} not found in nested object`)
        }
    }
}
