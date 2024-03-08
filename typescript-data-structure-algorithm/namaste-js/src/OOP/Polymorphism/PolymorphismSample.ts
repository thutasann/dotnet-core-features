/**
 * # Polymorphism
 * - that allows objects of different classes to be treated as objects of a common superclass.
 * - This enables code to work with objects of various types in a uniform manner, providing flexibility and extensibility to the design.
 */
class PolymorphismSample {}

/** Base Shape Class */
class PolyShape {
    constructor(public name: string) {}

    public calculateArea(): number {
        return 0
    }
}

/** Sub Class Circle */
export class PolyCircle extends PolyShape {
    constructor(public name: string, public radius: number) {
        super(name)
    }

    public calculateArea(): number {
        return Math.PI * this.radius ** 2
    }
}

/** Sub Class Rectangle */
export class PolyRectangle extends PolyShape {
    constructor(public name: string, public width: number, public height: number) {
        super(name)
    }

    public calculateArea(): number {
        return this.width * this.height
    }
}

export function getPolyTotalArea(shapes: PolyShape[]): number {
    let totalArea = 0
    for (let shape of shapes) {
        totalArea += shape.calculateArea()
    }
    return totalArea
}
