import { z } from 'zod'

export const formSchema = z.object({
  name: z.string().min(2, {
    message: 'Username must be at least 2 characters.',
  }),
  room: z.string().min(2, {
    message: 'Room is required',
  }),
})
