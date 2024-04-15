import { IRandomUser } from '../../utils/types'

export class HashMapUserSearch {
    private users: IRandomUser[]
    private searchIndex: Map<string, IRandomUser[]>

    constructor(users: IRandomUser[]) {
        this.users = users
        this.searchIndex = new Map()

        this.users.forEach((user) => {
            const searchTerms = ['name', 'nicename', 'displayname']
            searchTerms.forEach((term) => {
                const searchTerm = user[term].toLowerCase()
                if (!this.searchIndex.has(searchTerm)) {
                    this.searchIndex.set(searchTerm, [])
                }
                this.searchIndex.get(searchTerm)?.push(user)
            })
        })
    }

    public Search(term: string): IRandomUser[] {
        const searchTerm = term.toLowerCase()
        let searchResults = new Set<IRandomUser>()
        if (this.searchIndex.has(searchTerm)) {
            const usersMatchingTerm = this.searchIndex.get(searchTerm)
            if (usersMatchingTerm) {
                usersMatchingTerm.forEach((user) => {
                    searchResults.add(user)
                })
            }
        }
        return Array.from(searchResults)
    }
}

export abstract class HashMapUserSearchUsage {
    public static SampleOne(): void {
        console.log('\nHashMap User Search sample : ')
        const users: IRandomUser[] = [
            { id: 1, name: 'Alice', nicename: 'alice', displayname: 'Alice Doe' },
            { id: 2, name: 'Bob', nicename: 'bob', displayname: 'Bob Smith' },
            { id: 3, name: 'Charlie', nicename: 'charlie', displayname: 'Charlie Brown' },
        ]

        const userSearch = new HashMapUserSearch(users)
        console.log('search result => ', userSearch.Search('bob'))
    }
}
