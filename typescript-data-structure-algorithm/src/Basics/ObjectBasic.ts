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

    /**
     * Prototypes and Prototypal Inheritance:
     */
    public PrototypalInheritance(): void {
        console.log('------>>  Prototypes and Prototypal Inheritance:')
        const Animal = {
            name: '',
            speak() {
                console.log(`${this.name} makes a sound`)
            },
        }
        const Dog = Object.create(Animal)
        Dog.name = 'Dog'
        Dog.speak()
    }

    /**
     * Object Composition
     */
    public ObjectComposition(): void {
        console.log('------>>  Object Composition:')
        const swimmer = {
            swim() {
                // @ts-ignore
                console.log(`${this.name} swims.`)
            },
        }

        const walker = {
            walk() {
                // @ts-ignore
                console.log(`${this.name} walks`)
            },
        }

        const amphibian = {
            name: 'Frog',
            ...swimmer,
            ...walker,
        }

        amphibian.swim()
        amphibian.walk()
    }

    /**
     * Factory Functions and Object Creation Patterns:
     */
    public FactorialFunction(): void {
        console.log('------>>  Factory Functions and Object Creation Patterns::')
        function CreatePerson(name: string, age: number) {
            return {
                name,
                age,
                greet() {
                    console.log(`Hello My name is ${this.name} and I am ${this.age} year old`)
                },
            }
        }

        const person = CreatePerson('Thuta Sann', 22)
        person.greet()
    }

    /**
     * Property Descriptors and Property Attributes:
     */
    public PropertyDescriptors(): void {
        console.log('------>>  Property Descriptors and Property Attributes:')
        const obj = {
            name: 'Thuta Sann',
        }
        const descriptor = Object.getOwnPropertyDescriptor(obj, 'name')
        console.log('descriptor', descriptor)
    }

    /**
     * Getters and Setters
     */
    public GettersAndSetters(): void {
        console.log('------>>  Getters and Setterss:')
        const obj = {
            _name: 'Thuta',
            get() {
                return this._name.toUpperCase()
            },
            set(val: string) {
                this._name = val
            },
        }
        console.log(obj._name)
        obj._name = 'Thuta Sann'
        console.log('obj', obj._name)
    }

    /**
     * Symbol
     */
    public SymbolSample(): void {
        console.log('------>>  Symbol Sample')
        const key = Symbol('description')

        const obj = {
            [key]: 'here is value',
        }
        console.log('obj', obj[key])
    }

    /**
     * Object Freeze
     *
     */
    public ObjectFreeze(): void {
        console.log('------>>  Object Freeze')
        const obj = {
            prop: 42,
        }
        Object.freeze(obj)
        // obj.prop = 100 // this will not have any effect
        console.log('obj.prop', obj.prop)
    }

    /**
     * Object-oriented Programming (OOP) Patterns:
     */
    public OOPProptotype(): void {
        console.log('Object-oriented Programming (OOP) Patterns:')
        class Person {
            name: string
            age: number

            constructor(name: string, age: number) {
                this.name = name
                this.age = age
            }

            greet(): void {
                console.log(`Name is ${this.name} and Age is ${this.age}`)
            }
        }

        const person = new Person('Thuta', 22)
        person.greet()
    }
}
