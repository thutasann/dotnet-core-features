/**
 * -------- Depedency Injection Sample --------
 * @description
 * Dependency Injection (DI) is a design pattern widely used in software engineering, including JavaScript, to create more modular, maintainable, and testable code. In DI, the dependencies required by a class or module are provided externally rather than being created or managed internally.
 */
export class DepedencyInjection {}

export class Logger {
    log(message: string) {
        console.log('From Logger => ', message)
    }
}

export class UserService {
    private readonly logger: Logger

    constructor(logger: Logger) {
        this.logger = logger
    }

    getUser(id: string) {
        this.logger.log(`Fetching user with ${id}`)
        return { id, name: 'John Doe' }
    }
}

/**
 * -------- Depedency Injection RealLife Sample --------
 */

export interface IProduct {
    name: string
    quantity: number
}

interface IInventoryService<T> {
    addItemToInventory(item: T): void
}

export class DatabaseService<T> {
    constructor() {}

    saveInventoryItem(item: T) {
        console.log(`Save item to database ${JSON.stringify(item)}`)
    }
}

export class LoggingService {
    log(message: string) {
        console.log(`From Logging Message: ${message}`)
    }
}

export class NotificationService {
    sendAlrt(message: string) {
        console.log(`Sending alert : ${message}`)
    }
}

export class InventoryService implements IInventoryService<IProduct> {
    private _databaseService: DatabaseService<IProduct>
    private _loggingService: LoggingService
    private _notificationService: NotificationService

    constructor(
        databaseService: DatabaseService<IProduct>,
        loggingService: LoggingService,
        notificationService: NotificationService
    ) {
        this._databaseService = databaseService
        this._loggingService = loggingService
        this._notificationService = notificationService
    }

    addItemToInventory(item: IProduct): void {
        this._databaseService.saveInventoryItem(item)
        this._loggingService.log(`Added item to inventory ${JSON.stringify(item)}`)
        this._notificationService.sendAlrt(`new item added to inventory ${item.name}`)
    }
}
