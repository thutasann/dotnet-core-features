export abstract class ForConstInSamples {
    public static SampleOne() {
        console.log('\nFor Const In SampleOne => ')
        const person = {
            name: 'John',
            age: 30,
            gender: 'male',
        }

        for (const key in person) {
            console.log('key: ', person[key])
        }
    }

    public static SampleTwo() {
        console.log('For Const In SampleTwo => ')
        const colors = ['red', 'green', 'blue']

        for (const index in colors) {
            console.log('index: ', colors[index])
        }
    }

    public static SampleThree() {
        console.log('For Const In SampleThree (Iterating Over Prototype Properties:) => ')
        function Person(name: string, age: number) {
            name = name
            age = age
        }

        Person.prototype.gender = 'male'

        const john = new Person('John', 30)

        for (const key in john) {
            console.log('key: ', john[key])
        }
    }

    public static SampleFour() {
        console.log('For Const In Sample Four ==> ')
        const obj = Object.create({ fool: 1 })
        obj.bar = 2
        for (const key in obj) {
            console.log('key => ', key)
        }
    }
}
