/**
 * Base Class Representing an Employee
 */
export abstract class PolyEmployee {
    constructor(public id: number, public name: string) {}

    /** Abstract method to calculate salary (to be implemented by subclasses) */
    abstract calculateSalary(): number
}

export class FullTimeEmployee extends PolyEmployee {
    constructor(id: number, name: string, public monthlySalary: number) {
        super(id, name)
    }

    calculateSalary(): number {
        return this.monthlySalary
    }
}

export class PartTimeEmployee extends PolyEmployee {
    constructor(id: number, name: string, public hoursWorked: number, public hourlyRate: number) {
        super(id, name)
    }

    calculateSalary(): number {
        return this.hoursWorked * this.hourlyRate
    }
}

export class ContractEmployee extends PolyEmployee {
    constructor(id: number, name: string, public contractDuration: number, public contractRate: number) {
        super(id, name)
    }

    calculateSalary(): number {
        return this.contractDuration * this.contractRate
    }
}

export function getPolyTotalSalary(employees: PolyEmployee[]): number {
    let totalSalary = 0
    for (const employee of employees) {
        totalSalary += employee.calculateSalary()
    }
    return totalSalary
}
