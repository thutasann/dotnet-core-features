// ----------- Get a member of an union -----------
type Animal = 'cat' | 'dog' | 'bird' | 'fish'
type OnlyCat = Extract<Animal, 'cat'>
const cat: OnlyCat = 'cat'

// ----------- Get multiple members of an union -----------
type ExtractType = Extract<Animal, 'cat' | 'dog'>
const extractedMultiple: ExtractType = 'cat'

// ----------- Get a member of a discriminated union -----------
type Shape =
    | {
          type: 'square'
      }
    | {
          type: 'circle'
      }
    | {
          type: 'triangle'
      }
type SquareShape = Extract<Shape, { type: 'square' }>
type SqaureAndCircleShape = Extract<Shape, { type: 'square' | 'circle' }>
const square: SquareShape = { type: 'square' }
const squareAndCircle: SqaureAndCircleShape = { type: 'circle' }

// ----- https://dev.to/arafat4693/best-ways-to-use-extract-in-typescript-jc2#get-a-member-of-an-union
