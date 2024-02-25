export class PromiseBasic {
    public WalkDog(): Promise<unknown> {
        return new Promise((resolve, reject) => {
            setTimeout(() => {
                const dogwalked = true
                if (dogwalked) {
                    resolve('You walk the dog 🐕')
                } else {
                    reject("You didn't walk the dog")
                }
            }, 1500)
        })
    }

    public CleanKitchen(): Promise<unknown> {
        return new Promise((resolve, reject) => {
            setTimeout(() => {
                const kitchenCleaned = true
                if (kitchenCleaned) {
                    resolve('You Clean the Kitchen 🧹')
                } else {
                    reject("You didn't clean the kitchen")
                }
            }, 2500)
        })
    }

    public TakeOutTrash(): Promise<unknown> {
        return new Promise((resolve, reject) => {
            setTimeout(() => {
                const takeOutTrash = false
                if (takeOutTrash) {
                    resolve('You take out the trash ♻️')
                } else {
                    reject("You didn't take out trash")
                }
            }, 500)
        })
    }
}
