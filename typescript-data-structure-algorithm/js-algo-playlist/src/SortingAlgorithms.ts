/**
 * Topological Sorting
 * - [Link](https://en.wikipedia.org/wiki/Topological_sorting)
 */
export abstract class TopologicalSorting {
    public static SolutionOne(): void {
        console.log('\nTopological Sorting Solution One')
        let inputs = [
            'KittenService: ',
            'Leetmeme: Cyberportal',
            'Cyberportal: Ice',
            'CamelCaser: KittenService',
            'Fraudstream: Leetmeme',
            'Ice: ',
        ]
        let depedencies = {}
        let result: string[] = []

        // Form the depedency graph
        for (let i = 0; i < inputs.length; i++) {
            let inputSplit = inputs[i].split(':')
            let key = inputSplit[0].trim()
            let value = inputSplit[1].trim()
            depedencies[key] = value
        }

        for (const key in depedencies) {
            if (depedencies.hasOwnProperty(key)) {
                visit(key)
            }
        }

        function visit(key: string) {
            if (!depedencies.hasOwnProperty(key)) return

            if (depedencies[key] !== '') {
                visit(depedencies[key])
            }

            result.push(key)
            delete depedencies[key]
        }

        console.log('Result => ', result)
    }
}
