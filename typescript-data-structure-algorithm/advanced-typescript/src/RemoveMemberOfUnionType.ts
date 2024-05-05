type Letters = 'a' | 'b' | 'c'

type RemoveC<TTYpe> = TTYpe extends 'c' ? { name: string } : TTYpe

type WowWithoutC = RemoveC<Letters>

/**
 * Remvoe Member of Union Type
 */
export function RemoveUnionMember() {
    console.log('\nRemove Union Type Member : ')
    const withoutC: WowWithoutC = 'a'
    console.log('withoutC', withoutC)
}
