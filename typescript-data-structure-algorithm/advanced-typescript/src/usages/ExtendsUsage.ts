// ----------- Usage One -----------

function getName<T extends { name: string }>(obj: T): string {
    return obj.name
}

const person = { name: 'Alice', age: 30 }
getName(person)

// ----------- Usage Two (Class Inheritance) -----------
class Animal {
    constructor(public name: string) {}
    speak(): void {
        console.log(`${this.name} makes a sound`)
    }
}

class Dog extends Animal {
    constructor(name: string) {
        super(name)
    }

    public bark(): void {
        console.log(`${this.name} barks.`)
    }
}

const dog = new Dog('Bubby')
dog.speak()
dog.bark()

// ----------- Intersection Types -----------
type A = { a: number }
type B = { b: string }
type C = A & B
const obj: C = { a: 1, b: 'hello' }

// ----------- Conditonal Types -----------
type IsSubType<T, U> = T extends U ? true : false

type Result1 = IsSubType<number, string>
type Result2 = IsSubType<number, number>
