/**
 * # Methood Chaining Calculator Interface
 */
interface IMethodChainingCalculator {
    add(num: number): ThisType<MethodChainingCalculator>
    substract(num: number): ThisType<MethodChainingCalculator>
    multiply(num: number): ThisType<MethodChainingCalculator>
    divide(num: number): ThisType<MethodChainingCalculator>
    getValue(): number
}

/**
 * # Methood Chaining Calculator Sample
 * - Each method modifies the value property of the Calculator instance and returns this, allowing method chaining.
 */
export class MethodChainingCalculator implements IMethodChainingCalculator {
    private value: number

    constructor(initialValue: number) {
        this.value = initialValue
    }
    substract(num: number): this {
        this.value -= num
        return this
    }

    multiply(num: number): this {
        this.value *= num
        return this
    }

    divide(num: number): this {
        if (num !== 0) {
            this.value /= num
        }
        return this
    }

    getValue(): number {
        return this.value
    }

    add(num: number): this {
        this.value += num
        console.log('this ', this)
        return this
    }
}
