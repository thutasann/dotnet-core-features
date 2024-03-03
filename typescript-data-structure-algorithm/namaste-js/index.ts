import { AsyncAwait } from './src/AsyncAwait'
import {
    AbstractCircle,
    AccessModifierCar,
    CurrentAccount,
    InterfaceCircle,
    SavingsAccount,
} from './src/OOP/Abstraction'
import {
    DatabaseService,
    InventoryService,
    Logger,
    LoggingService,
    NotificationService,
    UserService,
} from './src/OOP/DepedencyInjection'
import { product } from './src/utils/constants'

console.log('NAMASTE JAVASCRIPT PLAYLIST ..... 🚀')

// ------------ Async Await  🚀 ------------
console.log('------>> Async Await  🚀 ')
const asyncAwait = new AsyncAwait()
// asyncAwait.SampleOne()

// ------------ Depedency Injection  🚀 ------------
console.log('------>> Depedency Injection Sample  🚀 ')
const logger = new Logger()
const userService = new UserService(logger)
const user = userService.getUser('001')
console.log('USER: ', user)

console.log('------>> Depedency Injection RealLife Sample 🚀 ')
const databaseService = new DatabaseService()
const loggingService = new LoggingService()
const notifiService = new NotificationService()

const inventoryService = new InventoryService(databaseService, loggingService, notifiService)
inventoryService.addItemToInventory(product)

// ------------ Abstraction  🚀 ------------
console.log('------>> Abstraction  🚀 ')
const abstractCircle = new AbstractCircle(12)
console.log('abstract circle radius', abstractCircle.GetArea())

const interfaceCircle = new InterfaceCircle(12)
console.log('interface circle radius', interfaceCircle.GetAreaIntrface())

const car = new AccessModifierCar()
console.log('car speed ', car.getSpeed())

const savingsAccount = new SavingsAccount(1200)
savingsAccount.deposit(500)
savingsAccount.withdraw(200)
console.log('Saving account balance: ', savingsAccount.getBalance())

const currentAccount = new CurrentAccount(2000)
currentAccount.deposit(1000)
currentAccount.withdraw(2500)
console.log('Current Account Balance:', currentAccount.getBalance())
console.log('Current Account status:', currentAccount.getStatus())
