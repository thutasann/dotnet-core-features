interface Animal {
    name: string
}

interface Human {
    firstName: string
    lastName: string
}

export abstract class WhenUseGeneric {
    public static SampleOne(): void {
        console.log('\nWhen Usage Generic Sample : ')

        const getDisplayName = <TItem extends Animal | Human>(
            item: TItem
        ): { humanName: string } | { animalName: string } => {
            if ('name' in item) {
                return {
                    animalName: item.name,
                }
            } else {
                return {
                    humanName: item.firstName + ' ' + item.lastName,
                }
            }
        }
        const result1 = getDisplayName<Animal>({ name: 'patch' })
        console.log('result1', result1)

        const result2 = getDisplayName<Human>({ firstName: 'Thuta', lastName: 'Sann' })
        console.log('result2', result2)
    }
}
