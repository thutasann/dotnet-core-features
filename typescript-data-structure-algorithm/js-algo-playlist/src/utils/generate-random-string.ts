import { IRandomUser } from './types'

export abstract class GenerateRandomUsers {
    private static userIdCounter = 1

    public static generateUserArray(count: number): IRandomUser[] {
        let users: IRandomUser[] = []
        for (let i = 0; i < count; i++) {
            users.push(this.generateUser())
        }
        return users
    }

    private static generateUser(): IRandomUser {
        return {
            id: this.userIdCounter++,
            name: this.generateRandomString(8),
            nicename: this.generateRandomString(8),
            displayname: this.generateRandomString(8),
        }
    }

    private static generateRandomString(length: number): string {
        const chars = 'abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ'
        let result = ''
        for (let i = 0; i < length; i++) {
            result += chars.charAt(Math.floor(Math.random() * chars.length))
        }
        return result
    }
}
