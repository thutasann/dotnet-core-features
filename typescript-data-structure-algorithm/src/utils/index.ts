/**
 * Util Functions
 */
export class UtilFunctions {
    /**
     * Deep Clone Function
     */
    public DeepCloneFnc<T = object>(obj: T): T {
        if (obj === null || typeof obj !== 'object') {
            return obj
        }

        let clone: any = Array.isArray(obj) ? [] : {}

        for (let key in obj) {
            if (obj.hasOwnProperty(key)) {
                clone[key] = this.DeepCloneFnc(obj[key])
            }
        }

        return clone
    }

    /**
     * Create Thousand of Array String
     */
    public CreateArrayOfString(length: number, stringLength: number): string[] {
        const arrayOfStrings: string[] = []
        const characters = 'ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789'

        for (let i = 0; i < length; i++) {
            let randomString: string = ''
            for (let j = 0; j < stringLength; j++) {
                randomString += characters.charAt(Math.floor(Math.random() * characters.length))
                arrayOfStrings.push(randomString)
            }
        }
        return arrayOfStrings
    }
}
