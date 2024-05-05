class Person {
    constructor(public name: string, public age: number) {}
}

class EqualityComparer<T> {
    private readonly comparer: (a: T, b: T) => boolean

    constructor(comparer: (a: T, b: T) => boolean) {
        this.comparer = comparer
    }

    equals(a: T, b: T): boolean {
        return this.comparer(a, b)
    }
}

export abstract class EqualityComparerUsage {
    public static SampleUsage() {
        console.log('\nEquality comparer Usage : ')
        const person1 = new Person('Alice', 30)
        const person2 = new Person('Bob', 12)
        const person3 = new Person('Alice', 30)

        const personEqualityComparer = new EqualityComparer<Person>((a, b) => a.name == b.name)
        console.log('1 vs 2 => ', personEqualityComparer.equals(person1, person2)) // false
        console.log('1 vs 3 => ', personEqualityComparer.equals(person1, person3)) // true
    }
}
