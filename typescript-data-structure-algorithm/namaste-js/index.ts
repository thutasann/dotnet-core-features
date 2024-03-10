import { AsyncAwait } from './src/AsyncAwait'
import { MethodChainingCalculator } from './src/MethodChaining'
import {
    AbstractCircle,
    AccessModifierCar,
    CurrentAccount,
    InterfaceCircle,
    SavingsAccount,
} from './src/OOP/Abstraction/Abstraction'
import { AbstractOrderService, CreditCardPayment, abstractOrder } from './src/OOP/Abstraction/EcommerceSample'
import { testRepositoryPattern } from './src/OOP/Abstraction/RepositoryPattern'
import {
    DatabaseService,
    InventoryService,
    Logger,
    LoggingService,
    NotificationService,
    UserService,
} from './src/OOP/DI/DepedencyInjection'
import { DIContainer, OrderService, ShoppingCart } from './src/OOP/DI/EcommerceSample'
import { TicketDIService, TicketImpl, TicketRepository, TicketService } from './src/OOP/DI/TicketManagementSample'
import {
    ContractEmployee,
    FullTimeEmployee,
    PartTimeEmployee,
    getPolyTotalSalary,
} from './src/OOP/Polymorphism/PolyEmployees'
import { PolyCircle, PolyRectangle, getPolyTotalArea } from './src/OOP/Polymorphism/PolymorphismSample'
import { product } from './src/utils/constants'

console.log('NAMASTE JAVASCRIPT PLAYLIST ..... 🚀')

// ------------ Async Await  🚀 ------------
console.log('------>> Async Await  🚀 ')
const asyncAwait = new AsyncAwait()

// ------------ Depedency Injection  🚀 ------------
console.log('------>> Depedency Injection Sample  🚀 ')
const logger = new Logger()
const userService = new UserService(logger)
const user = userService.getUser('001')
console.log('USER: ', user)

// ------------ Depedency Injection RealLife Sample  🚀 ------------
console.log('------>> Depedency Injection RealLife Sample 🚀 ')
const databaseService = new DatabaseService()
const loggingService = new LoggingService()
const notifiService = new NotificationService()

const inventoryService = new InventoryService(databaseService, loggingService, notifiService)
inventoryService.addItemToInventory(product)

// ------------ Depedency Injection Ecommerce Sample 🚀 ------------
console.log('------>> Depedency Injection Ecommerce Sample 🚀 ')
const diContainer = new DIContainer()
diContainer.register('ShoppingCart', new ShoppingCart())
diContainer.register('OrderService', new OrderService(diContainer.resolve<ShoppingCart>('ShoppingCart')))

const orderService = diContainer.resolve<OrderService>('OrderService')
orderService.placeOrder()

console.log('------>> Depedency Injection Ticket Management Sample 🚀 ')
TicketDIService.register('TicketRepository', new TicketRepository())
TicketDIService.register(
    'TicketService',
    new TicketService(TicketDIService.resolve<TicketRepository>('TicketRepository'))
)

const ticketService = TicketDIService.resolve<TicketService>('TicketService')
const newTicket = new TicketImpl(1, 'Issue 1', 'This is Issue 1', 'Open')
ticketService.createTicket(newTicket)
console.log('All Tickets ', ticketService.getAllTickets())

const ticketToUpdate = ticketService.getTicketById(1)
if (ticketToUpdate) {
    ticketToUpdate.status = 'Done'
    ticketService.updateTicket(ticketToUpdate)
}
console.log('After updated, Tickets ', ticketService.getAllTickets())

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

// ------------ Abstraction Ecommerce Sample  🚀 ------------
console.log('------>> Abstraction Ecommerce Sample  🚀 ')
const creditCardPayment = new CreditCardPayment()
const abstractOrderService = new AbstractOrderService(creditCardPayment)
abstractOrderService.checkout(abstractOrder)

// ------------ Polymorphism Sample  🚀 ------------
console.log('------>> Polymorphism Sample  🚀 ')
const polyCircle = new PolyCircle('Circle', 8)
const polyRectange = new PolyRectangle('Rectangle', 4, 8)
const totalArea = getPolyTotalArea([polyCircle, polyRectange])
console.log('Total Poly Area => ', totalArea)

// Polymorphism Employee sample
const fullTimeEmployee = new FullTimeEmployee(1, 'John Doe', 5000)
const partTimeEmployee = new PartTimeEmployee(2, 'Jane Smith', 40, 15)
const contractEmployee = new ContractEmployee(3, 'Alice Johnson', 6, 1000)
const polyTotalSalary = getPolyTotalSalary([fullTimeEmployee, partTimeEmployee, contractEmployee])
console.log('polyTotalSalary => ', polyTotalSalary)

// ------------ Repository Pattern  🚀 ------------
testRepositoryPattern()

// ------------ Method Chaining  🚀 ------------
console.log('------>> Method Chaining  🚀 ')
const calculatorResult = new MethodChainingCalculator(10).add(5).substract(3).multiply(2).divide(4).getValue()
console.log('calculatorResult ', calculatorResult)
