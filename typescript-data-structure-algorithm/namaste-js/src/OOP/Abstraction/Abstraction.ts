/**
 * # Abstraction
 * @description
 * Abstraction is a fundamental concept in Object-Oriented Programming (OOP) that allows you to model real-world entities by focusing on their essential characteristics while hiding irrelevant details.
 */
export class Abstraction {}

/**
 * # Abstract Class
 * @description
 * Abstract classes are classes that cannot be instantiated directly and are typically used as base classes to define common behavior and properties for subclasses. Abstract classes may contain abstract methods that must be implemented by subclasses.
 */
abstract class Shape {
    abstract GetArea(): number
}

export class AbstractCircle extends Shape {
    constructor(private radius: number) {
        super()
    }

    GetArea(): number {
        return Math.PI * this.radius * this.radius
    }
}

/**
 * # Interface
 * @description
 *  Interfaces define contracts for classes to adhere to, specifying the structure of properties and methods that implementing classes must provide. Interfaces promote loose coupling by allowing classes to interact based on shared behavior rather than explicit inheritance.
 */
interface IShape {
    GetAreaIntrface(): number
}

export class InterfaceCircle implements IShape {
    constructor(private radius: number) {}

    GetAreaIntrface(): number {
        return Math.PI * this.radius * this.radius
    }
}

/**
 * # Access Modifiers
 * @description
 *  Access modifiers (public, private, and protected) control the visibility of class members, allowing you to hide implementation details and expose only the necessary interface to the outside world. Encapsulation, another key principle of OOP, is closely related to access modifiers.
 */
export class AccessModifierCar {
    private speed: number

    constructor() {
        this.speed = 10
    }

    accelerate(): void {
        this.speed += 10
    }

    getSpeed(): number {
        return this.speed
    }
}

/**
 * -------- Abstraction RealLife Sample --------
 */

/** Abstract class representing a bank account */
abstract class BankAccount {
    protected balance: number
    protected readonly status: 'active' | 'inactive' = 'active'

    constructor(initialBalance: number) {
        this.balance = initialBalance
    }

    abstract deposit(amount: number): void
    abstract withdraw(amount: number): void
    abstract getBalance(): number
    abstract getStatus(): 'active' | 'inactive'
}

/** Sub class representing a savings account */
export class SavingsAccount extends BankAccount {
    constructor(initialBalance: number) {
        super(initialBalance)
    }

    deposit(amount: number): void {
        this.balance += amount
    }

    withdraw(amount: number): void {
        if (this.balance >= amount) {
            this.balance -= amount
        } else {
            console.log('Insufficient amount')
        }
    }

    getBalance(): number {
        return this.balance
    }

    getStatus(): 'active' | 'inactive' {
        return this.status
    }
}

/** Sub class representing a current account */
export class CurrentAccount extends BankAccount {
    constructor(initialAmount: number) {
        super(initialAmount)
    }

    deposit(amount: number): void {
        this.balance += amount
    }
    withdraw(amount: number): void {
        if (this.balance >= amount) {
            this.balance -= amount
        } else {
            console.log('Insufficient amount')
        }
    }
    getBalance(): number {
        return this.balance
    }

    getStatus(): 'active' | 'inactive' {
        return this.status
    }
}
