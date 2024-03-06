interface ITicket {
    id: number
    title: string
    description: string
    status: string
}

interface ITicketRepository {
    getAllTickets(): ITicket[]
    getTicketById(id: number): ITicket | undefined
    createTicket(ticket: ITicket): void
    updateTicket(ticket: ITicket): void
    deleteTicket(id: number): void
}

export class TicketImpl implements ITicket {
    id: number
    title: string
    description: string
    status: string

    constructor(id: number, title: string, description: string, status: string) {
        this.id = id
        this.title = title
        this.description = description
        this.status = status
    }
}

export class TicketRepository implements ITicketRepository {
    private tickets: ITicket[] = []

    getAllTickets(): ITicket[] {
        return this.tickets
    }

    getTicketById(id: number): ITicket | undefined {
        return this.tickets.find((ticket) => ticket.id === id)
    }

    createTicket(ticket: ITicket): void {
        this.tickets.push(ticket)
    }

    updateTicket(ticket: ITicket): void {
        const index = this.tickets.findIndex((t) => t.id === ticket.id)
        if (index !== -1) this.tickets[index] = ticket
    }

    deleteTicket(id: number): void {
        this.tickets = this.tickets.filter((t) => t.id !== id)
    }
}

export class TicketService {
    constructor(private ticketRepo: TicketRepository) {}

    getAllTickets(): ITicket[] {
        return this.ticketRepo.getAllTickets()
    }

    getTicketById(id: number): ITicket | undefined {
        return this.ticketRepo.getTicketById(id)
    }

    createTicket(ticket: ITicket): void {
        this.ticketRepo.createTicket(ticket)
    }

    updateTicket(ticket: ITicket): void {
        this.ticketRepo.updateTicket(ticket)
    }

    deleteTicket(id: number): void {
        this.ticketRepo.deleteTicket(id)
    }
}

export class TicketDIService {
    private static instances: Map<string, any> = new Map()

    static register<T>(key: string, instance: T): void {
        this.instances.set(key, instance)
    }

    static resolve<T>(key: string): T {
        if (!this.instances.has(key)) {
            throw new Error(`Depedency ${key} is not registered`)
        }
        return this.instances.get(key)
    }
}
