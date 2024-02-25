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

    public PromiseAllSample() {
        const promise1 = Promise.resolve(3)
        const promise2 = 42
        const promise3 = new Promise((resolve, reject) => {
            setTimeout(() => {
                resolve('foo')
            }, 100)
        })

        Promise.all([promise1, promise2, promise3]).then((values) => {
            console.log(values) // 3, 42, 'foo'
        })
    }
}
