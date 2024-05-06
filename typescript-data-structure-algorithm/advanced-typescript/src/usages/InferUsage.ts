type FunctionType<T> = (arg: T) => void

type ArgumentType<T> = T extends FunctionType<infer U> ? U : never

function logType<T>(arg: T) {
    console.log(typeof arg)
}

logType(123) // "number"
logType('hello') // "string"

function processCallBack<T extends FunctionType<any>>(callback: T) {
    type ArgType = ArgumentType<T>
    console.log('Argument Type : ', typeof {} as ArgType)
}

processCallBack((x: number) => console.log(x * 2))
processCallBack((name: string) => console.log(`Hello ${name}`))
